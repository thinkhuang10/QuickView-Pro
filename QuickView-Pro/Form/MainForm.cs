using CommonTools;
using EasyModbus;
using InfluxDBDriver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickView_Pro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void OpenProject()
        { 
        
        }

        #region 工具栏

        private void 新建工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewProject();
            var dialog = form.ShowDialog();

            if (DialogResult.OK != dialog)
                return;

            OpenProject();
        }

        private void 打开工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = $"工程文件|*{ConstantHelper.ProjectSuffixName}",
                InitialDirectory = PathHelper.GetDefaultProjectPath()
            };

            if (DialogResult.OK != dialog.ShowDialog())
                return;

            OpenProject();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        #endregion

        private async void 启动记录ToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            var influxDBClient = new InfluxDBClientHelper();

            var configPath = "C:\\Users\\hp\\Desktop\\1\\InfluxdDBCfg.json";
            await influxDBClient.InitAsync(configPath);

            // 1. 写入单条温度数据
            var tempFields = new Dictionary<string, object>
                    {
                        { "value", 33 } // 温度值
                    };
            var tempTags = new Dictionary<string, string>
                    {
                        { "sensor_id", "sensor-001" },
                        { "location", "车间A" }
                    };
            influxDBClient.WriteData("temperature", tempFields, tempTags);
            Console.WriteLine("温度数据写入成功");
        }

        private void 启动通讯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: 测试完成ModusTCP写值
            //ModbusClient modbusClient = new ModbusClient();

            //modbusClient.IPAddress = "127.0.0.1";
            //modbusClient.Port = 502;
            //modbusClient.Connect();

            //modbusClient.WriteSingleRegister(0, 36);
        }
    }
}