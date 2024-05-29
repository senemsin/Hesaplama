using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace Hesaplama
{
    public partial class Form3 : Form
    {
        string kayitDosyasiYolu = Path.Combine(Application.StartupPath,"hesaplama_kayitlari.txt");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists(kayitDosyasiYolu))
            {
                using (StreamReader okuyucu = new StreamReader(kayitDosyasiYolu))
                {
                    string satir;
                    while ((satir = okuyucu.ReadLine()) != null)
                    {
                        listBox1.Items.Add(satir);
                    }
                }
            }
        }
        private void Kaydet(double alan, double cevre)
        {
            using (StreamWriter yazici = new StreamWriter(kayitDosyasiYolu, true))
            {
                yazici.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Alan: {alan}cm², Çevre: {cevre}cm");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temizle()
        {
            if (File.Exists(kayitDosyasiYolu))
            {
                File.WriteAllText(kayitDosyasiYolu, String.Empty);
                listBox1.Items.Clear();
                MessageBox.Show("Geçmiş başarıyla temizlendi!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'lardan metni okuyun
            string uzunlukMetni = txtUzunluk.Text;
            string genislikMetni = txtGenislik.Text;

            // TextBox'ların boş olup olmadığını kontrol edin
            if (string.IsNullOrEmpty(uzunlukMetni) || string.IsNullOrEmpty(genislikMetni))
            {
                MessageBox.Show("Lütfen uzunluk ve genişlik değerlerini girin.");
                return;
            }

            // Double değerlere dönüştürün
            double uzunluk;
            double genislik;

            // Dönüştürme başarılıysa hesaplamaya devam edin, değilse hata mesajı gösterin
            if (double.TryParse(uzunlukMetni, out uzunluk) && double.TryParse(genislikMetni, out genislik))
            {
                // Hesaplama yap
                double alan = uzunluk * genislik;
                double cevre = 2 * (uzunluk + genislik);
                Kaydet(alan, cevre);

                // Sonuçları göster
                MessageBox.Show($"Alan: {alan}cm², Çevre: {cevre}cm");
            }
            else
            {
                MessageBox.Show("Uzunluk ve genişlik değerleri sayısal olmalıdır.");
            }


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void UygulamayiKapat()
        {
            Application.Exit();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            UygulamayiKapat();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
