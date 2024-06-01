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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double urunFiyati;
            double indirimOrani;
            double indirimliFiyat;

            if (!double.TryParse(txturunfiyati.Text, out urunFiyati))
            {
                MessageBox.Show("Ürün fiyatı geçersiz formatta!");
                return;
            }

            if (!double.TryParse(txtindirimorani.Text, out indirimOrani))
            {
                MessageBox.Show("İndirim oranı geçersiz formatta!");
                return;
            }

            indirimliFiyat = urunFiyati * (1 - indirimOrani / 100);
            lblindirimlifiyat.Text = indirimliFiyat.ToString("0.00") + " TL";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UygulamayiKapat()
        {
            Application.Exit();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            UygulamayiKapat();
        }
    }
    
}
