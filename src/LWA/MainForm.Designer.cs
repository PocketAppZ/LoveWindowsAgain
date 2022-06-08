﻿namespace LoveWindowsAgain
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnFix = new System.Windows.Forms.Button();
            this.lblTools = new System.Windows.Forms.Label();
            this.cmbTools = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.treeFeatures = new System.Windows.Forms.TreeView();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIgnoreLowLevelP = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.contextMenuApp.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnMenu);
            this.pnlMain.Controls.Add(this.btnAnalyze);
            this.pnlMain.Controls.Add(this.lnkSubHeader);
            this.pnlMain.Controls.Add(this.btnRestore);
            this.pnlMain.Controls.Add(this.progress);
            this.pnlMain.Controls.Add(this.btnFix);
            this.pnlMain.Controls.Add(this.lblTools);
            this.pnlMain.Controls.Add(this.cmbTools);
            this.pnlMain.Controls.Add(this.lblHeader);
            this.pnlMain.Controls.Add(this.richLog);
            this.pnlMain.Controls.Add(this.treeFeatures);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1019, 801);
            this.pnlMain.TabIndex = 0;
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
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe Fluent Icons", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.Location = new System.Drawing.Point(977, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 38);
            this.btnMenu.TabIndex = 175;
            this.btnMenu.Text = "...";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(794, 214);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(118, 42);
            this.btnRestore.TabIndex = 173;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(72, 289);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(837, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // btnFix
            // 
            this.btnFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFix.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.White;
            this.btnFix.Location = new System.Drawing.Point(670, 214);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(118, 42);
            this.btnFix.TabIndex = 174;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Visible = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
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
            this.treeFeatures.Size = new System.Drawing.Size(837, 360);
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
            this.richLog.Size = new System.Drawing.Size(837, 360);
            this.richLog.TabIndex = 138;
            this.richLog.Text = "";
            this.richLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richLog_LinkClicked_1);
            // 
            // contextMenuApp
            // 
            this.contextMenuApp.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuApp.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdvanced,
            this.menuIgnoreLowLevelP});
            this.contextMenuApp.Name = "menuMain";
            this.contextMenuApp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuApp.Size = new System.Drawing.Size(265, 56);
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
            this.contextMenuApp.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.TreeView treeFeatures;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuApp;
        private System.Windows.Forms.ToolStripMenuItem menuAdvanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem menuIgnoreLowLevelP;
    }
}

