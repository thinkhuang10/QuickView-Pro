namespace QuickView_Pro
{
    partial class NewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_ProjectName = new System.Windows.Forms.Label();
            this.Label_ProjectLocation = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbProjectLocation = new System.Windows.Forms.TextBox();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.Label_ProjectDescription = new System.Windows.Forms.Label();
            this.btOpenFileDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Label_ProjectName
            // 
            this.Label_ProjectName.AutoSize = true;
            this.Label_ProjectName.Location = new System.Drawing.Point(15, 23);
            this.Label_ProjectName.Name = "Label_ProjectName";
            this.Label_ProjectName.Size = new System.Drawing.Size(41, 12);
            this.Label_ProjectName.TabIndex = 0;
            this.Label_ProjectName.Text = "名称：";
            // 
            // Label_ProjectLocation
            // 
            this.Label_ProjectLocation.AutoSize = true;
            this.Label_ProjectLocation.Location = new System.Drawing.Point(15, 59);
            this.Label_ProjectLocation.Name = "Label_ProjectLocation";
            this.Label_ProjectLocation.Size = new System.Drawing.Size(41, 12);
            this.Label_ProjectLocation.TabIndex = 1;
            this.Label_ProjectLocation.Text = "路径：";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(62, 20);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(433, 21);
            this.tbProjectName.TabIndex = 2;
            this.tbProjectName.Text = "新建工程";
            // 
            // tbProjectLocation
            // 
            this.tbProjectLocation.Location = new System.Drawing.Point(62, 56);
            this.tbProjectLocation.Name = "tbProjectLocation";
            this.tbProjectLocation.Size = new System.Drawing.Size(352, 21);
            this.tbProjectLocation.TabIndex = 3;
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.Location = new System.Drawing.Point(62, 92);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(433, 69);
            this.rtbProjectDescription.TabIndex = 4;
            this.rtbProjectDescription.Text = "";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(339, 178);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "确定";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(420, 178);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Label_ProjectDescription
            // 
            this.Label_ProjectDescription.AutoSize = true;
            this.Label_ProjectDescription.Location = new System.Drawing.Point(15, 95);
            this.Label_ProjectDescription.Name = "Label_ProjectDescription";
            this.Label_ProjectDescription.Size = new System.Drawing.Size(41, 12);
            this.Label_ProjectDescription.TabIndex = 7;
            this.Label_ProjectDescription.Text = "描述：";
            // 
            // btOpenFileDialog
            // 
            this.btOpenFileDialog.Location = new System.Drawing.Point(420, 56);
            this.btOpenFileDialog.Name = "btOpenFileDialog";
            this.btOpenFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btOpenFileDialog.TabIndex = 8;
            this.btOpenFileDialog.Text = "浏览";
            this.btOpenFileDialog.UseVisualStyleBackColor = true;
            this.btOpenFileDialog.Click += new System.EventHandler(this.btOpenFileDialog_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 215);
            this.Controls.Add(this.btOpenFileDialog);
            this.Controls.Add(this.Label_ProjectDescription);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.rtbProjectDescription);
            this.Controls.Add(this.tbProjectLocation);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.Label_ProjectLocation);
            this.Controls.Add(this.Label_ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新建工程";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ProjectName;
        private System.Windows.Forms.Label Label_ProjectLocation;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectLocation;
        private System.Windows.Forms.RichTextBox rtbProjectDescription;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label Label_ProjectDescription;
        private System.Windows.Forms.Button btOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}