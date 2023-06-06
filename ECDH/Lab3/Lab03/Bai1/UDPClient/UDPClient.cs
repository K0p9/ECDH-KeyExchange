using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai1
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            string ipAddress = textBoxIP.Text;
            int severport = Convert.ToInt32(textBoxPort.Text);

            UdpClient udpClient = new UdpClient();

            string mess = richTextBox1.Text;
            Byte[] sendBytes = Encoding.Unicode.GetBytes(mess);
            //Gởi dữ liệu mà không cần thiết lập kết nối với Server
            udpClient.Send(sendBytes, sendBytes.Length, ipAddress, severport);
        }
    }
}
