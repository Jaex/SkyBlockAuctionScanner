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
using System.Linq;
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

            UpdateSearchFilters();
            UpdateButtonStates();
        }

        private void UpdateSearchFilters(bool sort = true)
        {
            lvSearchFilters.Items.Clear();

            if (Settings.SearchFilters.Count > 0)
            {
                if (sort)
                {
                    Settings.SearchFilters = Settings.SearchFilters.
                        OrderBy(x => !x.Enabled).
                        ThenBy(x => x.ItemName).
                        ThenBy(x => x.ItemLore).
                        ThenBy(x => x.ItemLevel).
                        ThenBy(x => x.ItemStars).
                        ThenBy(x => x.ItemTier).
                        ThenBy(x => x.PriceLimit).
                        ToList();
                }

                foreach (SkyBlockAuctionFilter searchFilter in Settings.SearchFilters)
                {
                    AddSearchFilter(searchFilter);
                }
            }
        }

        private void UpdateButtonStates()
        {
            btnEdit.Enabled = btnRemove.Enabled = lvSearchFilters.SelectedItems.Count > 0;
        }

        private void AddSearchFilter(SkyBlockAuctionFilter searchFilter)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = searchFilter;
            lvi.ForeColor = searchFilter.GetTextColor();
            lvi.Text = searchFilter.ToString();
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
                            UpdateSearchFilters();
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
                    UpdateSearchFilters();
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

        private void lvSearchFilters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EditSearchFilter();
            }
        }
    }
}