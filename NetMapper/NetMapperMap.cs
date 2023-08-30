using System.Diagnostics;

namespace NetMapper
{
    public partial class NetMapperMap : UserControl
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int TileX { get; set; } = 0;
        public int TileY{ get; set; } = 0;
        public int ZoomLevel { get; set; } = 0;

        public NetMapperMap()
        {
            InitializeComponent();
            CenterX = Width / 2;
            CenterY = Width / 2;
            LoadTile();
        }

        /// <summary>
        /// Fires when the NetMapperMap control is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlResized(object sender, EventArgs e)
        {
            CenterX = (int)Math.Floor((float)Width/2);
            CenterY = (int)Math.Floor((float)Width / 2);
            MessageBox.Show($"resized to {Width}x{Height}. New Midpoint is at {CenterX},{CenterY}");
        }

        /// <summary>
        /// Downloads a tile and places it into the PictureBox
        /// </summary>
        public void LoadTile()
        {
            Image i = OpenStreetMapInteraction.TileFetcher.GetTile(TileX, TileY, ZoomLevel);
            tileHolder.Image = i;
        }

        /// <summary>
        /// Triggers when the tile is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileClicked(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int clickX = mouseEvent.X;

            
            PointTypes.PointLatLon p = Converters.LocalToLatLon(mouseEvent.X, mouseEvent.Y, 0, 0, ZoomLevel);
            MessageBox.Show($"{p.Latitude.ToString()} , {p.Longitude.ToString()}");
        }
    
        public void Zoom(int amount)
        {
            if(ZoomLevel + amount < 20 && ZoomLevel + amount > -1)
            {
                //Possible zoom, make the change
                ZoomLevel = ZoomLevel + amount;
                //TODO UPDATE ON ZOOM
            }
        }
    }
}