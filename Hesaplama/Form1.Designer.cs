﻿namespace Hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.vkigiris = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAPLAMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vkigiris
            // 
            this.vkigiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vkigiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkigiris.Location = new System.Drawing.Point(234, 95);
            this.vkigiris.Name = "vkigiris";
            this.vkigiris.Size = new System.Drawing.Size(169, 79);
            this.vkigiris.TabIndex = 1;
            this.vkigiris.Text = "Vücut Kitle \r\nİndeksi";
            this.vkigiris.UseVisualStyleBackColor = false;
            this.vkigiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(234, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 79);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alan Ve \r\nÇevre Hesaplama\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(234, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "İndirim Hesaplayıcı";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Red;
            this.btnkapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkapat.Location = new System.Drawing.Point(499, 311);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(92, 56);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Uygulamayı Kapat";
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(632, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vkigiris);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button vkigiris;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkapat;
    }
}

