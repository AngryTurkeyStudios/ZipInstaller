using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;

namespace ZipInstaller
{
    public partial class MainForm : Form
    {
        string installPath = "";
        string zipName = "Content.zip";
        string fileName = "ClickMe.html";
        string programName = "RMRS Vol.1";

        public MainForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = programName;

            if (Properties.Settings.Default.InstallPath != "")
            {
                installPath = Properties.Settings.Default.InstallPath;
            }
            else
            {
                installPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                Properties.Settings.Default.InstallPath = installPath;
                Properties.Settings.Default.Save();
            }

            CheckInstallation();
        }

        void CheckInstallation()
        {
            if (File.Exists(installPath + "\\" + programName + "\\" + fileName))
            {
                installButton.Visible = false;
            }
            else
            {
                runButton.Visible = false;
                uninstallButton.Visible = false;
            }
        }

        public void Install(string installPath)
        {
            this.installPath = installPath;
            Properties.Settings.Default.InstallPath = installPath;
            Properties.Settings.Default.Save();

            if (File.Exists(Environment.CurrentDirectory + "\\" + zipName))
            {
                var installDestination = Path.Combine(installPath, programName);
                string fileSource = System.Reflection.Assembly.GetEntryAssembly().Location;

                File.Copy(fileSource, installDestination, true);

                ZipFile.ExtractToDirectory(Path.Combine(Environment.CurrentDirectory, zipName), Path.Combine(installPath, programName));

                runButton.Visible = true;
                installButton.Visible = false;
                uninstallButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Content zip not found. Please assure the content zip is located in the same directory as this installer.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //File.Delete(Environment.CurrentDirectory + "\\" + zipName);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var filePath = installPath + "\\" + programName + "\\" + fileName;
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Main file missing. Please reopen this application and try again.", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var installPathForm = new InstallPathForm(this, installPath);
            installPathForm.Show();
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Uninstall?", "Uninstall", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Directory.Delete(installPath + "\\" + programName, true);
                runButton.Visible = false;
                installButton.Visible = true;
                uninstallButton.Visible = false;
            }
        }
    }
}
