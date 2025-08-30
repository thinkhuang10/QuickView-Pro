using CommonTools;
using LogTool;
using System;
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
                var newProjectModel = new NewProjectModel
                {
                    ProjectGuid = guid.ToString(),
                    Description = rtbProjectDescription.Text.Trim()  
                };
                await JsonHelper.WriteFile(newProjectModel, filePath);

                var configDirPath = Path.Combine(projectPath, "Config");
                Directory.CreateDirectory(configDirPath);

                var configModel = new InfluxDBConfigModel();
                configModel.Guid = guid.ToString();
                configModel.StoragePath = 
                    Path.Combine($"{Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)}",
                    ConstantHelper.SoftwareName);

                await JsonHelper.WriteFile(configModel, Path.Combine(configDirPath, "InfluxdDBCfg.json"));

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
