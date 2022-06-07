namespace LoveWindowsAgain
{
    partial class AppsPageView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listRemove = new System.Windows.Forms.ListBox();
            this.richTextStatus = new System.Windows.Forms.RichTextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnRestoreAll = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listApps = new System.Windows.Forms.ListBox();
            this.checkAppsSystem = new System.Windows.Forms.CheckBox();
            this.groupBin = new System.Windows.Forms.GroupBox();
            this.groupInstalled = new System.Windows.Forms.GroupBox();
            this.groupBin.SuspendLayout();
            this.groupInstalled.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRemove
            // 
            this.listRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemove.BackColor = System.Drawing.Color.White;
            this.listRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRemove.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemove.FormattingEnabled = true;
            this.listRemove.ItemHeight = 17;
            this.listRemove.Location = new System.Drawing.Point(11, 36);
            this.listRemove.Name = "listRemove";
            this.listRemove.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemove.Size = new System.Drawing.Size(394, 578);
            this.listRemove.Sorted = true;
            this.listRemove.TabIndex = 13;
            // 
            // richTextStatus
            // 
            this.richTextStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextStatus.BackColor = System.Drawing.Color.White;
            this.richTextStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextStatus.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextStatus.ForeColor = System.Drawing.Color.Black;
            this.richTextStatus.HideSelection = false;
            this.richTextStatus.Location = new System.Drawing.Point(11, 19);
            this.richTextStatus.Name = "richTextStatus";
            this.richTextStatus.ReadOnly = true;
            this.richTextStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextStatus.Size = new System.Drawing.Size(393, 617);
            this.richTextStatus.TabIndex = 139;
            this.richTextStatus.Text = "";
            this.richTextStatus.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(481, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(481, 385);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(89, 23);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnRestoreAll
            // 
            this.btnRestoreAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestoreAll.Location = new System.Drawing.Point(481, 249);
            this.btnRestoreAll.Name = "btnRestoreAll";
            this.btnRestoreAll.Size = new System.Drawing.Size(89, 23);
            this.btnRestoreAll.TabIndex = 34;
            this.btnRestoreAll.Text = "<< Restore all";
            this.btnRestoreAll.UseVisualStyleBackColor = true;
            this.btnRestoreAll.Click += new System.EventHandler(this.btnRestoreAll_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Location = new System.Drawing.Point(481, 278);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(89, 23);
            this.btnRestore.TabIndex = 32;
            this.btnRestore.Text = "< Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnMoveAll.Location = new System.Drawing.Point(481, 137);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(89, 23);
            this.btnMoveAll.TabIndex = 35;
            this.btnMoveAll.Text = "Move all >>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.Color.Black;
            this.btnMove.Location = new System.Drawing.Point(481, 166);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(89, 23);
            this.btnMove.TabIndex = 31;
            this.btnMove.Text = "Move >";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.Black;
            this.btnUninstall.Location = new System.Drawing.Point(481, 478);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(89, 23);
            this.btnUninstall.TabIndex = 41;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Fluent Icons", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 38);
            this.btnBack.TabIndex = 176;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(60, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 32);
            this.label1.TabIndex = 177;
            this.label1.Text = "Remove unnecessary apps";
            // 
            // listApps
            // 
            this.listApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listApps.BackColor = System.Drawing.Color.White;
            this.listApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listApps.FormattingEnabled = true;
            this.listApps.ItemHeight = 17;
            this.listApps.Location = new System.Drawing.Point(11, 36);
            this.listApps.Name = "listApps";
            this.listApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listApps.Size = new System.Drawing.Size(394, 544);
            this.listApps.Sorted = true;
            this.listApps.TabIndex = 13;
            // 
            // checkAppsSystem
            // 
            this.checkAppsSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAppsSystem.AutoSize = true;
            this.checkAppsSystem.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAppsSystem.ForeColor = System.Drawing.Color.DeepPink;
            this.checkAppsSystem.Location = new System.Drawing.Point(11, 617);
            this.checkAppsSystem.Name = "checkAppsSystem";
            this.checkAppsSystem.Size = new System.Drawing.Size(120, 19);
            this.checkAppsSystem.TabIndex = 16;
            this.checkAppsSystem.Text = "Show system apps";
            this.checkAppsSystem.UseVisualStyleBackColor = true;
            this.checkAppsSystem.CheckedChanged += new System.EventHandler(this.checkAppsSystem_CheckedChanged);
            // 
            // groupBin
            // 
            this.groupBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBin.Controls.Add(this.listRemove);
            this.groupBin.Controls.Add(this.richTextStatus);
            this.groupBin.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBin.ForeColor = System.Drawing.Color.Violet;
            this.groupBin.Location = new System.Drawing.Point(609, 82);
            this.groupBin.Name = "groupBin";
            this.groupBin.Size = new System.Drawing.Size(411, 648);
            this.groupBin.TabIndex = 39;
            this.groupBin.TabStop = false;
            this.groupBin.Text = "Recycle bin";
            // 
            // groupInstalled
            // 
            this.groupInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInstalled.Controls.Add(this.checkAppsSystem);
            this.groupInstalled.Controls.Add(this.listApps);
            this.groupInstalled.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInstalled.ForeColor = System.Drawing.Color.Violet;
            this.groupInstalled.Location = new System.Drawing.Point(28, 82);
            this.groupInstalled.Name = "groupInstalled";
            this.groupInstalled.Size = new System.Drawing.Size(411, 648);
            this.groupInstalled.TabIndex = 40;
            this.groupInstalled.TabStop = false;
            this.groupInstalled.Text = "Installed apps";
            // 
            // AppsPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.groupBin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnRestoreAll);
            this.Controls.Add(this.groupInstalled);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMove);
            this.Name = "AppsPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.groupBin.ResumeLayout(false);
            this.groupInstalled.ResumeLayout(false);
            this.groupInstalled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnUninstall;
        public System.Windows.Forms.RichTextBox richTextStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.CheckBox checkAppsSystem;
        private System.Windows.Forms.GroupBox groupBin;
        private System.Windows.Forms.GroupBox groupInstalled;
    }
}
