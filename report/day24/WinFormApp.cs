//현재시간으로 계속 흐르는 
namespace WinFormsApp24_1
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                thread1 = new Thread(UpdateTime);
                thread1.IsBackground = true;
                thread1.Start();

            }
        }
        private void UpdateTime()
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                string strtime = currentTime.ToString("hh : mm : ss");

                this.Invoke((MethodInvoker)delegate
                {
                    label1.Text = strtime;
                });

                Thread.Sleep(1000);
            }
        }
    }
}
