using Features.Feature;
using HelperTool;
using LoveWindowsAgain.ITreeNode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveWindowsAgain
{
    public partial class MainForm : Form
    {
        public Control INavPage;
        private int progression = 0;
        private int progressionIncrease = 0;
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        private Utils App = new Utils();

        public MainForm()
           => InitializeComponent();

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.AddFeatures();
            this.AddMoreTools();
            this.SetStyle();
        }

        private void SetStyle()
        {
            btnAppOptions.Text = "\uE70D";
            btnKebapMenu.Text = "\u22ee";
            btnSettings.Text = "\uE713";
            btnAnalyze.Text += "\x20" + OsHelper.thisOS;

            logger.SetTarget(richLog);          // Log messages to target richLog
            INavPage = pnlForm.Controls[0];     // Set default NavPage
        }

        private void SetView(Control View)
        {
            var control = View as Control;

            control.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            control.Dock = DockStyle.Fill;
            INavPage.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            INavPage.Dock = DockStyle.Fill;

            pnlForm.Controls.Clear();
            pnlForm.Controls.Add(View);
        }

        private void AddMoreTools()
        {
            cmbTools.Items.Add("Install packages for " + OsHelper.thisOS);
            cmbTools.Items.Add("Remove unnecessary apps from " + OsHelper.thisOS);
            cmbTools.Items.Add("Send feedback to Microsoft from " + OsHelper.thisOS);
            cmbTools.Items.Insert(0, "Select...");
            cmbTools.SelectedIndex = 0;
        }

        private void RegisterFeedbackTool()
        {
            bool feedbackHub = Directory.Exists(Path.Combine
          (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
          "Packages\\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe"));

            if (!feedbackHub) MessageBox.Show("FeedbackHub is not installed on this system :(\nYou can get it on the Microsoft Store.", "We are sorry...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else Process.Start(@"shell:appsfolder\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe!App");
        }

        /// <summary>
        /// Register some more Tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = Convert.ToString(cmbTools.SelectedItem);
            string[] keys = new string[] { "Install", "Remove", "Send" };

            string sKeyResult = keys.FirstOrDefault<string>(s => message.Contains(s));

            switch (sKeyResult)
            {
                case "Install":
                    this.SetView(new PackagesPageView());            // Packages view
                    break;

                case "Remove":
                    this.SetView(new AppsPageView());                // In-box apps view
                    break;

                case "Send":
                    RegisterFeedbackTool();                          // Send feedback to Microsoft
                    break;

                default:
                    break;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
            => this.SetView(new AboutPageView());                    // Settings view

        public void AddFeatures()
        {
            treeFeatures.Nodes.Clear();
            treeFeatures.BeginUpdate();

            // Root node
            TreeNode root = new TreeNode("Problems to be checked ")
            {
                Checked = true,
            };

            TreeNode browser = new TreeNode("Browser", new TreeNode[] {
                new FeatureNode(new Features.Feature.Browser.ChromeTelemetry()),
                new FeatureNode(new Features.Feature.Browser.FirefoxTelemetry()),
            })
            {
                Checked = true,
            };

            TreeNode explorer = new TreeNode("Explorer", new TreeNode[] {
                new FeatureNode(new Features.Feature.Explorer.FileExplorer()),
                new FeatureNode(new Features.Feature.Explorer.HiddenFileFolder()),
                new FeatureNode(new Features.Feature.Explorer.HiddenFileExt()),
            })
            {
                Checked = true,
            };

            TreeNode desktop = new TreeNode("Desktop", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.Desktop.AppsTheme()),
                new FeatureNode(new Features.Feature.Desktop.WindowsTheme()),
                new FeatureNode(new Features.Feature.Desktop.Transparency()),
                new FeatureNode(new Features.Feature.Desktop.SnapAssistFlyout()),
                new FeatureNode(new Features.Feature.Desktop.Widgets()),
                new FeatureNode(new Features.Feature.Desktop.WidgetsRemove()),
                new FeatureNode(new Features.Feature.Desktop.Stickers()),
            })
            {
                Checked = true,
            };

            TreeNode taskbar = new TreeNode("Taskbar and Start menu", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.Taskbar.TaskbarSearch()),
                new FeatureNode(new Features.Feature.Taskbar.TaskbarChat()),
                new FeatureNode(new Features.Feature.Taskbar.TaskView()),
                new FeatureNode(new Features.Feature.Taskbar.MostUsedApps()),
                new FeatureNode(new Features.Feature.Taskbar.StartmenuLayout()),
            })
            {
                Checked = true,
            };

            TreeNode system = new TreeNode("System", new System.Windows.Forms.TreeNode[] {
                new FeatureNode(new Features.Feature.System.FullContextMenus()),
                new FeatureNode(new Features.Feature.System.RemoveW11Watermark()),
                new FeatureNode(new Features.Feature.System.TeamsAutostart()),
                new FeatureNode(new Features.Feature.System.Fax()),
                new FeatureNode(new Features.Feature.System.XPSWriter()),
                new FeatureNode(new Features.Feature.System.TPMCheck()),
                new FeatureNode(new Features.Feature.System.OneDriveRemove()),
            })
            {
                Checked = true,
            };

            TreeNode gaming = new TreeNode("Gaming", new TreeNode[] {
                new FeatureNode(new Features.Feature.Gaming.GameDVR()),
                new FeatureNode(new Features.Feature.Gaming.PowerThrottling()),
                new FeatureNode(new Features.Feature.Gaming.VisualFX()),
            })
            {
                Checked = true,
            };

            TreeNode privacy = new TreeNode("Privacy", new TreeNode[] {
                new FeatureNode(new Features.Feature.Privacy.DiagnosticData()),
                new FeatureNode(new Features.Feature.Privacy.Telemetry()),
                new FeatureNode(new Features.Feature.Privacy.CompatibilityTelemetry()),
                new FeatureNode(new Features.Feature.Privacy.LocationTracking()),
                new FeatureNode(new Features.Feature.Privacy.Advertising()),
                new FeatureNode(new Features.Feature.Privacy.Feedback()),
                new FeatureNode(new Features.Feature.Privacy.SuggestedContent()),
                new FeatureNode(new Features.Feature.Privacy.Biometrics()),
                new FeatureNode(new Features.Feature.Privacy.AppsAutoInstall()),
                new FeatureNode(new Features.Feature.Privacy.WindowsTips()),
                new FeatureNode(new Features.Feature.Privacy.TailoredExperiences()),
            })
            {
                Checked = true
            };

            TreeNode components = new TreeNode("Feature Recommendation", new TreeNode[] {
                new FeatureNode(new Features.Feature.Recommendation.EnableWSL()),
            })
            {
                Checked = true,
            };

            TreeNode apps = new TreeNode("Apps", new TreeNode[] {
                new FeatureNode(new Features.Feature.Apps.StoreApps()),
            })
            {
                Checked = true,
            };

            root.Nodes.AddRange(new TreeNode[]
            {
                browser,
                explorer,
                desktop,
                taskbar,
                system,
                gaming,
                privacy,
                components,
                apps,
            });

            treeFeatures.Nodes.Add(root);

            // Some tvw nicety
            foreach (TreeNode tn in treeFeatures.Nodes) { tn.Expand(); }
            treeFeatures.Nodes[0].NodeFont = new Font(treeFeatures.Font, FontStyle.Bold);
            treeFeatures.EndUpdate();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            Reset();

            int performFeaturesCount = 0;

            List<FeatureNode> selectedFeatures = CollectFeatureNodes();

            foreach (FeatureNode node in selectedFeatures)
            {
                var feature = node.Feature;
                ListViewItem detail = new ListViewItem(feature.ID());
                ConfiguredTaskAwaitable<bool> analyzeTask = Task<bool>.Factory.StartNew(() => feature.CheckFeature()).ConfigureAwait(true);
                // logger.Log("Check {0}", node.Text);

                bool shouldPerform = await analyzeTask;
                lnkSubHeader.Text = "Check " + feature.ID();

                if (menuIgnoreLowLevelP.Checked == true)
                    if (shouldPerform & !node.Text.Contains("LOW"))
                    {
                        logger.Log("Problem on " + node.Parent.Text + ": " + feature.ID());
                        //logger.Log("- {0}", node.Text);

                        performFeaturesCount += 1;
                        node.ForeColor = Color.MediumVioletRed;
                    }
                    else
                    {
                        node.Checked = false; // Uncheck all fixed
                        node.ForeColor = Color.Gray;
                        //logger.Log("Problem fixed: {0}", node.Text);
                    }
                else if (shouldPerform)
                {
                    logger.Log("Problem on " + node.Parent.Text + ": " + feature.ID());
                    performFeaturesCount += 1;
                    node.ForeColor = Color.MediumVioletRed;
                }
                else
                {
                    node.Checked = false;
                    node.ForeColor = Color.Gray;
                }
            }

            treeFeatures.ExpandAll();
            treeFeatures.SelectedNode = treeFeatures.Nodes[0];
            DoProgress(100);

            /* Add summary
            StringBuilder sum = new StringBuilder();
            sum.Append(Environment.NewLine);
            sum.Append("======= Summary =======\n");
            sum.Append($"{selectedFeatures.Count} problems has been checked.\r\n");
            sum.Append($"{selectedFeatures.Count - performFeaturesCount} problems already fixed (we've unchecked it).\r\n");

            logger.Log(sum.ToString(), "");
            */
            // Last but not least Check for app updates
            this.App.CheckForUpdates();

            lnkSubHeader.Text = $"{performFeaturesCount} problems should be fixed (just a recommendation).\r\n";
        }

        private void SelectFeatureNodes(TreeNodeCollection trNodeCollection, bool isCheck)
        {
            foreach (TreeNode trNode in trNodeCollection)
            {
                trNode.Checked = isCheck;
                if (trNode.Nodes.Count > 0)
                    SelectFeatureNodes(trNode.Nodes, isCheck);
            }
        }

        private List<FeatureNode> CollectFeatureNodes()
        {
            List<FeatureNode> selectedFeatures = new List<FeatureNode>();

            foreach (TreeNode treeNode in treeFeatures.Nodes.All())
            {
                if (treeNode.Checked && treeNode.GetType() == typeof(FeatureNode))
                {
                    selectedFeatures.Add((FeatureNode)treeNode);
                }
            }

            progressionIncrease = (int)Math.Floor(100.0f / selectedFeatures.Count);

            return selectedFeatures;
        }

        private void Reset()
        {
            progression = 0;
            progressionIncrease = 0;

            progress.Value = 0;
            progress.Visible = true;
            richLog.Visible = true;
            richLog.Text = "";
        }

        private void DoProgress(int value)
        {
            progression = value;
            progress.Value = progression;
        }

        private void IncrementProgress()
        {
            progression += progressionIncrease;
            progress.Value = progression;
        }

        private async void ApplyFeatures(List<FeatureNode> treeNodes)
        {
            treeFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.DoFeature()).ConfigureAwait(true);

                lnkSubHeader.Text = "Fixing " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            treeFeatures.Enabled = true;
        }

        private async void UndoFeatures(List<FeatureNode> treeNodes)
        {
            treeFeatures.Enabled = false;

            foreach (FeatureNode node in treeNodes)
            {
                var assessment = node.Feature;
                ConfiguredTaskAwaitable<bool> performTask = Task<bool>.Factory.StartNew(() => assessment.UndoFeature()).ConfigureAwait(true);

                lnkSubHeader.Text = "Restore " + node.Text;

                var result = await performTask;
                IncrementProgress();
            }

            DoProgress(100);
            lnkSubHeader.Text = "";

            treeFeatures.Enabled = true;
        }

        private void menuFix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richLog.Text))
            {
                MessageBox.Show("No analyze has taken place yet");
                return;
            }

            Reset();

            List<FeatureNode> performNodes = CollectFeatureNodes();
            ApplyFeatures(performNodes);
        }

        private void menuRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to restore selected features to Windows default state?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Reset();

                List<FeatureNode> performNodes = CollectFeatureNodes();
                UndoFeatures(performNodes);
            }
        }

        private void treeFeatures_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeFeatures.BeginUpdate();

            foreach (TreeNode child in e.Node.Nodes)
            {
                child.Checked = e.Node.Checked;
            }

            treeFeatures.EndUpdate();
        }

        private void menuAdvanced_Click(object sender, EventArgs e)
        {
            menuAdvanced.Checked = !(menuAdvanced.Checked);

            if (menuAdvanced.Checked == true)
            {
                treeFeatures.Visible = true;
                treeFeatures.BringToFront();
            }
            else if (menuAdvanced.Checked == false)
                treeFeatures.Visible = false;
            richLog.Visible = true;
        }

        private void menuIgnoreLowLevelP_Click(object sender, EventArgs e)
        {
            menuIgnoreLowLevelP.Checked = !(menuIgnoreLowLevelP.Checked);
            SelectFeatureNodes(treeFeatures.Nodes, true);
        }

        private void richLog_LinkClicked(object sender, LinkClickedEventArgs e)
            => Utils.LaunchUri(e.LinkText);

        private void btnAppOptions_Click(object sender, EventArgs e)
             => this.contextAppMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void btnMenu_Click(object sender, EventArgs e)
            => this.contextKebapMenu.Show(Cursor.Position.X, Cursor.Position.Y);

        private void lnkSubHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => menuAdvanced.PerformClick();
    }
}