using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMapper.PointTypes
{
    internal class PointLatLon
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public PointLatLon(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public PointLatLon() { }
    }
}
