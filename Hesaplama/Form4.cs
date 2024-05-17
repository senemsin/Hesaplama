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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            // Değerleri Al
            double baslangicSermayesi = Convert.ToDouble(txtbaslangicsermaye.Text);
            double faizOrani = Convert.ToDouble(txtfaizorani.Text) / 100; // Yüzde cinsinden alındığı için 100'e bölünür
            int yilSayisi = Convert.ToInt32(txtyilsayisi.Text);

            // Faizi hesapla
            double toplamPara = baslangicSermayesi * (1 + faizOrani * yilSayisi);

            // Sonuç
            MessageBox.Show($"Toplam Para: {toplamPara}");
        }
    }
}
