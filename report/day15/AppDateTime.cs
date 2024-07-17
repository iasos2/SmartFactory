namespace WinFormsApp01501
{
    public partial class Form1 : Form
    {
        //멤버변수
        private int number = 0;
        private DateTime NowTime;
        //생성자
        public Form1()
        {
            InitializeComponent();
        }
        //멤버메소드
        private void GetNumber()
        {
            number++;
        }
        private void OutNumber()
        {
            textBox1.AppendText(number + "\r\n");
        }
        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            textBox2.AppendText(NowTime + "\r\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                GetNumber();
                OutNumber();
                GetTime();
                OutTime();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
