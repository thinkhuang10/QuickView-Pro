using LogTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace InfluxDBDriver
{
    public class InfluxDBClientHelper
    {
        public async Task Init(string cfgFile)
        { 
        
        }

        private bool IsInfluxDBRunning()
        {
            if (Process.GetProcessesByName("influxd").Length == 0)
                return false;

            NLogLogger.Trace("InfluxDB process has already running");
            return true;
        }

        private bool StartInfluxDBProcess()
        {
            bool isSuccess = false;
            //myProcess = new Process();
            //try
            //{
            //    myProcess.StartInfo.UseShellExecute = false;
            //    myProcess.StartInfo.FileName = "InfluxDB\\influxd.exe";
            //    string enginePath = m_info.StoragePath + "\\.influxdbv2\\engine";
            //    string boltPath = m_info.StoragePath + "\\.influxdbv2\\influxd.bolt";
            //    string sqlitePath = m_info.StoragePath + "\\.influxdbv2\\influxd.sqlite";
            //    string args = string.Format("--http-bind-address :{0} --bolt-path \"{1}\" --engine-path \"{2}\" --sqlite-path \"{3}\" --storage-retention-check-interval {4} --log-level warn", m_info.Port, boltPath, enginePath, sqlitePath, m_duration);
            //    myProcess.StartInfo.Arguments = args;
            //    myProcess.EnableRaisingEvents = true;
            //    myProcess.Exited += handler;
            //    isSuccess = myProcess.Start();
            //}
            //catch (Exception e)
            //{
            //    Log.InsertTrace(Log.LogCategory.Error, string.Format("InfluxDB process start failed, error msg:{0}", e.Message), GetType().Name);
            //}
            return isSuccess;
        }
    }
}
