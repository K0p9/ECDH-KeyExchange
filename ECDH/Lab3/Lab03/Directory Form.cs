using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab03.Bai1;


namespace Lab03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab03.Bai1.Main bai1 = new Lab03.Bai1.Main();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab03.Bai2.Main bai2 = new Lab03.Bai2.Main();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab03.Bai3.Main bai3 = new Lab03.Bai3.Main();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab03.Bai4.Options bai4 = new Lab03.Bai4.Options();
            bai4.Show();
        }
    }
}
