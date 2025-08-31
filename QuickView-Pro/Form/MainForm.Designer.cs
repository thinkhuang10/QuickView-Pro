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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开工程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动通讯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止通讯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间同步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.通讯设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.通讯ToolStripMenuItem,
            this.数据库ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(998, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建工程ToolStripMenuItem,
            this.打开工程ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建工程ToolStripMenuItem
            // 
            this.新建工程ToolStripMenuItem.Name = "新建工程ToolStripMenuItem";
            this.新建工程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建工程ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.新建工程ToolStripMenuItem.Text = "新建工程(&N)";
            this.新建工程ToolStripMenuItem.Click += new System.EventHandler(this.新建工程ToolStripMenuItem_Click);
            // 
            // 打开工程ToolStripMenuItem
            // 
            this.打开工程ToolStripMenuItem.Name = "打开工程ToolStripMenuItem";
            this.打开工程ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开工程ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.打开工程ToolStripMenuItem.Text = "打开工程(&O)";
            this.打开工程ToolStripMenuItem.Click += new System.EventHandler(this.打开工程ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.退出ToolStripMenuItem.Text = "退出(&E)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 通讯ToolStripMenuItem
            // 
            this.通讯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动通讯ToolStripMenuItem,
            this.停止通讯ToolStripMenuItem,
            this.时间同步ToolStripMenuItem,
            this.toolStripSeparator2,
            this.通讯设置ToolStripMenuItem});
            this.通讯ToolStripMenuItem.Name = "通讯ToolStripMenuItem";
            this.通讯ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.通讯ToolStripMenuItem.Text = "通讯(&C)";
            // 
            // 启动通讯ToolStripMenuItem
            // 
            this.启动通讯ToolStripMenuItem.Name = "启动通讯ToolStripMenuItem";
            this.启动通讯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.启动通讯ToolStripMenuItem.Text = "启动通讯";
            this.启动通讯ToolStripMenuItem.Click += new System.EventHandler(this.启动通讯ToolStripMenuItem_Click);
            // 
            // 停止通讯ToolStripMenuItem
            // 
            this.停止通讯ToolStripMenuItem.Name = "停止通讯ToolStripMenuItem";
            this.停止通讯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.停止通讯ToolStripMenuItem.Text = "停止通讯";
            // 
            // 时间同步ToolStripMenuItem
            // 
            this.时间同步ToolStripMenuItem.Name = "时间同步ToolStripMenuItem";
            this.时间同步ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.时间同步ToolStripMenuItem.Text = "时间同步";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 通讯设置ToolStripMenuItem
            // 
            this.通讯设置ToolStripMenuItem.Name = "通讯设置ToolStripMenuItem";
            this.通讯设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.通讯设置ToolStripMenuItem.Text = "通讯设置";
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动记录ToolStripMenuItem,
            this.停止记录ToolStripMenuItem});
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 启动记录ToolStripMenuItem
            // 
            this.启动记录ToolStripMenuItem.Name = "启动记录ToolStripMenuItem";
            this.启动记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.启动记录ToolStripMenuItem.Text = "启动记录";
            this.启动记录ToolStripMenuItem.Click += new System.EventHandler(this.启动记录ToolStripMenuItem_ClickAsync);
            // 
            // 停止记录ToolStripMenuItem
            // 
            this.停止记录ToolStripMenuItem.Name = "停止记录ToolStripMenuItem";
            this.停止记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.停止记录ToolStripMenuItem.Text = "停止记录";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 577);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开工程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动通讯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止通讯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间同步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 通讯设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止记录ToolStripMenuItem;
    }
}

