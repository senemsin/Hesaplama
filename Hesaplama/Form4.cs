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
            // TextBox'lardan metni okuyun
            string urunFiyatiMetni = txturunfiyati.Text;
            string indirimOraniMetni = txtindirimorani.Text;

            // TextBox'ların boş olup olmadığını kontrol edin
            if (string.IsNullOrEmpty(urunFiyatiMetni) || string.IsNullOrEmpty(indirimOraniMetni))
            {
                MessageBox.Show("Lütfen ürün fiyatı ve indirim oranı değerlerini girin.");
                return;
            }

            // Double değerlere dönüştürün
            double urunFiyati;
            double indirimOrani;

            // Dönüştürme başarılıysa hesaplamaya devam edin, değilse hata mesajı gösterin
            if (double.TryParse(urunFiyatiMetni, out urunFiyati) && double.TryParse(indirimOraniMetni, out indirimOrani))
            {
                // Hesaplama yap
                double indirimliFiyat = urunFiyati * (1 - indirimOrani / 100);
                double tasarruf = urunFiyati - indirimliFiyat;

                // Sonuçları göster
                txtindrmlifiyat.Text = indirimliFiyat.ToString("0.00");
                txttassaruf.Text = tasarruf.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ürün fiyatı ve indirim oranı değerleri sayısal olmalıdır.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void UygulamayiKapat()
        {
            Application.Exit();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            UygulamayiKapat();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
