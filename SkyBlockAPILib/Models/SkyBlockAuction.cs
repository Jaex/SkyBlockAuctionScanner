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

using Newtonsoft.Json;
using System;

namespace SkyBlockAPILib
{
    public class SkyBlockAuction
    {
        public string UUID { get; set; }
        public string Auctioneer { get; set; }
        [JsonProperty("profile_id")]
        public string ProfileID { get; set; }
        // coop
        public long Start { get; set; }
        public long End { get; set; }
        [JsonProperty("item_name")]
        public string ItemName { get; set; }
        [JsonProperty("item_lore")]
        public string ItemLore { get; set; }
        public string Extra { get; set; }
        public string Category { get; set; }
        public string Tier { get; set; }
        [JsonProperty("starting_bid")]
        public long StartingBid { get; set; }
        // item_bytes
        public bool Claimed { get; set; }
        // claimed_bidders
        [JsonProperty("highest_bid_amount")]
        public long HighestBidAmount { get; set; }
        // bids
        public bool Bin { get; set; }

        public DateTime StartDateTime => DateTimeOffset.FromUnixTimeMilliseconds(Start).DateTime;
        public DateTime EndDateTime => DateTimeOffset.FromUnixTimeMilliseconds(End).DateTime;
        public string ViewAuctionCommand => "/viewauction " + UUID;
    }
}