using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab03.Bai1
{
    public partial class UDPSever : Form
    {
        public UDPSever()
        {
            InitializeComponent();
        }

        private void UDPSever_Load(object sender, EventArgs e)
        {
            
        }   

        public void serverThread()
        {
            int port = Convert.ToInt32(textBoxPort.Text);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.Unicode.GetString(receiveBytes);
                string mess = RemoteIpEndPoint + " : " + returnData;
                //Viết hàm InfoMessage để hiển thị thông điệp lên List View
                InfoMessage(mess);
            }
        }

        public void InfoMessage(string mess)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(InfoMessage), mess);
                return;
            }
            richTextBox.AppendText(mess + "\n");
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = true;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
