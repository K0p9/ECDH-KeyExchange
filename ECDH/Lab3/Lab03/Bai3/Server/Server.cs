using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            richTextBox.AppendText("Server started!" + "\n");
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        void StartUnsafeThread()
        {
            ///int bytesReceived = 0;
            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            // Tạo socket bên gởi
            Socket clientSocket;
            // Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của máy và port 8080.Đây là 1 TCP / IP socket.
            //AddressFamily: trả về họ địa chỉ của địa chỉ IP hiện hành. Ở đây là địa chỉ Ipv4 nên chọn AddressFamily.InterNetwork
            //SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu
            //ProtocolType: sử dụng giao thức kết nối nào, ở đây sử dụng kết nối TCP
            // Ba tham số của hàm đi với nhau khi ta thực hiện kết nối TCP.
            Socket listenerSocket = new Socket(
            AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            // bắt đầu lắng nghe. Socket.Listen(int backlog) 
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);
            //Đồng ý kết nối
            clientSocket = listenerSocket.Accept();
            //Nhận dữ liệu
            richTextBox.AppendText("Connection accepted from 127.0.0.1" + "\n");
            while (clientSocket.Connected)
            {
                // Kiểm tra trạng thái kết nối
                if (clientSocket.Poll(0, SelectMode.SelectRead) && clientSocket.Available == 0)
                {
                    richTextBox.AppendText("Disconnected!");
                    // Nếu kết nối đã đóng, thoát khỏi vòng lặp
                    break;
                }

                byte[] buffer = new byte[1024];
                int bytesRead = clientSocket.Receive(buffer);
                string receivedText = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                richTextBox.AppendText(receivedText + "\n");
            }

            listenerSocket.Close();
        }
    }
}