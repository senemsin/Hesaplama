namespace Hesaplama
{
    partial class Form2
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
            this.lblboy = new System.Windows.Forms.Label();
            this.lblkilo = new System.Windows.Forms.Label();
            this.textBoy = new System.Windows.Forms.TextBox();
            this.textKilo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnkapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblboy
            // 
            this.lblboy.AutoSize = true;
            this.lblboy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblboy.Location = new System.Drawing.Point(11, 52);
            this.lblboy.Name = "lblboy";
            this.lblboy.Size = new System.Drawing.Size(182, 39);
            this.lblboy.TabIndex = 0;
            this.lblboy.Text = "Boy(1,80) :";
            // 
            // lblkilo
            // 
            this.lblkilo.AutoSize = true;
            this.lblkilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkilo.Location = new System.Drawing.Point(100, 94);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(93, 39);
            this.lblkilo.TabIndex = 1;
            this.lblkilo.Text = "Kilo :";
            // 
            // textBoy
            // 
            this.textBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoy.Location = new System.Drawing.Point(199, 52);
            this.textBoy.Name = "textBoy";
            this.textBoy.Size = new System.Drawing.Size(175, 36);
            this.textBoy.TabIndex = 2;
            this.textBoy.Validated += new System.EventHandler(this.textBoy_Validated);
            // 
            // textKilo
            // 
            this.textKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKilo.Location = new System.Drawing.Point(199, 98);
            this.textKilo.Name = "textKilo";
            this.textKilo.Size = new System.Drawing.Size(175, 36);
            this.textKilo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(230, 258);
            this.label2.MaximumSize = new System.Drawing.Size(100, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(230, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 5;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhesapla.Location = new System.Drawing.Point(199, 163);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(175, 50);
            this.btnhesapla.TabIndex = 6;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Durum :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(102, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "VKİ :";
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Red;
            this.btnkapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkapat.Location = new System.Drawing.Point(18, 385);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(92, 56);
            this.btnkapat.TabIndex = 9;
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
            this.button1.Location = new System.Drawing.Point(138, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Anasayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 483);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKilo);
            this.Controls.Add(this.textBoy);
            this.Controls.Add(this.lblkilo);
            this.Controls.Add(this.lblboy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vki Hesaplama";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.Label lblkilo;
        private System.Windows.Forms.TextBox textBoy;
        private System.Windows.Forms.TextBox textKilo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button button1;
    }
}