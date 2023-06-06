﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Bai3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Lab03.Bai3.Client client = new Lab03.Bai3.Client();
            client.Show();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            Lab03.Bai3.Server server = new Lab03.Bai3.Server();
            server.Show();
        }
    }
}
