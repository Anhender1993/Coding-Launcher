using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LauncherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Docker & VS Code Launcher";
            this.Width = 300;
            this.Height = 200;

            Button launchButton = new Button
            {
                Text = "Launch Docker & VS Code",
                Width = 200,
                Height = 50,
                Top = 50,
                Left = 50
            };

            launchButton.Click += LaunchButton_Click;
            this.Controls.Add(launchButton);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Start Docker Desktop
                string dockerPath = @"C:\Program Files\Docker\Docker\Docker Desktop.exe";
                if (File.Exists(dockerPath))
                {
                    Process.Start(dockerPath);
                    Thread.Sleep(5000); // Wait a few seconds for Docker to initialize
                }
                else
                {
                    MessageBox.Show("Docker Desktop not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Start Visual Studio Code
                Process.Start("code"); // Assumes VS Code is installed and added to PATH
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching applications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
