namespace NetMapper.PointTypes
{
    public class LocalCartesian
    {
        public float LocalX { get; set; }
        public float LocalY { get; set; }

        public LocalCartesian(float x, float y)
        {
            LocalX = x;
            LocalY = y;
        }
        public LocalCartesian() { }
    }
}