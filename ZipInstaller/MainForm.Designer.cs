namespace ZipInstaller
{
    partial class MainForm
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
            this.runButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(10, 10);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(200, 40);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // installButton
            // 
            this.installButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installButton.Location = new System.Drawing.Point(10, 60);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(200, 40);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(10, 110);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(200, 40);
            this.uninstallButton.TabIndex = 2;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 161);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.runButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
    }
}

