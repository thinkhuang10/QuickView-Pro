using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using System;
using System.IO;
using System.Text;

namespace LogTool
{
    public class NLogLogger
    {
        private static readonly Logger _logger;
        private static bool _isInitialized = false;

        /// <summary>
        /// 静态构造函数，初始化NLog配置
        /// </summary>
        static NLogLogger()
        {
            InitializeLogger();
            _logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// 初始化NLog配置
        /// </summary>
        private static void InitializeLogger()
        {
            if (_isInitialized)
                return;

            // 创建配置对象
            var config = new LoggingConfiguration();

            // 定义日志文件保存路径：ProgramData/应用名称/Logs
            string appName = "QuickView-Pro"; // 替换为你的应用名称
            string logDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                appName,
                "Logs"
            );

            // 确保目录存在
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            // 创建文件目标
            var fileTarget = new FileTarget("fileTarget")
            {
                // 日志文件路径和名称，按日期命名
                FileName = Path.Combine(logDirectory, "${date:format=yyyy-MM-dd}.log"),
                // 归档文件名称格式
                ArchiveFileName = Path.Combine(logDirectory, "${date:format=yyyy-MM-dd}.{#}.log"),
                // 每天归档
                ArchiveEvery = FileArchivePeriod.Day,
                // 日志内容布局
                Layout = new SimpleLayout("${longdate} [${level:uppercase=true}] ${message} ${exception:format=tostring}"),
                // 编码格式，防止中文乱码
                Encoding = Encoding.UTF8,
                // 启用文件滚动
                EnableFileDelete = true
            };

            // 添加目标到配置
            config.AddTarget(fileTarget);

            // 设置日志规则：最小日志级别为Trace，所有日志都写入文件
            var rule = new LoggingRule("*", LogLevel.Trace, fileTarget);
            config.LoggingRules.Add(rule);

            // 应用配置
            LogManager.Configuration = config;

            _isInitialized = true;
        }

        /// <summary>
        /// 记录Trace级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Trace(string message)
        {
            _logger.Trace(message);
        }

        /// <summary>
        /// 记录Debug级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// 记录Info级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Info(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// 记录Warn级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Warn(string message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// 记录Error级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// 记录Error级别的日志，包含异常信息
        /// </summary>
        /// <param name="message">日志消息</param>
        /// <param name="ex">异常对象</param>
        public static void Error(string message, Exception ex)
        {
            _logger.Error(ex, message);
        }

        /// <summary>
        /// 记录Fatal级别的日志
        /// </summary>
        /// <param name="message">日志消息</param>
        public static void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        /// <summary>
        /// 记录Fatal级别的日志，包含异常信息
        /// </summary>
        /// <param name="message">日志消息</param>
        /// <param name="ex">异常对象</param>
        public static void Fatal(string message, Exception ex)
        {
            _logger.Fatal(ex, message);
        }

        /// <summary>
        /// 关闭日志，确保所有日志都被写入
        /// </summary>
        public static void Shutdown()
        {
            LogManager.Shutdown();
        }
    }
}
