using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMapper
{
    internal class Converters
    {
        public static PointTypes.PointLatLon LocalToLatLon(int X, int Y, int TileX, int TileY, int Zoom)
        {
            PointTypes.PointLatLon LatLon = new PointTypes.PointLatLon();

            double tileSize = 256;

            //Get Latitude
            LatLon.Latitude = 0;
            float numTiles = (float)Math.Pow(2, Zoom);
            float normalizedY = (float)(Y / tileSize) / numTiles;
            float latitudeRadians = (float)Math.Atan(Math.Sinh(Math.PI * (1 - 2 * normalizedY)));
            float latitude = latitudeRadians * (float)(180.0 / Math.PI); //In degrees because i am sane.
            LatLon.Latitude = latitude;


            //Get Longitude
            LatLon.Longitude = 0;
            //Tile width is 360/2^n, where n is the zoom level
            float TileWidthDegrees = (float)(360 / Math.Pow(2, Zoom));
            //I am assuming west is -180
            float TileLongitude = (float)((TileX / Math.Pow(2, Zoom) * 360) - 180);
            float TileLongitudeInternalOffset = ((float)X/256) * TileWidthDegrees; //Get the offset within the clicked tile.

            float FinalLongitude = TileLongitude + TileLongitudeInternalOffset;
            LatLon.Longitude = FinalLongitude;

            return LatLon;
        }

        public static PointTypes.LocalCartesian LatLonToLocal(PointTypes.PointLatLon LatLon, int TileX, int TileY, int Zoom)
        {
            PointTypes.LocalCartesian LocalPoint = new PointTypes.LocalCartesian();
            float tileSize = 256;

            //Lat to Y
            float numTiles = (float)Math.Pow(2, Zoom);
            float latitudeRadians = LatLon.Latitude * (float)(Math.PI / 180.0);
            // Calculate normalized Y-coordinate from latitude radians
            float normalizedY = (float)((1.0 - Math.Log(Math.Tan(latitudeRadians) + 1.0 / Math.Cos(latitudeRadians)) / Math.PI) / 2.0);
            // Convert normalized Y-coordinate to pixel-based Y-coordinate
            LocalPoint.LocalY = normalizedY * numTiles * tileSize;

            //Lon to X
            LocalPoint.LocalX = 0;
            float xTileCoordinate = (float)((LatLon.Longitude + 180.0) / 360.0 * numTiles); //The tile clicked.
            float clickedX = xTileCoordinate * tileSize; //The pixel within that tile

            LocalPoint.LocalX = clickedX;


            return LocalPoint;
        }
    }
}
