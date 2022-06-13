namespace LoveWindowsAgain
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAppOptions = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKebapMenu = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblTools = new System.Windows.Forms.Label();
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.treeFeatures = new System.Windows.Forms.TreeView();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.contextKebapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIgnoreLowLevelP = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFix = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixInfo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestoreInfo = new System.Windows.Forms.ToolStripTextBox();
            this.pnlForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.contextKebapMenu.SuspendLayout();
            this.contextAppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1019, 801);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.btnAppOptions);
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnKebapMenu);
            this.pnlMain.Controls.Add(this.btnAnalyze);
            this.pnlMain.Controls.Add(this.lnkSubHeader);
            this.pnlMain.Controls.Add(this.progress);
            this.pnlMain.Controls.Add(this.lblTools);
            this.pnlMain.Controls.Add(this.cmbTools);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.treeFeatures);
            this.pnlMain.Controls.Add(this.richLog);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1019, 801);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAppOptions
            // 
            this.btnAppOptions.AutoEllipsis = true;
            this.btnAppOptions.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAppOptions.FlatAppearance.BorderSize = 0;
            this.btnAppOptions.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppOptions.ForeColor = System.Drawing.Color.White;
            this.btnAppOptions.Location = new System.Drawing.Point(350, 213);
            this.btnAppOptions.Name = "btnAppOptions";
            this.btnAppOptions.Size = new System.Drawing.Size(54, 42);
            this.btnAppOptions.TabIndex = 178;
            this.btnAppOptions.Text = "...";
            this.btnAppOptions.UseVisualStyleBackColor = false;
            this.btnAppOptions.Click += new System.EventHandler(this.btnAppOptions_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSettings.Location = new System.Drawing.Point(965, 751);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(42, 38);
            this.btnSettings.TabIndex = 177;
            this.btnSettings.Text = "...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 43);
            this.label1.TabIndex = 176;
            this.label1.Text = "Hello friend!";
            // 
            // btnKebapMenu
            // 
            this.btnKebapMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKebapMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKebapMenu.FlatAppearance.BorderSize = 0;
            this.btnKebapMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKebapMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKebapMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKebapMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKebapMenu.Location = new System.Drawing.Point(977, 0);
            this.btnKebapMenu.Name = "btnKebapMenu";
            this.btnKebapMenu.Size = new System.Drawing.Size(42, 38);
            this.btnKebapMenu.TabIndex = 175;
            this.btnKebapMenu.Text = "...";
            this.btnKebapMenu.UseVisualStyleBackColor = true;
            this.btnKebapMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.AutoEllipsis = true;
            this.btnAnalyze.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAnalyze.FlatAppearance.BorderSize = 0;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(71, 213);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(286, 42);
            this.btnAnalyze.TabIndex = 27;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkSubHeader.Location = new System.Drawing.Point(71, 679);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(795, 18);
            this.lnkSubHeader.TabIndex = 171;
            this.lnkSubHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubHeader_LinkClicked);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(72, 285);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(856, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // lblTools
            // 
            this.lblTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTools.AutoSize = true;
            this.lblTools.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTools.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTools.Location = new System.Drawing.Point(32, 749);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(38, 30);
            this.lblTools.TabIndex = 25;
            this.lblTools.Text = "More\r\nTools!";
            // 
            // cmbTools
            // 
            this.cmbTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTools.DropDownHeight = 200;
            this.cmbTools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTools.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTools.FormattingEnabled = true;
            this.cmbTools.IntegralHeight = false;
            this.cmbTools.ItemHeight = 21;
            this.cmbTools.Location = new System.Drawing.Point(75, 750);
            this.cmbTools.Name = "cmbTools";
            this.cmbTools.Size = new System.Drawing.Size(418, 29);
            this.cmbTools.TabIndex = 19;
            this.cmbTools.SelectedIndexChanged += new System.EventHandler(this.cmbTools_SelectedIndexChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(69, 112);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(843, 59);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Windows 11 has too many useless and annoying features that just need to go.\r\nThis" +
    " app will scan your system and optimize your settings to make sure your PC is ru" +
    "nning the best it can.";
            // 
            // treeFeatures
            // 
            this.treeFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFeatures.BackColor = System.Drawing.Color.White;
            this.treeFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFeatures.CheckBoxes = true;
            this.treeFeatures.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeFeatures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeFeatures.FullRowSelect = true;
            this.treeFeatures.ItemHeight = 30;
            this.treeFeatures.LineColor = System.Drawing.Color.HotPink;
            this.treeFeatures.Location = new System.Drawing.Point(72, 305);
            this.treeFeatures.Name = "treeFeatures";
            this.treeFeatures.ShowLines = false;
            this.treeFeatures.ShowNodeToolTips = true;
            this.treeFeatures.ShowRootLines = false;
            this.treeFeatures.Size = new System.Drawing.Size(858, 360);
            this.treeFeatures.TabIndex = 168;
            this.treeFeatures.Visible = false;
            this.treeFeatures.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeFeatures_AfterCheck);
            // 
            // richLog
            // 
            this.richLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richLog.BackColor = System.Drawing.Color.White;
            this.richLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richLog.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richLog.HideSelection = false;
            this.richLog.Location = new System.Drawing.Point(72, 305);
            this.richLog.Name = "richLog";
            this.richLog.ReadOnly = true;
            this.richLog.Size = new System.Drawing.Size(861, 360);
            this.richLog.TabIndex = 138;
            this.richLog.Text = "";
            this.richLog.Visible = false;
            this.richLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richLog_LinkClicked);
            // 
            // contextKebapMenu
            // 
            this.contextKebapMenu.BackColor = System.Drawing.SystemColors.Control;
            this.contextKebapMenu.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextKebapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdvanced,
            this.menuIgnoreLowLevelP});
            this.contextKebapMenu.Name = "menuMain";
            this.contextKebapMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextKebapMenu.Size = new System.Drawing.Size(265, 56);
            // 
            // menuAdvanced
            // 
            this.menuAdvanced.Name = "menuAdvanced";
            this.menuAdvanced.Size = new System.Drawing.Size(264, 26);
            this.menuAdvanced.Text = "Advanced mode";
            this.menuAdvanced.Click += new System.EventHandler(this.menuAdvanced_Click);
            // 
            // menuIgnoreLowLevelP
            // 
            this.menuIgnoreLowLevelP.Name = "menuIgnoreLowLevelP";
            this.menuIgnoreLowLevelP.Size = new System.Drawing.Size(264, 26);
            this.menuIgnoreLowLevelP.Text = "Ignore Low level problems";
            this.menuIgnoreLowLevelP.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuIgnoreLowLevelP.Click += new System.EventHandler(this.menuIgnoreLowLevelP_Click);
            // 
            // contextAppMenu
            // 
            this.contextAppMenu.BackColor = System.Drawing.SystemColors.Control;
            this.contextAppMenu.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFix,
            this.menuFixInfo,
            this.toolStripSeparator1,
            this.menuRestore,
            this.menuRestoreInfo});
            this.contextAppMenu.Name = "menuMain";
            this.contextAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextAppMenu.Size = new System.Drawing.Size(361, 132);
            // 
            // menuFix
            // 
            this.menuFix.Name = "menuFix";
            this.menuFix.Size = new System.Drawing.Size(360, 30);
            this.menuFix.Text = "Fix problems";
            this.menuFix.Click += new System.EventHandler(this.menuFix_Click);
            // 
            // menuFixInfo
            // 
            this.menuFixInfo.BackColor = System.Drawing.SystemColors.Control;
            this.menuFixInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuFixInfo.Enabled = false;
            this.menuFixInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuFixInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuFixInfo.Name = "menuFixInfo";
            this.menuFixInfo.Size = new System.Drawing.Size(300, 16);
            this.menuFixInfo.Text = "This will fix all found and selected problems";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(357, 10);
            // 
            // menuRestore
            // 
            this.menuRestore.Name = "menuRestore";
            this.menuRestore.Size = new System.Drawing.Size(360, 30);
            this.menuRestore.Text = "Restore settings";
            this.menuRestore.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuRestore.Click += new System.EventHandler(this.menuRestore_Click);
            // 
            // menuRestoreInfo
            // 
            this.menuRestoreInfo.BackColor = System.Drawing.SystemColors.Control;
            this.menuRestoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuRestoreInfo.Enabled = false;
            this.menuRestoreInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuRestoreInfo.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.menuRestoreInfo.Name = "menuRestoreInfo";
            this.menuRestoreInfo.Size = new System.Drawing.Size(300, 16);
            this.menuRestoreInfo.Text = "This will restore the default settings ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 801);
            this.Controls.Add(this.pnlForm);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoveWindowsAgain";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlForm.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.contextKebapMenu.ResumeLayout(false);
            this.contextAppMenu.ResumeLayout(false);
            this.contextAppMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.ComboBox cmbTools;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.TreeView treeFeatures;
        private System.Windows.Forms.Button btnKebapMenu;
        private System.Windows.Forms.ContextMenuStrip contextKebapMenu;
        private System.Windows.Forms.ToolStripMenuItem menuAdvanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuIgnoreLowLevelP;
        private System.Windows.Forms.Button btnAppOptions;
        private System.Windows.Forms.ContextMenuStrip contextAppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuFix;
        private System.Windows.Forms.ToolStripTextBox menuFixInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuRestore;
        private System.Windows.Forms.ToolStripTextBox menuRestoreInfo;
    }
}

