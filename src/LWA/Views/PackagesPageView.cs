using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveWindowsAgain
{
    public partial class PackagesPageView : UserControl
    {
        private List<string> Packages = new List<string>();

        public PackagesPageView()
        {
            InitializeComponent();

            RequestPackagesRemote();
            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            btnBack.Text = "\uE72B";
        }

        public void RequestPackagesRemote()
        {
            try
            {
                List<string> remoteApps = new List<string>();
                var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/builtbybel/LoveWindowsAgain/main/assets/packages.git");
                string app;

                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var sr = new StreamReader(content))
                {
                    while ((app = sr.ReadLine()) != null)
                    {
                        {
                            if (!app.StartsWith("#") && (!string.IsNullOrEmpty(app)))
                            {
                                remoteApps.Add(app);
                                listOnline.Items.Add(app);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listOnline.Items)
            {
                listInstall.Items.Add(item);
            }
            listOnline.Items.Clear();
            RefreshPackages();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listOnline.Items.Count != 0)
            {
                if (listOnline.SelectedItem == null) listOnline.SelectedIndex = 0;
                while (listOnline.SelectedItem != null)
                {
                    listInstall.Items.Add(listOnline.SelectedItem);
                    listOnline.Items.Remove(listOnline.SelectedItem);
                }
                RefreshPackages();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listInstall.Items.Count != 0)
            {
                if (listInstall.SelectedItem == null) listInstall.SelectedIndex = 0;
                while (listInstall.SelectedItem != null)
                {
                    listOnline.Items.Add(listInstall.SelectedItem);
                    listInstall.Items.Remove(listInstall.SelectedItem);
                }
                RefreshPackages();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listInstall.Items)
            {
                listOnline.Items.Add(item);
            }
            listInstall.Items.Clear();
            RefreshPackages();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listOnline.Items.Clear();
            RequestPackagesRemote();
        }

        public void WingetInstallPackage(string packageid)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = HelperTool.Utils.Paths.ShellPS,
                    Arguments = "winget install --id " + packageid + " --accept-source-agreements --accept-package-agreements",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            proc.Start();
            proc.WaitForExit();
        }

        private void RefreshPackages()
        {
            if (listInstall.Items.Count == 0)
            {
                richTextStatus.Visible = true;
                listInstall.Visible = false;
            }
            else
            {
                listInstall.Visible = true;
                richTextStatus.Visible = false;
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            richTextStatus.Visible = true;
            listInstall.Visible = false;
            btnInstall.Enabled = false;

            StringBuilder message = new StringBuilder();

            foreach (string p in listInstall.Items)
            {
                Packages.Add(p);
            }

            foreach (string p in Packages)
            {
                richTextStatus.Text += Environment.NewLine + "Installing -" + p;
                await Task.Run(() => WingetInstallPackage(p));
            }

            groupBox1.Text = "The following apps have been installed";
            listInstall.Visible = true;
            btnInstall.Enabled = true;
            richTextStatus.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }
    }
}