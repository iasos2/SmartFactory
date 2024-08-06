namespace haha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarR.Value = 0;
            trackBarG.Value = 0;
            trackBarB.Value = 0;
            UpdateColor();
        }
        private void UpdateColor()
        {
            int r = trackBarR.Value;
            int g = trackBarG.Value;
            int b = trackBarB.Value;
            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
