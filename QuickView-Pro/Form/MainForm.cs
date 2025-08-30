using CommonTools;
using LogTool;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        private void ToolStripMenuItem新建工程_Click(object sender, EventArgs e)
        {
            var form = new NewProject();
            var dialog = form.ShowDialog();

            if (DialogResult.OK != dialog)
                return;

            OpenProject();
        }

        private void ToolStripMenuItem打开工程_Click(object sender, EventArgs e)
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

        private void ToolStripMenuItem退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        #endregion

    }
}