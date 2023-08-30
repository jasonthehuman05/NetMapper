using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetMapper.OpenStreetMapInteraction
{
    internal class TileFetcher
    {
        /// <summary>
        /// Gets a tile from OpenStreetMap based on the provided parameters
        /// </summary>
        /// <param name="tileX">The X position of the tile</param>
        /// <param name="tileY">The X position of the tile</param>
        /// <param name="zoom">The zoom level</param>
        /// <returns></returns>
        public static Image GetTile(int tileX, int tileY, int zoom)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] = "NetMapperBase/0.1 (CSharp dotnet 6; win64;)";
                byte[] d = client.DownloadData(new Uri($"https://tile.openstreetmap.org/0/0/0.png"));

                using (var memoryStream = new MemoryStream(d))
                {
                    Image I = Image.FromStream(memoryStream);
                    return I;
                }
            }
        }
    }
}
