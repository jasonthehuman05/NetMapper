namespace NetMapper.Locators
{
    internal class CartesianPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public CartesianPoint(double _X, double _Y)
        {
            X = _X;
            Y = _Y;
        }
        public CartesianPoint() { }
    }
}
