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
using SkyBlockAuctionScanner.Properties;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    internal static class Program
    {
        public const string Name = "SkyBlock Auction Scanner";

        public static string VersionText
        {
            get
            {
                StringBuilder sbVersionText = new StringBuilder();
                Version version = Version.Parse(Application.ProductVersion);
                sbVersionText.Append(version.Major + "." + version.Minor);
                if (version.Build > 0 || version.Revision > 0) sbVersionText.Append("." + version.Build);
                if (version.Revision > 0) sbVersionText.Append("." + version.Revision);
                return sbVersionText.ToString();
            }
        }

        public static string Title => $"{Name} {VersionText}";

        public static readonly string PersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Name);

        private const string SettingsFilename = "Settings.json";

        public static string SettingsFilePath => Path.Combine(PersonalFolder, SettingsFilename);

        public static string BackupFolder => Path.Combine(PersonalFolder, "Backup");

        public static Settings Settings { get; private set; } = new Settings();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings = Settings.Load(SettingsFilePath, BackupFolder, true);
            Settings.CreateBackup = true;

            ShareXResources.Icon = Resources.Icon;
            ShareXResources.UseCustomTheme = true;

            Application.Run(new MainForm());

            SaveSettings();
        }

        public static void SaveSettings()
        {
            if (Settings != null)
            {
                Settings.Save(SettingsFilePath);
            }
        }
    }
}