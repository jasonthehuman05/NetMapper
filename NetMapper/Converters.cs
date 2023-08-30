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

            //Get Latitude
            //TODO GET LATITUDE
            LatLon.Latitude = 0;

            //Get Longitude
            LatLon.Longitude = 0;
            //Tile width is 360/2^n, where n is the zoom level
            float TileWidthDegrees = (float)(360 / Math.Pow(2, Zoom));
            //I am assuming west is -180
            float TileLongitude = (float)((TileX / Math.Pow(2, Zoom) * 360) - 180);
            float TileLongitudeInternalOffset = ((float)X/256) * TileWidthDegrees;

            float FinalLongitude = TileLongitude + TileLongitudeInternalOffset;

            LatLon.Longitude = FinalLongitude;


            //Debug.WriteLine("A" + X);
            //Debug.WriteLine("B" + TileWidthDegrees);
            //Debug.WriteLine("C" + TileLongitude);
            //Debug.WriteLine(TileInternalOffset);


            return LatLon;
        }
    }
}
