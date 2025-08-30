namespace QuickView_Pro
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem文件 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem新建工程 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem打开工程 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem文件});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(998, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // ToolStripMenuItem文件
            // 
            this.ToolStripMenuItem文件.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem新建工程,
            this.ToolStripMenuItem打开工程,
            this.toolStripSeparator1,
            this.ToolStripMenuItem退出});
            this.ToolStripMenuItem文件.Name = "ToolStripMenuItem文件";
            this.ToolStripMenuItem文件.Size = new System.Drawing.Size(58, 21);
            this.ToolStripMenuItem文件.Text = "文件(&F)";
            // 
            // ToolStripMenuItem新建工程
            // 
            this.ToolStripMenuItem新建工程.Name = "ToolStripMenuItem新建工程";
            this.ToolStripMenuItem新建工程.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItem新建工程.Size = new System.Drawing.Size(189, 22);
            this.ToolStripMenuItem新建工程.Text = "新建工程(&N)";
            this.ToolStripMenuItem新建工程.Click += new System.EventHandler(this.ToolStripMenuItem新建工程_Click);
            // 
            // ToolStripMenuItem打开工程
            // 
            this.ToolStripMenuItem打开工程.Name = "ToolStripMenuItem打开工程";
            this.ToolStripMenuItem打开工程.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem打开工程.Size = new System.Drawing.Size(189, 22);
            this.ToolStripMenuItem打开工程.Text = "打开工程(&O)";
            this.ToolStripMenuItem打开工程.Click += new System.EventHandler(this.ToolStripMenuItem打开工程_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem退出
            // 
            this.ToolStripMenuItem退出.Name = "ToolStripMenuItem退出";
            this.ToolStripMenuItem退出.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ToolStripMenuItem退出.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem退出.Text = "退出(&E)";
            this.ToolStripMenuItem退出.Click += new System.EventHandler(this.ToolStripMenuItem退出_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickView-Pro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem文件;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem新建工程;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem打开工程;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem退出;
    }
}

