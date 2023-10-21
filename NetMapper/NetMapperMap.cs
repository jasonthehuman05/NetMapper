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
            CenterX = (int)Math.Floor((float)Width / 2);
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
            DisplayValues();
        }

        /// <summary>
        /// Triggers when the tile is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileClicked(object sender, EventArgs e)
        {
            MessageLabel.Text = $"{DateTime.Now} - CLICK";
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left) //If it is a left click, then do something
            {

            }
            else if (mouseEvent.Button == MouseButtons.Right)//If it was a right click, zoom in on the selected quadrant
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
                else if (x > CenterX && y < CenterY)
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
                DoZoom = false;
                UpdateMapPosition(ntx, nty, ZoomLevel + 1);
                DoZoom = true;
            }
        }
        bool DoZoom = true;

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
                    //Possible zoom
                    //If its a zoom in, double the tiles to stay in the correct area
                    if (value > _ZoomLevel && DoZoom)
                    {
                        TileX *= 2;
                        TileY *= 2;
                    }
                    //If it is a zoom out, we will need to do some maths to check which tile to go to.
                    else if (value < _ZoomLevel && DoZoom)
                    {
                        TileX = (int)Math.Floor((decimal)(TileX / 2));
                        TileY = (int)Math.Floor((decimal)(TileY / 2));
                    }
                    //Make the change
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

        /// <summary>
        /// Move the map in the specified way, if possible
        /// </summary>
        /// <param name="WarpX"></param>
        /// <param name="WarpY"></param>
        public void TranslateMap(int WarpX, int WarpY)
        {
            int MaxTiles = (int)Math.Floor(Math.Pow(2, ZoomLevel)); //Get the maximum number of tiles that are available at this zoom level
            //Clamp it into the range (UB)
            while (TileX + WarpX >= MaxTiles) { WarpX -= 1; }
            while (TileX + WarpY >= MaxTiles) { WarpY -= 1; }

            //Clamp it into the range (LB)
            while (TileX + WarpX < 0) { WarpX += 1; }
            while (TileY + WarpY < 0) { WarpY += 1; }

            Debug.WriteLine($"wx: {WarpX}");
            Debug.WriteLine($"wy: {WarpY}");

            TileX = TileX + WarpX;
            TileY = TileY + WarpY;

            ReloadTile();
        }

        /// <summary>
        /// DEBUG show map parameters
        /// </summary>
        public void DisplayValues()
        {
            Debug.WriteLine($"Tile X {TileX}");
            Debug.WriteLine($"Tile Y {TileY}");
            Debug.WriteLine($"Zoom   {ZoomLevel}");
        }
    }
}