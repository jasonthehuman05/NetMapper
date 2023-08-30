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
            centerX = Width / 2;
            centerY = Width / 2;
        }
    }
}