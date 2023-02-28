namespace Proje
{
    partial class OdemeIslemi
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
            this.button_siparisi_tamamla = new System.Windows.Forms.Button();
            this.button_sikayet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_skt = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_kart_num = new System.Windows.Forms.MaskedTextBox();
            this.textBox_ad_soyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_cvc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_musteri_num = new System.Windows.Forms.MaskedTextBox();
            this.textBox_urun_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_siparisi_tamamla
            // 
            this.button_siparisi_tamamla.BackColor = System.Drawing.Color.Green;
            this.button_siparisi_tamamla.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.button_siparisi_tamamla.ForeColor = System.Drawing.Color.White;
            this.button_siparisi_tamamla.Location = new System.Drawing.Point(284, 385);
            this.button_siparisi_tamamla.Name = "button_siparisi_tamamla";
            this.button_siparisi_tamamla.Size = new System.Drawing.Size(124, 53);
            this.button_siparisi_tamamla.TabIndex = 21;
            this.button_siparisi_tamamla.Text = "Siparişi Tamamla!";
            this.button_siparisi_tamamla.UseVisualStyleBackColor = false;
            this.button_siparisi_tamamla.Click += new System.EventHandler(this.button_siparisi_tamamla_Click);
            // 
            // button_sikayet
            // 
            this.button_sikayet.BackColor = System.Drawing.Color.Red;
            this.button_sikayet.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.button_sikayet.ForeColor = System.Drawing.Color.White;
            this.button_sikayet.Location = new System.Drawing.Point(423, 385);
            this.button_sikayet.Name = "button_sikayet";
            this.button_sikayet.Size = new System.Drawing.Size(124, 53);
            this.button_sikayet.TabIndex = 20;
            this.button_sikayet.Text = "Sepete Dön!";
            this.button_sikayet.UseVisualStyleBackColor = false;
            this.button_sikayet.Click += new System.EventHandler(this.button_sepete_don_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kart Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(471, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Son Kullanma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(222, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(595, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "CVC:";
            // 
            // maskedTextBox_skt
            // 
            this.maskedTextBox_skt.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_skt.Location = new System.Drawing.Point(662, 207);
            this.maskedTextBox_skt.Mask = "00-9999";
            this.maskedTextBox_skt.Name = "maskedTextBox_skt";
            this.maskedTextBox_skt.Size = new System.Drawing.Size(70, 31);
            this.maskedTextBox_skt.TabIndex = 31;
            // 
            // maskedTextBox_kart_num
            // 
            this.maskedTextBox_kart_num.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_kart_num.Location = new System.Drawing.Point(206, 282);
            this.maskedTextBox_kart_num.Mask = "0000-0000-0000-0000";
            this.maskedTextBox_kart_num.Name = "maskedTextBox_kart_num";
            this.maskedTextBox_kart_num.Size = new System.Drawing.Size(178, 31);
            this.maskedTextBox_kart_num.TabIndex = 32;
            // 
            // textBox_ad_soyad
            // 
            this.textBox_ad_soyad.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.textBox_ad_soyad.Location = new System.Drawing.Point(249, 128);
            this.textBox_ad_soyad.Multiline = true;
            this.textBox_ad_soyad.Name = "textBox_ad_soyad";
            this.textBox_ad_soyad.Size = new System.Drawing.Size(191, 34);
            this.textBox_ad_soyad.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Kart Sahibinin Adı/Soyadı:";
            // 
            // maskedTextBox_cvc
            // 
            this.maskedTextBox_cvc.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_cvc.Location = new System.Drawing.Point(662, 277);
            this.maskedTextBox_cvc.Mask = "000";
            this.maskedTextBox_cvc.Name = "maskedTextBox_cvc";
            this.maskedTextBox_cvc.Size = new System.Drawing.Size(70, 31);
            this.maskedTextBox_cvc.TabIndex = 35;
            // 
            // maskedTextBox_musteri_num
            // 
            this.maskedTextBox_musteri_num.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_musteri_num.Location = new System.Drawing.Point(206, 212);
            this.maskedTextBox_musteri_num.Mask = "(999) 000-0000";
            this.maskedTextBox_musteri_num.Name = "maskedTextBox_musteri_num";
            this.maskedTextBox_musteri_num.Size = new System.Drawing.Size(132, 31);
            this.maskedTextBox_musteri_num.TabIndex = 36;
            // 
            // textBox_urun_id
            // 
            this.textBox_urun_id.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_id.Location = new System.Drawing.Point(662, 131);
            this.textBox_urun_id.Name = "textBox_urun_id";
            this.textBox_urun_id.Size = new System.Drawing.Size(70, 31);
            this.textBox_urun_id.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(510, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ürün Numarası:";
            // 
            // OdemeIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_urun_id);
            this.Controls.Add(this.maskedTextBox_musteri_num);
            this.Controls.Add(this.maskedTextBox_cvc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ad_soyad);
            this.Controls.Add(this.maskedTextBox_kart_num);
            this.Controls.Add(this.maskedTextBox_skt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_siparisi_tamamla);
            this.Controls.Add(this.button_sikayet);
            this.Name = "OdemeIslemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdemeIslemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_siparisi_tamamla;
        private System.Windows.Forms.Button button_sikayet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_skt;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_kart_num;
        private System.Windows.Forms.TextBox textBox_ad_soyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cvc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_musteri_num;
        private System.Windows.Forms.TextBox textBox_urun_id;
        private System.Windows.Forms.Label label7;
    }
}