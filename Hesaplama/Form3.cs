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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Değerleri al
            double uzunluk = Convert.ToDouble(txtUzunluk.Text);
            double genislik = Convert.ToDouble(txtGenislik.Text);

            // Hesaplama yap
            double alan = uzunluk * genislik;
            double cevre = 2 * (uzunluk + genislik);

            // Sonuçları göster
            MessageBox.Show($"Alan: {alan}cm², Çevre: {cevre}cm");
        }
    }
}
