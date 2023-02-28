namespace Proje
{
    partial class Sikayet
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
            this.button_sikayet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_alisveris_yap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorunuzu Bizimle Paylaşmanızdan Mutluluk Duyarız!";
            // 
            // button_sikayet
            // 
            this.button_sikayet.BackColor = System.Drawing.Color.Red;
            this.button_sikayet.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_sikayet.ForeColor = System.Drawing.Color.White;
            this.button_sikayet.Location = new System.Drawing.Point(277, 384);
            this.button_sikayet.Name = "button_sikayet";
            this.button_sikayet.Size = new System.Drawing.Size(124, 53);
            this.button_sikayet.TabIndex = 7;
            this.button_sikayet.Text = "Gönder!";
            this.button_sikayet.UseVisualStyleBackColor = false;
            this.button_sikayet.Click += new System.EventHandler(this.button_sikayet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(255, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 37);
            this.textBox1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(255, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 133);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(111, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ürün Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(123, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Şikayet Metni:";
            // 
            // button_alisveris_yap
            // 
            this.button_alisveris_yap.BackColor = System.Drawing.Color.Green;
            this.button_alisveris_yap.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.button_alisveris_yap.ForeColor = System.Drawing.Color.White;
            this.button_alisveris_yap.Location = new System.Drawing.Point(407, 385);
            this.button_alisveris_yap.Name = "button_alisveris_yap";
            this.button_alisveris_yap.Size = new System.Drawing.Size(124, 53);
            this.button_alisveris_yap.TabIndex = 19;
            this.button_alisveris_yap.Text = "Alışverişe Geri Dön!";
            this.button_alisveris_yap.UseVisualStyleBackColor = false;
            this.button_alisveris_yap.Click += new System.EventHandler(this.button_alisveris_yap_Click);
            // 
            // Sikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_alisveris_yap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_sikayet);
            this.Controls.Add(this.label1);
            this.Name = "Sikayet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sikayet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_sikayet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_alisveris_yap;
    }
}