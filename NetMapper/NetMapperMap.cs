using System.Diagnostics;

namespace NetMapper
{
    public partial class NetMapperMap : UserControl
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int TileX = 0;
        public int TileY = 0;
        private int _ZoomLevel = 0;

        public NetMapperMap()
        {
            InitializeComponent();
            CenterX = Width / 2;
            CenterY = Width / 2;
            ReloadTile();
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
        public void ReloadTile()
        {
            Image i = OpenStreetMapInteraction.TileFetcher.GetTile(ref TileX, ref TileY, _ZoomLevel);
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
            if (mouseEvent.Button == MouseButtons.Left) //If it is a left click, then do something
            {
                
            }
            else if(mouseEvent.Button == MouseButtons.Right)//If it was a right click, zoom in on the selected quadrant
            {
                int x = mouseEvent.X;
                int y = mouseEvent.Y;

                int ntx = TileX;
                int nty = TileY;
                if (x < CenterX && y < CenterY)
                {
                    //top left
                    ntx = TileX * 2;
                    nty = TileY * 2;
                }
                else if(x > CenterX && y < CenterY)
                {
                    //top right
                    ntx = TileX * 2 + 1;
                    nty = TileY * 2;
                }
                else if (x < CenterX && y > CenterY)
                {
                    //bottom left
                    ntx = TileX * 2;
                    nty = TileY * 2 + 1;
                }
                else if (x > CenterX && y > CenterY)
                {
                    //bottom right
                    ntx = TileX * 2 + 1;
                    nty = TileY * 2 + 1;
                }
                UpdateMapPosition(ntx, nty, ZoomLevel + 1);
            }
        }

        /// <summary>
        /// Update the zoom level
        /// </summary>
        public int ZoomLevel
        {
            get => _ZoomLevel;
            set
            {
                if (value < 20 && value > -1)
                {
                    //Possible zoom, make the change
                    _ZoomLevel = value;
                    //TODO UPDATE ON ZOOM
                    ReloadTile();
                }
            }
        }

        /// <summary>
        /// Move the map to the location (local coordinates) and zoom level provided
        /// </summary>
        /// <param name="NewX"></param>
        /// <param name="NewY"></param>
        /// <param name="NewZoom"></param>
        public void UpdateMapPosition(int NewX, int NewY, int NewZoom)
        {
            TileX = NewX;
            TileY = NewY;
            ZoomLevel = NewZoom;
        }
        
        public void DisplayValues()
        {
            Debug.WriteLine($"Tile X {TileX}");
            Debug.WriteLine($"Tile Y {TileY}");
            Debug.WriteLine($"Zoom   {ZoomLevel}");
        }
    }
}