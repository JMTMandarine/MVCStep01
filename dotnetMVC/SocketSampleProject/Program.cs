using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketSampleProject
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public partial class Form1 : Form
    {
        TcpListener server = null;
        TcpClient clientSocket = null;
        static int userCnt;
        string date;
        public Dictionary<TcpClient,string> clientList = new Dictionary<TcpClient,string>();
    
        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(InitSocket);
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 8080);
            clientSocket = default(TcpClient);
            server.Start();
            //DisplayText(">> Server Started");
        }
    }
}
