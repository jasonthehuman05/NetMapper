using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMapper.PointTypes
{
    internal class PointLatLon
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public PointLatLon(float latitude, float longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public PointLatLon() { }
    }
}
