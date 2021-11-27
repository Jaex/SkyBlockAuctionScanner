namespace SkyBlockAuctionScanner
{
    partial class SettingsForm
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
            this.cbCopyViewAuctionCommand = new System.Windows.Forms.CheckBox();
            this.cbShowNotification = new System.Windows.Forms.CheckBox();
            this.lblOnAuctionFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCopyViewAuctionCommand
            // 
            this.cbCopyViewAuctionCommand.AutoSize = true;
            this.cbCopyViewAuctionCommand.Location = new System.Drawing.Point(16, 64);
            this.cbCopyViewAuctionCommand.Name = "cbCopyViewAuctionCommand";
            this.cbCopyViewAuctionCommand.Size = new System.Drawing.Size(197, 20);
            this.cbCopyViewAuctionCommand.TabIndex = 2;
            this.cbCopyViewAuctionCommand.Text = "Copy view auction command";
            this.cbCopyViewAuctionCommand.UseVisualStyleBackColor = true;
            this.cbCopyViewAuctionCommand.CheckedChanged += new System.EventHandler(this.cbCopyViewAuctionCommand_CheckedChanged);
            // 
            // cbShowNotification
            // 
            this.cbShowNotification.AutoSize = true;
            this.cbShowNotification.Location = new System.Drawing.Point(16, 40);
            this.cbShowNotification.Name = "cbShowNotification";
            this.cbShowNotification.Size = new System.Drawing.Size(125, 20);
            this.cbShowNotification.TabIndex = 1;
            this.cbShowNotification.Text = "Show notification";
            this.cbShowNotification.UseVisualStyleBackColor = true;
            this.cbShowNotification.CheckedChanged += new System.EventHandler(this.cbShowNotification_CheckedChanged);
            // 
            // lblOnAuctionFound
            // 
            this.lblOnAuctionFound.AutoSize = true;
            this.lblOnAuctionFound.Location = new System.Drawing.Point(13, 16);
            this.lblOnAuctionFound.Name = "lblOnAuctionFound";
            this.lblOnAuctionFound.Size = new System.Drawing.Size(109, 16);
            this.lblOnAuctionFound.TabIndex = 0;
            this.lblOnAuctionFound.Text = "On auction found:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(354, 215);
            this.Controls.Add(this.cbCopyViewAuctionCommand);
            this.Controls.Add(this.lblOnAuctionFound);
            this.Controls.Add(this.cbShowNotification);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyBlock Auction Scanner - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbShowNotification;
        private System.Windows.Forms.CheckBox cbCopyViewAuctionCommand;
        private System.Windows.Forms.Label lblOnAuctionFound;
    }
}