namespace NetMapper.Locators
{
    internal class LatLonPoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LatLonPoint(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public LatLonPoint() { }
    }
}
