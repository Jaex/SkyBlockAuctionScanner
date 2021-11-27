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
            this.cbUseRegex = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudItemLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(13, 16);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(72, 16);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(16, 40);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(304, 22);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // cbUseRegex
            // 
            this.cbUseRegex.AutoSize = true;
            this.cbUseRegex.Location = new System.Drawing.Point(16, 72);
            this.cbUseRegex.Name = "cbUseRegex";
            this.cbUseRegex.Size = new System.Drawing.Size(88, 20);
            this.cbUseRegex.TabIndex = 2;
            this.cbUseRegex.Text = "Use regex";
            this.cbUseRegex.UseVisualStyleBackColor = true;
            // 
            // lblItemLevel
            // 
            this.lblItemLevel.AutoSize = true;
            this.lblItemLevel.Location = new System.Drawing.Point(13, 104);
            this.lblItemLevel.Name = "lblItemLevel";
            this.lblItemLevel.Size = new System.Drawing.Size(67, 16);
            this.lblItemLevel.TabIndex = 3;
            this.lblItemLevel.Text = "Item level:";
            // 
            // nudItemLevel
            // 
            this.nudItemLevel.Location = new System.Drawing.Point(16, 128);
            this.nudItemLevel.Name = "nudItemLevel";
            this.nudItemLevel.Size = new System.Drawing.Size(72, 22);
            this.nudItemLevel.TabIndex = 4;
            this.nudItemLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItemTier
            // 
            this.lblItemTier.AutoSize = true;
            this.lblItemTier.Location = new System.Drawing.Point(13, 216);
            this.lblItemTier.Name = "lblItemTier";
            this.lblItemTier.Size = new System.Drawing.Size(56, 16);
            this.lblItemTier.TabIndex = 7;
            this.lblItemTier.Text = "Item tier:";
            // 
            // cbItemTier
            // 
            this.cbItemTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemTier.FormattingEnabled = true;
            this.cbItemTier.Location = new System.Drawing.Point(16, 240);
            this.cbItemTier.Name = "cbItemTier";
            this.cbItemTier.Size = new System.Drawing.Size(144, 24);
            this.cbItemTier.TabIndex = 8;
            // 
            // lblPriceLimit
            // 
            this.lblPriceLimit.AutoSize = true;
            this.lblPriceLimit.Location = new System.Drawing.Point(13, 328);
            this.lblPriceLimit.Name = "lblPriceLimit";
            this.lblPriceLimit.Size = new System.Drawing.Size(67, 16);
            this.lblPriceLimit.TabIndex = 11;
            this.lblPriceLimit.Text = "Price limit:";
            // 
            // nudPriceLimit
            // 
            this.nudPriceLimit.Location = new System.Drawing.Point(16, 352);
            this.nudPriceLimit.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPriceLimit.Name = "nudPriceLimit";
            this.nudPriceLimit.Size = new System.Drawing.Size(144, 22);
            this.nudPriceLimit.TabIndex = 12;
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
            this.btnOK.Location = new System.Drawing.Point(104, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 32);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(216, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblBINFilter
            // 
            this.lblBINFilter.AutoSize = true;
            this.lblBINFilter.Location = new System.Drawing.Point(13, 272);
            this.lblBINFilter.Name = "lblBINFilter";
            this.lblBINFilter.Size = new System.Drawing.Size(59, 16);
            this.lblBINFilter.TabIndex = 9;
            this.lblBINFilter.Text = "BIN filter:";
            // 
            // cbBINFilter
            // 
            this.cbBINFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBINFilter.FormattingEnabled = true;
            this.cbBINFilter.Location = new System.Drawing.Point(16, 296);
            this.cbBINFilter.Name = "cbBINFilter";
            this.cbBINFilter.Size = new System.Drawing.Size(144, 24);
            this.cbBINFilter.TabIndex = 10;
            // 
            // lblItemStars
            // 
            this.lblItemStars.AutoSize = true;
            this.lblItemStars.Location = new System.Drawing.Point(13, 160);
            this.lblItemStars.Name = "lblItemStars";
            this.lblItemStars.Size = new System.Drawing.Size(67, 16);
            this.lblItemStars.TabIndex = 5;
            this.lblItemStars.Text = "Item stars:";
            // 
            // nudItemStars
            // 
            this.nudItemStars.Location = new System.Drawing.Point(16, 184);
            this.nudItemStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudItemStars.Name = "nudItemStars";
            this.nudItemStars.Size = new System.Drawing.Size(72, 22);
            this.nudItemStars.TabIndex = 6;
            this.nudItemStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(336, 445);
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
            this.Controls.Add(this.cbUseRegex);
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
        private System.Windows.Forms.CheckBox cbUseRegex;
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
    }
}