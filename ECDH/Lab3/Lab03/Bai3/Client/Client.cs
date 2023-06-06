using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai3
{
    public partial class Client : Form
    {
        // Khởi tạo một địa chỉ IP và port
        string serverIP = "127.0.0.1";
        int serverPort = 8080;

        // Tạo một socket TCP/IP
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Client()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Kết nối đến địa chỉ IP và port của server
            clientSocket.Connect(serverIP, serverPort);
            buttonSend.Enabled = true;
            buttonConnect.Enabled = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Gửi dữ liệu đến server
            string message = richTextBox1.Text;
            byte[] sendData = Encoding.Unicode.GetBytes(message);
            clientSocket.Send(sendData);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            buttonSend.Enabled = false;
        }
    }
}
