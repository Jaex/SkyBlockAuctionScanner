﻿#region License Information (GPL v3)

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
using System;
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    public partial class SettingsForm : Form
    {
        public Settings Settings { get; private set; }

        public SettingsForm(Settings settings)
        {
            InitializeComponent();
            ShareXResources.ApplyTheme(this);

            Settings = settings;

            cbMinimizeToTray.Checked = Settings.MinimizeToTray;
            cbShowNotification.Checked = Settings.ShowNotification;
            cbCopyViewAuctionCommand.Checked = Settings.CopyViewAuctionCommand;
        }

        private void cbMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            Settings.MinimizeToTray = cbMinimizeToTray.Checked;
        }

        private void cbShowNotification_CheckedChanged(object sender, EventArgs e)
        {
            Settings.ShowNotification = cbShowNotification.Checked;
        }

        private void cbCopyViewAuctionCommand_CheckedChanged(object sender, EventArgs e)
        {
            Settings.CopyViewAuctionCommand = cbCopyViewAuctionCommand.Checked;
        }
    }
}