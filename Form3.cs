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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form7 f7 = new Form7();
            f3.Hide();
            f7.Show();
            f7.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();
            f3.Hide();
            f4.Show();
            f4.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form5 f5 = new Form5();
            f3.Hide();
            f5.Show();
            f5.BringToFront();
        }
    }
}
