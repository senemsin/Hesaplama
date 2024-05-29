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
            // TextBox'lardan metni okuyun
            string boyMetni = textBoy.Text;
            string kiloMetni = textKilo.Text;

            // Virgül içerip içermediğini kontrol edin (boy için)
            if (!boyMetni.Contains(","))
            {
                MessageBox.Show("Boy girdisi virgüllü formatta olmalı (örneğin: 1,80).");
                return;
            }

            // TextBox'ların dolu olup olmadığını kontrol edin
            if (string.IsNullOrEmpty(boyMetni) || string.IsNullOrEmpty(kiloMetni))
            {
                MessageBox.Show("Lütfen boy ve kilo değerlerini girin.");
                return;
            }

            // Double değerlere dönüştürün
            double boy = Convert.ToDouble(boyMetni); // Virgülü noktaya çevirin
            double kilo = Convert.ToDouble(kiloMetni);

            // VKI'yi hesaplayın
            double vki = kilo / (boy * boy);

            // VKİ'yi etikette gösterin
            label2.Text = vki.ToString(); // İki ondalık basamaklı olarak gösterin

            // VKİ aralığına göre durumu belirleyin
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

        private void textBoy_Validated(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
