#region License Information (GPL v3)

/*
    Copyright (c) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;
using SkyBlockAPILib;
using SkyBlockAuctionScanner.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    public partial class MainForm : Form
    {
        private SkyBlockAuctionManager auctionManager;
        private Stopwatch notificationTimer;
        private bool forceClose;

        public MainForm()
        {
            InitializeComponent();
            ShareXResources.ApplyTheme(this);

            UpdateStatus();
            niMain.Text = Program.Name;
            niMain.Icon = Resources.Icon;

            auctionManager = new SkyBlockAuctionManager(Program.Settings);
            auctionManager.NewAuctionFound += AuctionManager_NewAuctionFound;
            auctionManager.ScannerProgressChanged += AuctionManager_ScannerProgressChanged;
            auctionManager.ScannerFinished += AuctionManager_ScannerFinished;
            auctionManager.ScannerStopped += AuctionManager_ScannerStopped;
        }

        private void UpdateStatus(string status = null)
        {
            if (string.IsNullOrEmpty(status))
            {
                Text = Program.Title;
            }
            else
            {
                Text = Program.Title + " - " + status;
            }
        }

        private void AddAuction(SkyBlockAuction auction)
        {
            if (auction == null) return;

            ListViewItem lvi = new ListViewItem();
            lvi.Tag = auction;
            lvi.Text = DateTime.Now.ToString();
            lvi.SubItems.Add(auction.ItemName);
            lvi.SubItems.Add(auction.StartingBid.ToString("N0"));

            lvAuctions.Items.Insert(0, lvi);

            btnClear.Enabled = true;
        }

        private void NewAuctionTasks(SkyBlockAuction auction)
        {
            AddAuction(auction);

            if (notificationTimer == null || notificationTimer.Elapsed.TotalSeconds > 5)
            {
                if (Program.Settings.CopyViewAuctionCommand)
                {
                    string command = auction.ViewAuctionCommand;
                    ClipboardHelpers.CopyText(command);
                }

                if (Program.Settings.ShowNotification)
                {
                    niMain.ShowBalloonTip(4000, auction.ItemName, auction.StartingBid.ToString("N0") + " coins", ToolTipIcon.None);
                }

                notificationTimer = Stopwatch.StartNew();
            }
        }

        public void ForceClose()
        {
            forceClose = true;
            Close();
        }

        private void AuctionManager_NewAuctionFound(SkyBlockAuction auction)
        {
            NewAuctionTasks(auction);
        }

        private void AuctionManager_ScannerProgressChanged(int page, int totalPages)
        {
            UpdateStatus($"Scanning [{page}/{totalPages}]");
        }

        private void AuctionManager_ScannerFinished()
        {
            UpdateStatus("Finished");
        }

        private void AuctionManager_ScannerStopped()
        {
            UpdateStatus("Stopped");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !forceClose)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void niMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ForceActivate();
            }
        }

        private void lvAuctions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvAuctions.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvAuctions.SelectedItems[0];
                SkyBlockAuction auction = lvi.Tag as SkyBlockAuction;
                if (auction != null)
                {
                    string command = auction.ViewAuctionCommand;
                    ClipboardHelpers.CopyText(command);
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!auctionManager.IsRunning)
            {
                if (Program.Settings.SearchFilters.Count == 0)
                {
                    MessageBox.Show("Search filters cannot be empty.", Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnStart.Text = tsmiStart.Text = "Stop";
                btnFilters.Enabled = tsmiFilters.Enabled = btnSettings.Enabled = tsmiSettings.Enabled = false;
                UpdateStatus("Started");

                await auctionManager.Start();

                btnStart.Text = tsmiStart.Text = "Start";
                btnStart.Enabled = btnFilters.Enabled = tsmiFilters.Enabled = btnSettings.Enabled = tsmiSettings.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
                auctionManager.Stop();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvAuctions.Items.Clear();

            btnClear.Enabled = false;
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            using (SearchFiltersForm form = new SearchFiltersForm(Program.Settings))
            {
                form.ShowDialog();
            }

            Program.SaveSettings();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm(Program.Settings))
            {
                form.ShowDialog();
            }

            Program.SaveSettings();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm form = new AboutForm())
            {
                form.ShowDialog();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if (auctionManager.IsRunning)
            {
                auctionManager.Stop();
            }

            ForceClose();
        }
    }
}