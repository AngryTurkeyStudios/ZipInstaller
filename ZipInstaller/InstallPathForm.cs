using System;
using System.Windows.Forms;

namespace ZipInstaller
{
    public partial class InstallPathForm : Form
    {
        MainForm mainForm;

        public InstallPathForm(MainForm mainForm, string initialPath)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.mainForm = mainForm;
            installPathText.Text = initialPath;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                installPathText.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void InstallPathForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Install(installPathText.Text);
            this.Close();
        }
    }
}
