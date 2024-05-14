using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesaplama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(textBoy. Text);
            kilo = Convert.ToDouble(textKilo.Text);
            vki = kilo / (boy * boy);
            label2.Text = vki.ToString();
            if (vki < 18)
            {
                label4.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label4.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label4.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label4.Text = "Obez";
            }
            else
            {
                label4.Text = "Ciddi Obez";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    
}
