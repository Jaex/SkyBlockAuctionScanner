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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SkyBlockAPILib
{
    public class SkyBlockAPIManager
    {
        public delegate void ProgressChangedEventHandler(SkyBlockAuction[] auctions, int page, int totalPages);
        public event ProgressChangedEventHandler ProgressChanged;

        public List<SkyBlockAuction> Auctions { get; set; }
        public int MaxPages { get; set; } = 1000;

        private SkyBlockAPI api;
        private int retryDelay = 3000;
        private int parallelism = 10;
        private long lastUpdated;

        public SkyBlockAPIManager()
        {
            api = new SkyBlockAPI();
        }

        private void OnProgressChanged(SkyBlockAuction[] auctions, int page, int totalPages)
        {
            ProgressChanged?.Invoke(auctions, page, totalPages);
        }

        public async Task UpdateAuctions()
        {
            await UpdateAuctions(CancellationToken.None);
        }

        public async Task UpdateAuctions(CancellationToken cancellationToken)
        {
            Auctions = new List<SkyBlockAuction>();

            int totalPages = 0;
            int pageCount = 1;

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    SkyBlockActiveAuctions activeAuctions = await api.GetActiveAuctions(0, cancellationToken);

                    if (activeAuctions != null && activeAuctions.Success && lastUpdated != activeAuctions.LastUpdated)
                    {
                        lastUpdated = activeAuctions.LastUpdated;
                        totalPages = Math.Min(activeAuctions.TotalPages, MaxPages);

                        Auctions.AddRange(activeAuctions.Auctions);
                        OnProgressChanged(activeAuctions.Auctions, pageCount, totalPages);

                        break;
                    }
                }
                catch
                {
                }

                await Task.Delay(retryDelay, cancellationToken);
            }

            if (totalPages == 0) return;

            await Helpers.ForEachAsync(Enumerable.Range(1, totalPages - 1), async page =>
            {
                try
                {
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        SkyBlockActiveAuctions activeAuctions = await api.GetActiveAuctions(page, cancellationToken);

                        if (activeAuctions != null && activeAuctions.Success)
                        {
                            Auctions.AddRange(activeAuctions.Auctions);
                            pageCount++;
                            OnProgressChanged(activeAuctions.Auctions, pageCount, totalPages);
                        }
                    }
                }
                catch
                {
                }
            }, parallelism);
        }
    }
}