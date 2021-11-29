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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace SkyBlockAPILib
{
    public class SkyBlockAPI
    {
        private readonly HttpClient client;

        public SkyBlockAPI()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue()
            {
                NoCache = true
            };
        }

        public async Task<SkyBlockActiveAuctions> GetActiveAuctions(int page)
        {
            return await GetActiveAuctions(page, CancellationToken.None);
        }

        public async Task<SkyBlockActiveAuctions> GetActiveAuctions(int page, CancellationToken cancellationToken)
        {
            // Active auctions: https://api.hypixel.net/#tag/SkyBlock/paths/~1skyblock~1auctions/get
            string url = "https://api.hypixel.net/skyblock/auctions?page=" + page;

            using (HttpResponseMessage responseMesssage = await client.GetAsync(url, cancellationToken).ConfigureAwait(false))
            {
                if (responseMesssage.IsSuccessStatusCode)
                {
                    string responseBody = await responseMesssage.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(responseBody))
                    {
                        return JsonConvert.DeserializeObject<SkyBlockActiveAuctions>(responseBody);
                    }
                }
            }

            return null;
        }
    }
}