namespace SkyBlockAuctionScanner
{
    partial class SearchFilterForm
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.cbItemNameUseRegex = new System.Windows.Forms.CheckBox();
            this.lblItemLevel = new System.Windows.Forms.Label();
            this.nudItemLevel = new System.Windows.Forms.NumericUpDown();
            this.lblItemTier = new System.Windows.Forms.Label();
            this.cbItemTier = new System.Windows.Forms.ComboBox();
            this.lblPriceLimit = new System.Windows.Forms.Label();
            this.nudPriceLimit = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBINFilter = new System.Windows.Forms.Label();
            this.cbBINFilter = new System.Windows.Forms.ComboBox();
            this.lblItemStars = new System.Windows.Forms.Label();
            this.nudItemStars = new System.Windows.Forms.NumericUpDown();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.lblItemLore = new System.Windows.Forms.Label();
            this.txtItemLore = new System.Windows.Forms.TextBox();
            this.cbItemLoreUseRegex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(13, 48);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(72, 16);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(16, 72);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(304, 22);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // cbItemNameUseRegex
            // 
            this.cbItemNameUseRegex.AutoSize = true;
            this.cbItemNameUseRegex.Location = new System.Drawing.Point(232, 48);
            this.cbItemNameUseRegex.Name = "cbItemNameUseRegex";
            this.cbItemNameUseRegex.Size = new System.Drawing.Size(88, 20);
            this.cbItemNameUseRegex.TabIndex = 3;
            this.cbItemNameUseRegex.Text = "Use regex";
            this.cbItemNameUseRegex.UseVisualStyleBackColor = true;
            // 
            // lblItemLevel
            // 
            this.lblItemLevel.AutoSize = true;
            this.lblItemLevel.Location = new System.Drawing.Point(13, 160);
            this.lblItemLevel.Name = "lblItemLevel";
            this.lblItemLevel.Size = new System.Drawing.Size(67, 16);
            this.lblItemLevel.TabIndex = 7;
            this.lblItemLevel.Text = "Item level:";
            // 
            // nudItemLevel
            // 
            this.nudItemLevel.Location = new System.Drawing.Point(16, 184);
            this.nudItemLevel.Name = "nudItemLevel";
            this.nudItemLevel.Size = new System.Drawing.Size(72, 22);
            this.nudItemLevel.TabIndex = 8;
            this.nudItemLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItemTier
            // 
            this.lblItemTier.AutoSize = true;
            this.lblItemTier.Location = new System.Drawing.Point(13, 272);
            this.lblItemTier.Name = "lblItemTier";
            this.lblItemTier.Size = new System.Drawing.Size(56, 16);
            this.lblItemTier.TabIndex = 11;
            this.lblItemTier.Text = "Item tier:";
            // 
            // cbItemTier
            // 
            this.cbItemTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemTier.FormattingEnabled = true;
            this.cbItemTier.Location = new System.Drawing.Point(16, 296);
            this.cbItemTier.Name = "cbItemTier";
            this.cbItemTier.Size = new System.Drawing.Size(144, 24);
            this.cbItemTier.TabIndex = 12;
            // 
            // lblPriceLimit
            // 
            this.lblPriceLimit.AutoSize = true;
            this.lblPriceLimit.Location = new System.Drawing.Point(13, 384);
            this.lblPriceLimit.Name = "lblPriceLimit";
            this.lblPriceLimit.Size = new System.Drawing.Size(67, 16);
            this.lblPriceLimit.TabIndex = 15;
            this.lblPriceLimit.Text = "Price limit:";
            // 
            // nudPriceLimit
            // 
            this.nudPriceLimit.Location = new System.Drawing.Point(16, 408);
            this.nudPriceLimit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPriceLimit.Name = "nudPriceLimit";
            this.nudPriceLimit.Size = new System.Drawing.Size(144, 22);
            this.nudPriceLimit.TabIndex = 16;
            this.nudPriceLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPriceLimit.ThousandsSeparator = true;
            this.nudPriceLimit.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(104, 456);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 32);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(216, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBINFilter
            // 
            this.lblBINFilter.AutoSize = true;
            this.lblBINFilter.Location = new System.Drawing.Point(13, 328);
            this.lblBINFilter.Name = "lblBINFilter";
            this.lblBINFilter.Size = new System.Drawing.Size(59, 16);
            this.lblBINFilter.TabIndex = 13;
            this.lblBINFilter.Text = "BIN filter:";
            // 
            // cbBINFilter
            // 
            this.cbBINFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBINFilter.FormattingEnabled = true;
            this.cbBINFilter.Location = new System.Drawing.Point(16, 352);
            this.cbBINFilter.Name = "cbBINFilter";
            this.cbBINFilter.Size = new System.Drawing.Size(144, 24);
            this.cbBINFilter.TabIndex = 14;
            // 
            // lblItemStars
            // 
            this.lblItemStars.AutoSize = true;
            this.lblItemStars.Location = new System.Drawing.Point(13, 216);
            this.lblItemStars.Name = "lblItemStars";
            this.lblItemStars.Size = new System.Drawing.Size(67, 16);
            this.lblItemStars.TabIndex = 9;
            this.lblItemStars.Text = "Item stars:";
            // 
            // nudItemStars
            // 
            this.nudItemStars.Location = new System.Drawing.Point(16, 240);
            this.nudItemStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudItemStars.Name = "nudItemStars";
            this.nudItemStars.Size = new System.Drawing.Size(72, 22);
            this.nudItemStars.TabIndex = 10;
            this.nudItemStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(16, 16);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(77, 20);
            this.cbEnabled.TabIndex = 0;
            this.cbEnabled.Text = "Enabled";
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // lblItemLore
            // 
            this.lblItemLore.AutoSize = true;
            this.lblItemLore.Location = new System.Drawing.Point(13, 104);
            this.lblItemLore.Name = "lblItemLore";
            this.lblItemLore.Size = new System.Drawing.Size(61, 16);
            this.lblItemLore.TabIndex = 4;
            this.lblItemLore.Text = "Item lore:";
            // 
            // txtItemLore
            // 
            this.txtItemLore.Location = new System.Drawing.Point(16, 128);
            this.txtItemLore.Name = "txtItemLore";
            this.txtItemLore.Size = new System.Drawing.Size(304, 22);
            this.txtItemLore.TabIndex = 5;
            // 
            // cbItemLoreUseRegex
            // 
            this.cbItemLoreUseRegex.AutoSize = true;
            this.cbItemLoreUseRegex.Location = new System.Drawing.Point(232, 104);
            this.cbItemLoreUseRegex.Name = "cbItemLoreUseRegex";
            this.cbItemLoreUseRegex.Size = new System.Drawing.Size(88, 20);
            this.cbItemLoreUseRegex.TabIndex = 6;
            this.cbItemLoreUseRegex.Text = "Use regex";
            this.cbItemLoreUseRegex.UseVisualStyleBackColor = true;
            // 
            // SearchFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(336, 504);
            this.Controls.Add(this.cbItemLoreUseRegex);
            this.Controls.Add(this.txtItemLore);
            this.Controls.Add(this.lblItemLore);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.nudItemStars);
            this.Controls.Add(this.lblItemStars);
            this.Controls.Add(this.cbBINFilter);
            this.Controls.Add(this.lblBINFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudPriceLimit);
            this.Controls.Add(this.lblPriceLimit);
            this.Controls.Add(this.cbItemTier);
            this.Controls.Add(this.lblItemTier);
            this.Controls.Add(this.nudItemLevel);
            this.Controls.Add(this.lblItemLevel);
            this.Controls.Add(this.cbItemNameUseRegex);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyBlock Auction Scanner - Search filter";
            ((System.ComponentModel.ISupportInitialize)(this.nudItemLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.CheckBox cbItemNameUseRegex;
        private System.Windows.Forms.Label lblItemLevel;
        private System.Windows.Forms.NumericUpDown nudItemLevel;
        private System.Windows.Forms.Label lblItemTier;
        private System.Windows.Forms.ComboBox cbItemTier;
        private System.Windows.Forms.Label lblPriceLimit;
        private System.Windows.Forms.NumericUpDown nudPriceLimit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBINFilter;
        private System.Windows.Forms.ComboBox cbBINFilter;
        private System.Windows.Forms.Label lblItemStars;
        private System.Windows.Forms.NumericUpDown nudItemStars;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.Label lblItemLore;
        private System.Windows.Forms.TextBox txtItemLore;
        private System.Windows.Forms.CheckBox cbItemLoreUseRegex;
    }
}