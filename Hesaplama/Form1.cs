using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 Form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ShowDialog();

        }
        Form3 Form3 = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
            Form3.ShowDialog();
        }
        Form4 Form4 = new Form4();
        private void button3_Click(object sender, EventArgs e)
        {
            Form4.ShowDialog();
        }
    }
}
