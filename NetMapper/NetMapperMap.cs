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
        /// <summary>
        /// Fires when the NetMapperMap control is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlResized(object sender, EventArgs e)
        {
            centerX = (int)Math.Floor((double)Width/2);
            centerY = (int)Math.Floor((double)Width / 2);
            MessageBox.Show($"resized to {Width}x{Height}. New Midpoint is at {centerX},{centerY}");
        }

        /// <summary>
        /// Creates a new tile inside the master control
        /// </summary>
        /// <param name="tileImage">the Image to use</param>
        /// <param name="posX">X position of the tile</param>
        /// <param name="posY">Y position of the tile</param>
        public void DrawTile(Image tileImage, int posX, int posY)
        {
            PictureBox pictureBox = new PictureBox() { 
                Location = new Point(posX, posY),
                Size = new Size(256,256),
                Image = tileImage
            };
            this.Controls.Add(pictureBox);
        }
    }
}