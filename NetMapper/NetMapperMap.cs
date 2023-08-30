using System.Diagnostics;

namespace NetMapper
{
    public partial class NetMapperMap : UserControl
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int TileX { get; set; }
        public int TileY{ get; set; }
        public int ZoomLevel { get; set; }

        public NetMapperMap()
        {
            InitializeComponent();
            CenterX = Width / 2;
            CenterY = Width / 2;
            ZoomLevel = 0;
            LoadTile(0, 0, 0);
        }
        /// <summary>
        /// Fires when the NetMapperMap control is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlResized(object sender, EventArgs e)
        {
            CenterX = (int)Math.Floor((double)Width/2);
            CenterY = (int)Math.Floor((double)Width / 2);
            MessageBox.Show($"resized to {Width}x{Height}. New Midpoint is at {CenterX},{CenterY}");
        }

        public void LoadTile()
        {
            Image i = OpenStreetMapInteraction.TileFetcher.GetTile(TileX, TileY, ZoomLevel);
            tileHolder.Image = i;
        }

        private void TileClicked(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int clickX = mouseEvent.X;

            
            Converters.GetClickLocation(mouseEvent.X, mouseEvent.Y, 0, 0, ZoomLevel);
        }
    }
}