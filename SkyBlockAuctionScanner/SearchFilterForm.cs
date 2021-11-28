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
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    public partial class SearchFilterForm : Form
    {
        public SkyBlockAuctionFilter SearchFilter { get; private set; }

        public SearchFilterForm(SkyBlockAuctionFilter searchFilter)
        {
            InitializeComponent();
            ShareXResources.ApplyTheme(this);

            SearchFilter = searchFilter;

            cbEnabled.Checked = SearchFilter.Enabled;
            txtItemName.Text = SearchFilter.ItemName;
            cbUseRegex.Checked = SearchFilter.UseRegex;
            nudItemLevel.Value = SearchFilter.ItemLevel;
            nudItemStars.Value = SearchFilter.ItemStars;
            cbItemTier.Items.AddRange(Helpers.GetEnumDescriptions<SkyBlockItemTier>());
            cbItemTier.SelectedIndex = (int)SearchFilter.ItemTier;
            cbBINFilter.Items.AddRange(Helpers.GetEnumDescriptions<SkyBlockBINFilter>());
            cbBINFilter.SelectedIndex = (int)SearchFilter.BINFilter;
            nudPriceLimit.Value = SearchFilter.PriceLimit;
        }

        private void SaveChanges()
        {
            SearchFilter.Enabled = cbEnabled.Checked;
            SearchFilter.ItemName = txtItemName.Text;
            SearchFilter.UseRegex = cbUseRegex.Checked;
            SearchFilter.ItemLevel = (int)nudItemLevel.Value;
            SearchFilter.ItemStars = (int)nudItemStars.Value;
            SearchFilter.ItemTier = (SkyBlockItemTier)cbItemTier.SelectedIndex;
            SearchFilter.BINFilter = (SkyBlockBINFilter)cbBINFilter.SelectedIndex;
            SearchFilter.PriceLimit = (long)nudPriceLimit.Value;
        }

        private void txtItemName_TextChanged(object sender, System.EventArgs e)
        {
            btnOK.Enabled = !string.IsNullOrWhiteSpace(txtItemName.Text);
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            SaveChanges();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}