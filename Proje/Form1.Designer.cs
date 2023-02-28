namespace Proje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_GirisYap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_kayitol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(452, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(255, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(358, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(429, 176);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 41);
            this.textBox1.TabIndex = 4;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(429, 242);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(179, 40);
            this.textBox2.TabIndex = 5;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button_GirisYap
            // 
            this.button_GirisYap.BackColor = System.Drawing.Color.Bisque;
            this.button_GirisYap.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_GirisYap.Location = new System.Drawing.Point(459, 329);
            this.button_GirisYap.Name = "button_GirisYap";
            this.button_GirisYap.Size = new System.Drawing.Size(112, 35);
            this.button_GirisYap.TabIndex = 6;
            this.button_GirisYap.Text = "Giriş Yap";
            this.button_GirisYap.UseVisualStyleBackColor = false;
            this.button_GirisYap.Click += new System.EventHandler(this.button_GirisYap_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(376, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 49);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hesabın Yok Mu?\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(861, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button_kayitol
            // 
            this.button_kayitol.BackColor = System.Drawing.Color.Bisque;
            this.button_kayitol.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_kayitol.Location = new System.Drawing.Point(459, 462);
            this.button_kayitol.Name = "button_kayitol";
            this.button_kayitol.Size = new System.Drawing.Size(112, 35);
            this.button_kayitol.TabIndex = 17;
            this.button_kayitol.Text = "Kayıt Ol!!!";
            this.button_kayitol.UseVisualStyleBackColor = false;
            this.button_kayitol.Click += new System.EventHandler(this.button_kayitol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1007, 611);
            this.Controls.Add(this.button_kayitol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_GirisYap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirişYap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_GirisYap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_kayitol;
    }
}

