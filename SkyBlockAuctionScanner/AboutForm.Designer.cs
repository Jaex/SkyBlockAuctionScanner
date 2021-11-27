namespace SkyBlockAuctionScanner
{
    partial class AboutForm
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
            this.llGitHub = new System.Windows.Forms.LinkLabel();
            this.lblGitHub = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.llIcon = new System.Windows.Forms.LinkLabel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.llDeveloper = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llGitHub
            // 
            this.llGitHub.AutoSize = true;
            this.llGitHub.Location = new System.Drawing.Point(13, 82);
            this.llGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llGitHub.Name = "llGitHub";
            this.llGitHub.Size = new System.Drawing.Size(299, 16);
            this.llGitHub.TabIndex = 3;
            this.llGitHub.TabStop = true;
            this.llGitHub.Text = "https://github.com/Jaex/SkyBlockAuctionScanner";
            this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHub_LinkClicked);
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Location = new System.Drawing.Point(13, 64);
            this.lblGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(51, 16);
            this.lblGitHub.TabIndex = 2;
            this.lblGitHub.Text = "GitHub:";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(13, 112);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(35, 16);
            this.lblIcon.TabIndex = 4;
            this.lblIcon.Text = "Icon:";
            // 
            // llIcon
            // 
            this.llIcon.AutoSize = true;
            this.llIcon.Location = new System.Drawing.Point(13, 130);
            this.llIcon.Name = "llIcon";
            this.llIcon.Size = new System.Drawing.Size(254, 16);
            this.llIcon.TabIndex = 5;
            this.llIcon.TabStop = true;
            this.llIcon.Text = "https://www.flaticon.com/authors/bukeicon";
            this.llIcon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llIcon_LinkClicked);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(13, 16);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(74, 16);
            this.lblDeveloper.TabIndex = 0;
            this.lblDeveloper.Text = "Developer:";
            // 
            // llDeveloper
            // 
            this.llDeveloper.AutoSize = true;
            this.llDeveloper.Location = new System.Drawing.Point(13, 34);
            this.llDeveloper.Name = "llDeveloper";
            this.llDeveloper.Size = new System.Drawing.Size(36, 16);
            this.llDeveloper.TabIndex = 1;
            this.llDeveloper.TabStop = true;
            this.llDeveloper.Text = "Jaex";
            this.llDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeveloper_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(358, 212);
            this.Controls.Add(this.llDeveloper);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.llIcon);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.llGitHub);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyBlock Auction Scanner - About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llGitHub;
        private System.Windows.Forms.Label lblGitHub;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.LinkLabel llIcon;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.LinkLabel llDeveloper;
    }
}