using LogTool;
using System;
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
            NLogLogger.Fatal("123");
        }

        #region 工具栏

        private void ToolStripMenuItem新建工程_Click(object sender, EventArgs e)
        {
            var form = new NewProject();
            form.ShowDialog();
        }

        private void ToolStripMenuItem打开工程_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                //Filter = $"工程文件|*{ConstantHelper.ProjectSuffixName}",
                //InitialDirectory = PathHelper.GetDefaultProjectPath()
            };
            if (DialogResult.OK != dialog.ShowDialog())
                return;
        }

        private void ToolStripMenuItem退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}