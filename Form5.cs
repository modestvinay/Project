using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            Form11 f11 = new Form11();
            f5.Hide();
            f11.Show();
            f11.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form12 f12 = new Form12();
            f4.Hide();
            f12.Show();
            f12.BringToFront();
        }
    }
}
