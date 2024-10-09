서버

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        private Socket client;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(textBox2.Text.Trim());
            client.Send(bytes);
            showMsg("Me : " + textBox2.Text);
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread serverthread = new Thread(serverFunc);
            serverthread.Start();
            serverthread.IsBackground = true;
        }

        private void serverFunc(object obj)
        {
            using(Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                EndPoint endPoint=new IPEndPoint(IPAddress.Any,10000);
                socket.Bind(endPoint);
                socket.Listen(10);

                client = socket.Accept();

                Thread receivethread = new Thread(receive);
                receivethread.Start();

                receivethread.IsBackground = true;
            }
        }

        private void receive()
        {
            while (true)
            {
                byte[] bytes= new byte[1024];
                int nRecv=client.Receive(bytes);

                string txt=Encoding.UTF8.GetString(bytes,0, nRecv);
                showMsg("you : " + txt);
            }
        }

        private void showMsg(string msg)
        {
            textBox1.AppendText(msg);
            textBox1.AppendText("\r\n");

            this.Activate();
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}

클라이언트
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(textBox2.Text.Trim());
            socket.Send(bytes);
            showMsg("me : " + textBox2.Text);
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, 10000);

            socket.Connect(endpoint);

            Thread clientthread = new Thread(new ThreadStart(Receive));
            clientthread.Start();
            clientthread.IsBackground = true;
        }
        private void Receive()
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                int nRecv = socket.Receive(bytes);

                string txt = Encoding.UTF8.GetString(bytes);
                showMsg("you : " + txt);
            }
        }
        private void showMsg(string msg)
        {
            textBox1.AppendText(msg);
            textBox1.AppendText("\r\n");

            this.Activate();
            textBox1.Focus();

            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}

