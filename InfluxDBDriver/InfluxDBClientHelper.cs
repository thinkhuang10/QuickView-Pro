using CommonTools;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client;
using LogTool;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections.Generic;
using InfluxDB.Client.Writes;
using System.Linq;

namespace InfluxDBDriver
{
    public class InfluxDBClientHelper
    {
        private const string m_duration = "5m0s";

        private InfluxdbInfo influxdbInfo;

        private Process myProcess;

        private string superTokenName;

        private InfluxDBClient m_client;

        private TokenInfo m_token;

        private string m_url;

        List<BucketInfo> m_buckets;

        private WriteApi m_writeApi = null;

        private AuthorizationsApi m_authorizationsApi = null;

        private bool isConnected;

        public async Task InitAsync(string cfgFile)
        {
            m_buckets = new List<BucketInfo>();
            m_token = new TokenInfo();

            influxdbInfo = JsonHelper.ReadFile<InfluxdbInfo>(cfgFile);

            if (!IsInfluxDBRunning())
            {
                StartInfluxDBProcess();
            }

            await CreateInfluxDBClient();
        }

        public async Task CreateInfluxDBClient()
        {
            try
            {
                AddBuckets();
                superTokenName = influxdbInfo.UserName + "'s Token";
                if (m_client == null)
                {
                    m_url = "http://localhost" + ":" + influxdbInfo.Port.ToString();
                    m_client = new InfluxDBClient(m_url, influxdbInfo.UserName, influxdbInfo.PassWord);
                }
                bool isOnboarding = await m_client.IsOnboardingAllowedAsync();
                if (isOnboarding)
                {
                    OnboardingRequest request = new OnboardingRequest(influxdbInfo.UserName, 
                        influxdbInfo.PassWord, influxdbInfo.Org, m_buckets[0].Name, m_buckets[0].RetentionTime);
                    m_url = "http://localhost" + ":" + influxdbInfo.Port.ToString();
                    var onboarding = await InfluxDBClientFactory.Onboarding(m_url, request);
                    m_token.Token = onboarding.Auth.Token;
                    m_client = null;
                    m_client = new InfluxDBClient(m_url, onboarding.Auth.Token);
                }
                else
                {
                    bool success = await ReGetSuperToken();
                    if (success)
                    {
                        m_client = null;
                        m_client = new InfluxDBClient(m_url, m_token.Token);
                    }
                }
                await CreateBucketsByJson();
                m_authorizationsApi = m_client.GetAuthorizationsApi();
                m_writeApi = m_client.GetWriteApi(new WriteOptions
                {
                    BatchSize = 8000,
                    FlushInterval = 200,
                    MaxRetries = 3,
                    MaxRetryDelay = 5000
                });
                isConnected = true;
                //StartPingThread();
            }
            catch (Exception ex)
            {
                LoginByUser();
            }
        }

        private async void LoginByUser()
        {
            AddBuckets();
            if (m_client == null)
            {
                m_url = "http://localhost" + ":" + influxdbInfo.Port.ToString();
                m_client = new InfluxDBClient(m_url, influxdbInfo.UserName, influxdbInfo.PassWord);
            }
            await CreateBucketsByJson();
            m_authorizationsApi = m_client.GetAuthorizationsApi();
            m_writeApi = m_client.GetWriteApi(new WriteOptions
            {
                BatchSize = 8000,
                FlushInterval = 200,
                MaxRetries = 3,
                MaxRetryDelay = 5000
            });
            isConnected = true;
            await ReGetSuperToken();
        }

