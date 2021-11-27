namespace SkyBlockAuctionScanner
{
    partial class SearchFiltersForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvSearchFilters = new ShareX.HelpersLib.MyListView();
            this.chItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItemTier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBINFilter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPriceLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(144, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(280, 8);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 32);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvSearchFilters
            // 
            this.lvSearchFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSearchFilters.AutoFillColumn = true;
            this.lvSearchFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSearchFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItemName,
            this.chItemTier,
            this.chBINFilter,
            this.chPriceLimit});
            this.lvSearchFilters.FullRowSelect = true;
            this.lvSearchFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSearchFilters.HideSelection = false;
            this.lvSearchFilters.Location = new System.Drawing.Point(8, 48);
            this.lvSearchFilters.Margin = new System.Windows.Forms.Padding(4);
            this.lvSearchFilters.MultiSelect = false;
            this.lvSearchFilters.Name = "lvSearchFilters";
            this.lvSearchFilters.Size = new System.Drawing.Size(768, 504);
            this.lvSearchFilters.TabIndex = 3;
            this.lvSearchFilters.UseCompatibleStateImageBehavior = false;
            this.lvSearchFilters.View = System.Windows.Forms.View.Details;
            this.lvSearchFilters.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSearchFilters_ItemSelectionChanged);
            this.lvSearchFilters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSearchFilters_MouseDoubleClick);
            // 
            // chItemName
            // 
            this.chItemName.Text = "Item name";
            this.chItemName.Width = 360;
            // 
            // chItemTier
            // 
            this.chItemTier.Text = "Item tier";
            this.chItemTier.Width = 120;
            // 
            // chBINFilter
            // 
            this.chBINFilter.Text = "BIN filter";
            this.chBINFilter.Width = 120;
            // 
            // chPriceLimit
            // 
            this.chPriceLimit.Text = "Price limit";
            this.chPriceLimit.Width = 120;
            // 
            // SearchFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvSearchFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchFiltersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyBlock Auction Scanner - Search filters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private ShareX.HelpersLib.MyListView lvSearchFilters;
        private System.Windows.Forms.ColumnHeader chItemName;
        private System.Windows.Forms.ColumnHeader chItemTier;
        private System.Windows.Forms.ColumnHeader chBINFilter;
        private System.Windows.Forms.ColumnHeader chPriceLimit;
    }
}