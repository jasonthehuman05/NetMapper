namespace NetMapper
{
    public partial class NetMapperMap : UserControl
    {
        int centerX;
        int centerY;

        public NetMapperMap()
        {
            InitializeComponent();
            centerX = Width / 2;
            centerY = Width / 2;
        }

        private void ControlResized(object sender, EventArgs e)
        {
            centerX = (int)Math.Floor((double)Width/2);
            centerY = (int)Math.Floor((double)Width / 2);
            MessageBox.Show($"resized to {Width}x{Height}. New Midpoint is at {centerX},{centerY}");
        }
    }
}