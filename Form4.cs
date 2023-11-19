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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Form5 f5 = new Form5();
            f4.Hide();
            f5.Show();
            f5.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();
            f4.Hide();
            f3.Show();
            f3.BringToFront();
        }
    }
}
