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
            this.txtbaslangicsermaye = new System.Windows.Forms.TextBox();
            this.txtfaizorani = new System.Windows.Forms.TextBox();
            this.txtyilsayisi = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Sermayesi :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faiz Oranı (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yıl Sayısı :";
            // 
            // txtbaslangicsermaye
            // 
            this.txtbaslangicsermaye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaslangicsermaye.Location = new System.Drawing.Point(306, 122);
            this.txtbaslangicsermaye.Name = "txtbaslangicsermaye";
            this.txtbaslangicsermaye.Size = new System.Drawing.Size(100, 34);
            this.txtbaslangicsermaye.TabIndex = 3;
            // 
            // txtfaizorani
            // 
            this.txtfaizorani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfaizorani.Location = new System.Drawing.Point(306, 162);
            this.txtfaizorani.Name = "txtfaizorani";
            this.txtfaizorani.Size = new System.Drawing.Size(100, 34);
            this.txtfaizorani.TabIndex = 4;
            // 
            // txtyilsayisi
            // 
            this.txtyilsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyilsayisi.Location = new System.Drawing.Point(306, 202);
            this.txtyilsayisi.Name = "txtyilsayisi";
            this.txtyilsayisi.Size = new System.Drawing.Size(100, 34);
            this.txtyilsayisi.TabIndex = 5;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(306, 256);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(100, 37);
            this.btnhesapla.TabIndex = 6;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtyilsayisi);
            this.Controls.Add(this.txtfaizorani);
            this.Controls.Add(this.txtbaslangicsermaye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbaslangicsermaye;
        private System.Windows.Forms.TextBox txtfaizorani;
        private System.Windows.Forms.TextBox txtyilsayisi;
        private System.Windows.Forms.Button btnhesapla;
    }
}