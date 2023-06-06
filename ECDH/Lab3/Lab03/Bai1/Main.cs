using Lab03.Bai1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            UDPClient uDPClient = new UDPClient();
            uDPClient.Show();
        }

        private void buttonSever_Click(object sender, EventArgs e)
        {
            UDPSever uDPSever = new UDPSever();
            uDPSever.Show();
        }
    }
}
