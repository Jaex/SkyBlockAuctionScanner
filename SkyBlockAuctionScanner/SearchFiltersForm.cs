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
using System;
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    public partial class SearchFiltersForm : Form
    {
        public Settings Settings { get; private set; }

        public SearchFiltersForm(Settings settings)
        {
            InitializeComponent();
            ShareXResources.ApplyTheme(this);

            Settings = settings;

            foreach (SkyBlockAuctionFilter searchFilter in Settings.SearchFilters)
            {
                AddSearchFilter(searchFilter);
            }

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            btnEdit.Enabled = btnRemove.Enabled = lvSearchFilters.SelectedItems.Count > 0;
        }

        private void AddSearchFilter(SkyBlockAuctionFilter searchFilter)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = searchFilter;
            lvi.Text = searchFilter.ToString();
            lvi.Checked = searchFilter.Enabled;
            lvi.SubItems.Add(searchFilter.ItemTier.GetDescription());
            lvi.SubItems.Add(searchFilter.BINFilter.GetDescription());
            lvi.SubItems.Add(searchFilter.PriceLimit.ToString("N0"));

            lvSearchFilters.Items.Add(lvi);
        }

        private void EditSearchFilter()
        {
            if (lvSearchFilters.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSearchFilters.SelectedItems[0];
                SkyBlockAuctionFilter searchFilter = lvi.Tag as SkyBlockAuctionFilter;

                if (searchFilter != null)
                {
                    using (SearchFilterForm form = new SearchFilterForm(searchFilter))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            lvi.Text = searchFilter.ToString();
                            lvi.SubItems[1].Text = searchFilter.ItemTier.GetDescription();
                            lvi.SubItems[2].Text = searchFilter.BINFilter.GetDescription();
                            lvi.SubItems[3].Text = searchFilter.PriceLimit.ToString("N0");
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SkyBlockAuctionFilter searchFilter = new SkyBlockAuctionFilter();

            using (SearchFilterForm form = new SearchFilterForm(searchFilter))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Settings.SearchFilters.Add(searchFilter);
                    AddSearchFilter(searchFilter);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSearchFilter();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvSearchFilters.SelectedIndices.Count > 0)
            {
                int index = lvSearchFilters.SelectedIndices[0];
                Settings.SearchFilters.RemoveAt(index);
                lvSearchFilters.Items.RemoveAt(index);
            }
        }

        private void lvSearchFilters_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateButtonStates();
        }

        private void lvSearchFilters_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            SkyBlockAuctionFilter searchFilter = e.Item.Tag as SkyBlockAuctionFilter;

            if (searchFilter != null)
            {
                searchFilter.Enabled = e.Item.Checked;
            }
        }

        private void lvSearchFilters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EditSearchFilter();
            }
        }
    }
}