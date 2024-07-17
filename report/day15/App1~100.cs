namespace WinFormsApp15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iSutja;
            Double dSum_Odd = 0, dSum_Even = 0;

            iSutja = int.Parse(textBox1.Text);

            textBox2.Text = " ";
            textBox3.Text = " ";

            for (i = 1; i <= iSutja; ++i)
            {
                if (i % 2 == 0)
                {
                    dSum_Even = dSum_Even + i;
                    textBox3.Text = textBox3.Text + i + " + ";
                }
                else
                {
                    dSum_Odd = dSum_Odd + i;
                    textBox2.Text = textBox2.Text + i + " + ";
                }
            }
            textBox2.Text = textBox2.Text + " = " + dSum_Odd;
            textBox3.Text = textBox3.Text + " = " + dSum_Even;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
