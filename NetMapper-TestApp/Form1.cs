namespace NetMapper_TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //netMapperMap1.DrawTile(Image.FromFile("testTile.png"), 0, 0);
        }

        private void zoomInPressed(object sender, EventArgs e)
        {
            netMapperMap1.ZoomLevel += 1;
        }

        private void zoomOutPressed(object sender, EventArgs e)
        {
            netMapperMap1.ZoomLevel -= 1;
        }
    }
}