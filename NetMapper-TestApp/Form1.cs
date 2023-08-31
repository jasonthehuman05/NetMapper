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
            netMapperMap1.DisplayValues();
        }

        private void zoomInPressed(object sender, EventArgs e)
        {
            netMapperMap1.ZoomLevel += 1;
        }

        private void zoomOutPressed(object sender, EventArgs e)
        {
            netMapperMap1.ZoomLevel -= 1;
        }

        private void panLeftPressed(object sender, EventArgs e)
        {
            netMapperMap1.TranslateMap(-1, 0);
        }

        private void panRightPressed(object sender, EventArgs e)
        {
            netMapperMap1.TranslateMap(1, 0);
        }

        private void panDownPressed(object sender, EventArgs e)
        {
            netMapperMap1.TranslateMap(0, 1);
        }

        private void panUpPressed(object sender, EventArgs e)
        {
            netMapperMap1.TranslateMap(0, -1);
        }
    }
}