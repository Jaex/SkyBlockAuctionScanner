namespace SkyBlockAuctionScanner
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lvAuctions = new ShareX.HelpersLib.MyListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 8);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lvAuctions
            // 
            this.lvAuctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAuctions.AutoFillColumn = true;
            this.lvAuctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAuctions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chItemName,
            this.chPrice});
            this.lvAuctions.FullRowSelect = true;
            this.lvAuctions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAuctions.HideSelection = false;
            this.lvAuctions.Location = new System.Drawing.Point(8, 48);
            this.lvAuctions.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lvAuctions.MultiSelect = false;
            this.lvAuctions.Name = "lvAuctions";
            this.lvAuctions.Size = new System.Drawing.Size(768, 504);
            this.lvAuctions.TabIndex = 5;
            this.lvAuctions.UseCompatibleStateImageBehavior = false;
            this.lvAuctions.View = System.Windows.Forms.View.Details;
            this.lvAuctions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAuctions_MouseDoubleClick);
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 150;
            // 
            // chItemName
            // 
            this.chItemName.Text = "Item name";
            this.chItemName.Width = 430;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 150;
            // 
            // niMain
            // 
            this.niMain.ContextMenuStrip = this.cmsMain;
            this.niMain.Visible = true;
            this.niMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niMain_MouseClick);
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiFilters,
            this.tsmiSettings,
            this.tsmiAbout,
            this.tsmiExit});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.ShowImageMargin = false;
            this.cmsMain.Size = new System.Drawing.Size(116, 124);
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(115, 24);
            this.tsmiStart.Text = "Start";
            this.tsmiStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tsmiFilters
            // 
            this.tsmiFilters.Name = "tsmiFilters";
            this.tsmiFilters.Size = new System.Drawing.Size(115, 24);
            this.tsmiFilters.Text = "Filters...";
            this.tsmiFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(115, 24);
            this.tsmiSettings.Text = "Settings...";
            this.tsmiSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(115, 24);
            this.tsmiAbout.Text = "About...";
            this.tsmiAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(115, 24);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(416, 8);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(128, 32);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(144, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.Location = new System.Drawing.Point(280, 8);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(128, 32);
            this.btnFilters.TabIndex = 2;
            this.btnFilters.Text = "Filters...";
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(552, 8);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(128, 32);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lvAuctions);
            this.Controls.Add(this.btnFilters);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private ShareX.HelpersLib.MyListView lvAuctions;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilters;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