        /// <summary>
        /// 同步写入单条数据
        /// </summary>
        /// <param name="measurement">测量名称（类似表名）</param>
        /// <param name="fields">字段集合（键值对，如：温度、湿度等）</param>
        /// <param name="tags">标签集合（用于索引和过滤，如：设备ID、位置等）</param>
        /// <param name="timestamp">数据时间戳（可选，默认使用当前时间）</param>
        public void WriteData(string measurement,
                             Dictionary<string, object> fields,
                             Dictionary<string, string> tags = null,
                             DateTime? timestamp = null)
        {
            try
            {
                // 创建数据点
                var point = PointData.Measurement(measurement);

                // 添加标签
                if (tags != null)
                {
                    foreach (var tag in tags)
                    {
                        point = point.Tag(tag.Key, tag.Value);
                    }
                }

                // 添加字段
                foreach (var field in fields)
                {
                    point = point.Field(field.Key, field.Value);
                }

                // 设置时间戳（默认使用当前UTC时间）
                var time = timestamp ?? DateTime.UtcNow;
                point = point.Timestamp(time, WritePrecision.Ns);

                // 写入数据
                m_writeApi.WritePoint(point, string.Format("QuickView_{0}", influxdbInfo.Guid), influxdbInfo.Org);
            }
            catch (Exception ex)
            {
                throw new Exception($"写入InfluxDB失败: {ex.Message}", ex);
            }
        }

        private async Task<bool> ReGetSuperToken()
        {
            if (m_client != null)
            {
                List<Authorization> authorizations = await m_client.GetAuthorizationsApi().FindAuthorizationsByUserNameAsync(influxdbInfo.UserName);
                if (m_token == null)
                {
                    m_token = new TokenInfo();
                }
                foreach (var auth in authorizations)
                {
                    if (auth.Description == superTokenName || auth.Permissions.Count >= 44)
                    {
                        m_token.Token = auth.Token;
                        return true;
                    }
                }
            }
            return false;
        }

        private async Task CreateBucketsByJson()
        {
            try
            {
                if (m_client != null)
                {
                    foreach (var bucket in m_buckets)
                    {
                        await CreateBucket(string.Format("QuickView_{0}", influxdbInfo.Guid), 15768000);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public async Task CreateBucket(string bucketName, long expireTime)
        {
            if (m_client != null)
            {
                var _bucketApi = m_client.GetBucketsApi();
                var orgId = (await m_client.GetOrganizationsApi().FindOrganizationsAsync(org: influxdbInfo.Org)).First().Id;
                // Create bucket 'bucketName' with data retention set to 'expireTime' seconds
                var bucket = await _bucketApi.FindBucketByNameAsync(bucketName);
                if (bucket == null)
                {
                    var retention = new BucketRetentionRules(BucketRetentionRules.TypeEnum.Expire, expireTime);
                    await _bucketApi.CreateBucketAsync(bucketName, retention, orgId);
                }
            }
        }

        private void AddBuckets()
        {
            if (influxdbInfo != null && m_buckets.Count <= 0)
            {
                m_buckets.Add(new BucketInfo(string.Format("QuickView_{0}", influxdbInfo.Guid), 1000, BucketType.LogData));
            }
        }

        private bool IsInfluxDBRunning()
        {
            if (Process.GetProcessesByName("influxd").Length == 0)
                return false;

            NLogLogger.Trace("InfluxDB已经启动.");
            return true;
        }

        private bool StartInfluxDBProcess()
        {
            bool isSuccess = false;
            myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = "InfluxDB\\influxd.exe";
                string enginePath = influxdbInfo.StoragePath + "\\.influxdbv2\\engine";
                string boltPath = influxdbInfo.StoragePath + "\\.influxdbv2\\influxd.bolt";
                string sqlitePath = influxdbInfo.StoragePath + "\\.influxdbv2\\influxd.sqlite";
                string args = string.Format("--http-bind-address :{0} --bolt-path \"{1}\" --engine-path \"{2}\" --sqlite-path \"{3}\" --storage-retention-check-interval {4} --log-level warn", 
                    influxdbInfo.Port, boltPath, enginePath, sqlitePath, m_duration);
                myProcess.StartInfo.Arguments = args;
                myProcess.EnableRaisingEvents = true;
                isSuccess = myProcess.Start();
            }
            catch (Exception ex)
            {
                NLogLogger.Error($"InfluxDB启动失败:{ex}");
            }
            return isSuccess;
        }
    }
}
