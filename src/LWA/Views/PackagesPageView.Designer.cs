namespace LoveWindowsAgain
{
    partial class PackagesPageView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listOnline = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listInstall = new System.Windows.Forms.ListBox();
            this.richTextStatus = new System.Windows.Forms.RichTextBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.listOnline);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Violet;
            this.groupBox2.Location = new System.Drawing.Point(28, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 648);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote packages";
            // 
            // listOnline
            // 
            this.listOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listOnline.BackColor = System.Drawing.Color.White;
            this.listOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOnline.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOnline.FormattingEnabled = true;
            this.listOnline.ItemHeight = 17;
            this.listOnline.Location = new System.Drawing.Point(11, 36);
            this.listOnline.Name = "listOnline";
            this.listOnline.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listOnline.Size = new System.Drawing.Size(394, 595);
            this.listOnline.Sorted = true;
            this.listOnline.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(481, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAll.Location = new System.Drawing.Point(481, 249);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveAll.TabIndex = 45;
            this.btnRemoveAll.Text = "<< Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listInstall);
            this.groupBox1.Controls.Add(this.richTextStatus);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Violet;
            this.groupBox1.Location = new System.Drawing.Point(609, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 648);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local packages (to be installed)";
            // 
            // listInstall
            // 
            this.listInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInstall.BackColor = System.Drawing.Color.White;
            this.listInstall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInstall.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInstall.FormattingEnabled = true;
            this.listInstall.ItemHeight = 17;
            this.listInstall.Location = new System.Drawing.Point(11, 36);
            this.listInstall.Name = "listInstall";
            this.listInstall.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listInstall.Size = new System.Drawing.Size(394, 595);
            this.listInstall.Sorted = true;
            this.listInstall.TabIndex = 13;
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
            this.richTextStatus.Size = new System.Drawing.Size(393, 613);
            this.richTextStatus.TabIndex = 140;
            this.richTextStatus.Text = "";
            this.richTextStatus.Visible = false;
            // 
            // btnInstall
            // 
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.Black;
            this.btnInstall.Location = new System.Drawing.Point(481, 478);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(89, 23);
            this.btnInstall.TabIndex = 51;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(481, 278);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 23);
            this.btnRemove.TabIndex = 43;
            this.btnRemove.Text = "< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ForeColor = System.Drawing.Color.Black;
            this.btnAddAll.Location = new System.Drawing.Point(481, 131);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(89, 23);
            this.btnAddAll.TabIndex = 46;
            this.btnAddAll.Text = "Add all >>";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(481, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add >";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnBack.TabIndex = 177;
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
            this.label1.Size = new System.Drawing.Size(954, 32);
            this.label1.TabIndex = 178;
            this.label1.Text = "Install packages";
            // 
            // PackagesPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Name = "PackagesPageView";
            this.Size = new System.Drawing.Size(1054, 795);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listOnline;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listInstall;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.RichTextBox richTextStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}
