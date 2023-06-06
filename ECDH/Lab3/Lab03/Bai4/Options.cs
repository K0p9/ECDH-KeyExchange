using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai4
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Lab03.Bai4.Client.Client client = new Lab03.Bai4.Client.Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Lab03.Bai4.Server.Server server = new Lab03.Bai4.Server.Server();
            server.Show();
        }
    }
}
