using CommonTools;
using LogTool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuickView_Pro
{
    public partial class NewProject : Form
    {
        public string ProjeceFilePath;

        public NewProject()
        {
            InitializeComponent();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            tbProjectLocation.Text = PathHelper.GetDefaultProjectPath();
        }

        private void btOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                tbProjectLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btOK_Click(object sender, EventArgs e)
        {
            var projectName = tbProjectName.Text.Trim();
            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("请输入工程名称！", ConstantHelper.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var locationPath = tbProjectLocation.Text.Trim();
            if (string.IsNullOrEmpty(locationPath))
            {
                MessageBox.Show("请输入工程路径！", ConstantHelper.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var projectPath = Path.Combine(locationPath, projectName);
            if (Directory.Exists(projectPath))
            {
                MessageBox.Show("工程名称已存在，请修改！", ConstantHelper.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Directory.CreateDirectory(projectPath);

                // 生成工程Guid
                var guid = Guid.NewGuid();

                // 创建工程文件
                var filePath = Path.Combine(projectPath, projectName + ConstantHelper.ProjectSuffixName);
                var projectInfo = new ProjectInfo
                {
                    Description = rtbProjectDescription.Text.Trim(),
                    ProjectGuid = guid.ToString()
                };
                await JsonHelper.WriteFile(projectInfo, filePath);

                var configDirPath = Path.Combine(projectPath, "Config");
                Directory.CreateDirectory(configDirPath);

                //// 创建设备文件
                //var devicePath = Path.Combine(configDirPath, ConstantHelper.DeviceFileName);
                //await JSONHelper.WriteFile(new Dictionary<string, DeviceConfig>(), devicePath);

                //// 创建变量文件
                //var tagPath = Path.Combine(configDirPath, ConstantHelper.TagFileName);
                //await JSONHelper.WriteFile(new Dictionary<string, object>(), tagPath);

                //// 创建变量组文件
                //var tagGroupPath = Path.Combine(configDirPath, ConstantHelper.TagGroupFileName);
                //await JSONHelper.WriteFile(new List<TagGroup>() {
                //        new TagGroup() { Id = 0, ParentId = -1, Name = "默认变量组",Children = new List<TagGroup> () } }, tagGroupPath);

                //// 创建引用变量文件
                //var tagReferencePath = Path.Combine(configDirPath, ConstantHelper.TagReferenceFileName);
                //await JSONHelper.WriteFile(new Dictionary<string, TagReference>(), tagReferencePath);

                //// 创建历史数据库文件
                //var historianDBPath = Path.Combine(configDirPath, ConstantHelper.HistorianDBCfgFileName);
                //var dbConfigurationModel = new InfluxDBConfigModel();
                //await JSONHelper.WriteFile(dbConfigurationModel, historianDBPath);

                //// 创建IO Server配置文件
                //var ioServerConfigModel = new IOServerConfigModel();
                //ioServerConfigModel.Guid = guid.ToString();

                //var infulxDBPath = Path.Combine(configDirPath, dbConfigurationModel.CfgPath);
                //await JSONHelper.WriteFile(ioServerConfigModel, infulxDBPath);

                //// 创建用户权限信息文件
                //var userInfoFilePath = Path.Combine(configDirPath, ConstantHelper.UserInfoFileName);
                //await JSONHelper.WriteFile(new Dictionary<string, UserInfo>(), userInfoFilePath);

                //// 创建调度文件
                //var scheduleFilePath = Path.Combine(configDirPath, ConstantHelper.ScheduleFileName);
                //await JSONHelper.WriteFile(new Dictionary<string, object>(), scheduleFilePath);

                // 返回工程文件路径
                ProjeceFilePath = filePath;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新建工程失败:" + ex.Message, ConstantHelper.SoftwareName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                NLogLogger.Error("新建工程失败:" + ex);
            }
        }

    }
}
