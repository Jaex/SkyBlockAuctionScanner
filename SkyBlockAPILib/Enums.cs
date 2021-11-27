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

using System.ComponentModel;

namespace SkyBlockAPILib
{
    public enum SkyBlockItemTier
    {
        [Description("No filter")]
        NO_FILTER,
        [Description("Common")]
        COMMON,
        [Description("Uncommon")]
        UNCOMMON,
        [Description("Rare")]
        RARE,
        [Description("Epic")]
        EPIC,
        [Description("Legendary")]
        LEGENDARY,
        [Description("Mythic")]
        MYTHIC,
        [Description("Divine")]
        SUPREME,
        [Description("Special")]
        SPECIAL,
        [Description("Very special")]
        VERY_SPECIAL
    }

    public enum SkyBlockBINFilter
    {
        [Description("Show All")]
        SHOW_ALL,
        [Description("BIN Only")]
        BIN_ONLY,
        [Description("Auctions Only")]
        AUCTIONS_ONLY
    }
}