namespace ZipInstaller
{
    partial class InstallPathForm
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
            this.installPathText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // installPathText
            // 
            this.installPathText.Location = new System.Drawing.Point(10, 10);
            this.installPathText.Name = "installPathText";
            this.installPathText.Size = new System.Drawing.Size(300, 20);
            this.installPathText.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(318, 9);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(89, 22);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(415, 9);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(89, 22);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Install";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // InstallPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 41);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.installPathText);
            this.Name = "InstallPathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Path";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstallPathForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox installPathText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button okButton;
    }
}