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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace SkyBlockAPILib
{
    public class SkyBlockAuctionFilter
    {
        private const char SkyBlockItemStar = '✪';

        public bool Enabled { get; set; } = true;
        public string ItemName { get; set; } = "";
        public bool ItemNameUseRegex { get; set; } = false;
        public string ItemLore { get; set; } = "";
        public bool ItemLoreUseRegex { get; set; } = false;
        public int ItemLevel { get; set; } = 0;
        public int ItemStars { get; set; } = 0;
        public SkyBlockItemTier ItemTier { get; set; } = SkyBlockItemTier.NO_FILTER;
        public SkyBlockBINFilter BINFilter { get; set; } = SkyBlockBINFilter.BIN_ONLY;
        public long PriceLimit { get; set; } = 1_000_000;

        public override string ToString()
        {
            string itemName = "";

            if (ItemLevel > 0)
            {
                itemName += "[Lvl " + ItemLevel + "] ";
            }

            itemName += ItemName;

            if (ItemStars > 0)
            {
                string stars = new string(SkyBlockItemStar, ItemStars);
                itemName += " " + stars;
            }

            if (!string.IsNullOrWhiteSpace(ItemLore))
            {
                itemName += " (" + ItemLore + ")";
            }

            return itemName;
        }

        public SkyBlockAuction[] ApplyFilter(IEnumerable<SkyBlockAuction> auctions, bool orderByStartingBid = false)
        {
            if (auctions == null || !Enabled || string.IsNullOrWhiteSpace(ItemName))
            {
                return null;
            }

            if (BINFilter != SkyBlockBINFilter.SHOW_ALL)
            {
                bool bin = BINFilter == SkyBlockBINFilter.BIN_ONLY;
                auctions = auctions.Where(x => x.Bin == bin);
            }

            if (ItemNameUseRegex)
            {
                Regex regex = new Regex(ItemName, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                auctions = auctions.Where(x => regex.IsMatch(x.ItemName));
            }
            else
            {
                auctions = auctions.Where(x => x.ItemName.Contains(ItemName, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(ItemLore))
            {
                if (ItemLoreUseRegex)
                {
                    Regex regex = new Regex(ItemLore, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                    auctions = auctions.Where(x => regex.IsMatch(x.ItemLore));
                }
                else
                {
                    auctions = auctions.Where(x => x.ItemLore.Contains(ItemLore, StringComparison.OrdinalIgnoreCase));
                }
            }

            if (ItemLevel > 0)
            {
                Regex regex = new Regex(@"^\[Lvl (\d+)\] .+$", RegexOptions.Compiled);
                auctions = auctions.Where(x =>
                {
                    Match match = regex.Match(x.ItemName);
                    return match.Success && int.TryParse(match.Groups[1].Value, out int level) && level >= ItemLevel;
                });
            }

            if (ItemStars > 0)
            {
                string stars = new string(SkyBlockItemStar, ItemStars);
                auctions = auctions.Where(x => x.ItemName.EndsWith(stars, StringComparison.OrdinalIgnoreCase));
            }

            if (ItemTier != SkyBlockItemTier.NO_FILTER)
            {
                string tier = ItemTier.ToString();
                auctions = auctions.Where(x => x.Tier.Equals(tier, StringComparison.OrdinalIgnoreCase));
            }

            if (PriceLimit > 0)
            {
                auctions = auctions.Where(x => x.StartingBid <= PriceLimit);
            }

            if (orderByStartingBid)
            {
                auctions = auctions.OrderBy(x => x.StartingBid);
            }

            return auctions.ToArray();
        }

        public bool TestItemName(IEnumerable<SkyBlockAuction> auctions)
        {
            if (!string.IsNullOrWhiteSpace(ItemName))
            {
                if (ItemNameUseRegex)
                {
                    Regex regex = new Regex(ItemName, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                    return auctions.Any(x => regex.IsMatch(x.ItemName));
                }
                else
                {
                    return auctions.Any(x => x.ItemName.Contains(ItemName, StringComparison.OrdinalIgnoreCase));
                }
            }

            return false;
        }

        public Color GetTextColor()
        {
            if (!Enabled)
            {
                return Color.FromArgb(85, 85, 85);
            }

            switch (ItemTier)
            {
                default:
                case SkyBlockItemTier.NO_FILTER:
                    return Color.FromArgb(210, 210, 210);
                case SkyBlockItemTier.COMMON:
                    return Color.FromArgb(255, 255, 255);
                case SkyBlockItemTier.UNCOMMON:
                    return Color.FromArgb(85, 255, 85);
                case SkyBlockItemTier.RARE:
                    return Color.FromArgb(85, 85, 255);
                case SkyBlockItemTier.EPIC:
                    return Color.FromArgb(170, 0, 170);
                case SkyBlockItemTier.LEGENDARY:
                    return Color.FromArgb(255, 170, 0);
                case SkyBlockItemTier.MYTHIC:
                    return Color.FromArgb(255, 85, 255);
                case SkyBlockItemTier.SUPREME:
                    return Color.FromArgb(85, 255, 255);
                case SkyBlockItemTier.SPECIAL:
                    return Color.FromArgb(255, 85, 85);
                case SkyBlockItemTier.VERY_SPECIAL:
                    return Color.FromArgb(255, 85, 85);
            }
        }
    }
}