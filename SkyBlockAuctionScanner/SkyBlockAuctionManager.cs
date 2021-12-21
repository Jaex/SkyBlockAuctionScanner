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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyBlockAuctionScanner
{
    public class SkyBlockAuctionManager
    {
        public delegate void AuctionEventHandler(SkyBlockAuction auction);
        public event AuctionEventHandler NewAuctionFound;

        public delegate void AuctionProgressEventHandler(int page, int totalPages);
        public event AuctionProgressEventHandler ScannerProgressChanged;

        public event Action ScannerFinished;

        public event Action ScannerStopped;

        public SkyBlockAPIManager APIManager { get; private set; }
        public bool IsRunning { get; private set; }
        public Settings Settings { get; private set; }

        private CancellationTokenSource cts;
        private Dictionary<string, SkyBlockAuction> auctionsFound;
        private bool filtersTested;

        public SkyBlockAuctionManager(Settings settings)
        {
            Settings = settings;

            APIManager = new SkyBlockAPIManager();
            APIManager.ProgressChanged += APIManager_ProgressChanged;
        }

        private void APIManager_ProgressChanged(SkyBlockAuction[] auctions, int page, int totalPages)
        {
            SearchItems(auctions, Settings.SearchFilters);

            OnScannerProgressChanged(page, totalPages);
        }

        private void OnNewAuctionFound(SkyBlockAuction auction)
        {
            NewAuctionFound?.Invoke(auction);
        }

        private void OnScannerProgressChanged(int page, int totalPages)
        {
            ScannerProgressChanged?.Invoke(page, totalPages);
        }

        private void OnScannerFinished()
        {
            ScannerFinished?.Invoke();
        }

        private void OnScannerStopped()
        {
            ScannerStopped?.Invoke();
        }

        public async Task Start()
        {
            if (IsRunning) return;

            IsRunning = true;
            auctionsFound = new Dictionary<string, SkyBlockAuction>();
            filtersTested = false;
            cts = new CancellationTokenSource();

            try
            {
                CancellationToken cancellationToken = cts.Token;

                while (!cancellationToken.IsCancellationRequested)
                {
                    await APIManager.UpdateAuctions(cancellationToken);

                    OnScannerFinished();

                    if (!filtersTested)
                    {
                        TestFilters(APIManager.Auctions, Settings.SearchFilters);
                        filtersTested = true;
                    }
                }
            }
            catch (Exception e)
            {
                DebugHelper.WriteException(e);
            }
            finally
            {
                cts.Dispose();
                cts = null;

                IsRunning = false;

                OnScannerStopped();
            }
        }

        private void SearchItems(IEnumerable<SkyBlockAuction> auctions, List<SkyBlockAuctionFilter> filters)
        {
            if (filters != null)
            {
                foreach (SkyBlockAuctionFilter filter in filters)
                {
                    SkyBlockAuction[] auctionsFiltered = filter.ApplyFilter(auctions);

                    if (auctionsFiltered != null)
                    {
                        foreach (SkyBlockAuction auction in auctionsFiltered)
                        {
                            if (!auctionsFound.ContainsKey(auction.UUID))
                            {
                                auctionsFound.Add(auction.UUID, auction);

                                OnNewAuctionFound(auction);
                            }
                        }
                    }
                }
            }
        }

        private bool TestFilters(IEnumerable<SkyBlockAuction> auctions, List<SkyBlockAuctionFilter> filters)
        {
            if (filters != null)
            {
                List<string> itemNames = new List<string>();

                foreach (SkyBlockAuctionFilter filter in filters)
                {
                    if (!filter.TestItemName(auctions))
                    {
                        itemNames.Add(filter.ItemName);
                    }
                }

                if (itemNames.Count > 0)
                {
                    MessageBox.Show("Unable to find these items:\r\n\r\n" + string.Join("\r\n", itemNames) + "\r\n\r\nMake sure item names are correct!",
                        Program.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        public void Stop()
        {
            cts?.Cancel();
        }
    }
}