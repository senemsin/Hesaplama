namespace Hesaplama
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.txtindirimorani = new System.Windows.Forms.TextBox();
            this.txtindrmlifiyat = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txttassaruf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(119, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "İndirim Oranı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(115, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "İndirimli Fiyat :";
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunfiyati.Location = new System.Drawing.Point(306, 122);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(100, 34);
            this.txturunfiyati.TabIndex = 3;
            // 
            // txtindirimorani
            // 
            this.txtindirimorani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtindirimorani.Location = new System.Drawing.Point(306, 162);
            this.txtindirimorani.Name = "txtindirimorani";
            this.txtindirimorani.Size = new System.Drawing.Size(100, 34);
            this.txtindirimorani.TabIndex = 4;
            // 
            // txtindrmlifiyat
            // 
            this.txtindrmlifiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtindrmlifiyat.Location = new System.Drawing.Point(306, 202);
            this.txtindrmlifiyat.Name = "txtindrmlifiyat";
            this.txtindrmlifiyat.ReadOnly = true;
            this.txtindrmlifiyat.Size = new System.Drawing.Size(100, 34);
            this.txtindrmlifiyat.TabIndex = 5;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhesapla.Location = new System.Drawing.Point(306, 297);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(100, 37);
            this.btnhesapla.TabIndex = 6;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txttassaruf
            // 
            this.txttassaruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttassaruf.Location = new System.Drawing.Point(306, 242);
            this.txttassaruf.Name = "txttassaruf";
            this.txttassaruf.ReadOnly = true;
            this.txttassaruf.Size = new System.Drawing.Size(100, 34);
            this.txttassaruf.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(168, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tasarruf :";
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Red;
            this.btnkapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkapat.Location = new System.Drawing.Point(12, 375);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(92, 56);
            this.btnkapat.TabIndex = 10;
            this.btnkapat.Text = "Uygulamayı Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(148, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 483);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttassaruf);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtindrmlifiyat);
            this.Controls.Add(this.txtindirimorani);
            this.Controls.Add(this.txturunfiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirim Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.TextBox txtindirimorani;
        private System.Windows.Forms.TextBox txtindrmlifiyat;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txttassaruf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button button1;
    }
}