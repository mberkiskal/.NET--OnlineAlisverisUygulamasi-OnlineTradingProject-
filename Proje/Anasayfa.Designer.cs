namespace Proje
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.button_alisveris_yap = new System.Windows.Forms.Button();
            this.button_sepetim = new System.Windows.Forms.Button();
            this.button_gecmis_siparis = new System.Windows.Forms.Button();
            this.proje1DataSet2 = new Proje.proje1DataSet2();
            this.urunnlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunnlerTableAdapter = new Proje.proje1DataSet2TableAdapters.urunnlerTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunnlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_alisveris_yap
            // 
            this.button_alisveris_yap.BackColor = System.Drawing.Color.Bisque;
            this.button_alisveris_yap.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alisveris_yap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_alisveris_yap.Location = new System.Drawing.Point(12, 12);
            this.button_alisveris_yap.Name = "button_alisveris_yap";
            this.button_alisveris_yap.Size = new System.Drawing.Size(122, 73);
            this.button_alisveris_yap.TabIndex = 0;
            this.button_alisveris_yap.Text = "Alışveriş Yap!";
            this.button_alisveris_yap.UseVisualStyleBackColor = false;
            this.button_alisveris_yap.Click += new System.EventHandler(this.button_alisveris_yap_Click);
            // 
            // button_sepetim
            // 
            this.button_sepetim.BackColor = System.Drawing.Color.Bisque;
            this.button_sepetim.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_sepetim.Location = new System.Drawing.Point(12, 188);
            this.button_sepetim.Name = "button_sepetim";
            this.button_sepetim.Size = new System.Drawing.Size(122, 73);
            this.button_sepetim.TabIndex = 1;
            this.button_sepetim.Text = "Sepetim";
            this.button_sepetim.UseVisualStyleBackColor = false;
            this.button_sepetim.Click += new System.EventHandler(this.button_sepetim_Click);
            // 
            // button_gecmis_siparis
            // 
            this.button_gecmis_siparis.BackColor = System.Drawing.Color.Bisque;
            this.button_gecmis_siparis.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_gecmis_siparis.Location = new System.Drawing.Point(12, 364);
            this.button_gecmis_siparis.Name = "button_gecmis_siparis";
            this.button_gecmis_siparis.Size = new System.Drawing.Size(122, 73);
            this.button_gecmis_siparis.TabIndex = 3;
            this.button_gecmis_siparis.Text = "Geçmiş Siparişlerim";
            this.button_gecmis_siparis.UseVisualStyleBackColor = false;
            this.button_gecmis_siparis.Click += new System.EventHandler(this.button_gecmis_siparis_Click);
            // 
            // proje1DataSet2
            // 
            this.proje1DataSet2.DataSetName = "proje1DataSet2";
            this.proje1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunnlerBindingSource
            // 
            this.urunnlerBindingSource.DataMember = "urunnler";
            this.urunnlerBindingSource.DataSource = this.proje1DataSet2;
            // 
            // urunnlerTableAdapter
            // 
            this.urunnlerTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(688, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(331, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "EPİK OL\'A HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(685, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Müşteri Numaranız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(212, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "BENZERSİZ YILBAŞI FIRSATLARINI KAÇIRMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(310, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "HEMEN ALIŞVERİŞE BAŞLA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dosis", 50F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(163, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 91);
            this.label7.TabIndex = 23;
            this.label7.Text = "!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dosis", 50F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(704, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 91);
            this.label8.TabIndex = 24;
            this.label8.Text = "!";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_gecmis_siparis);
            this.Controls.Add(this.button_sepetim);
            this.Controls.Add(this.button_alisveris_yap);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunnlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_alisveris_yap;
        private System.Windows.Forms.Button button_sepetim;
        private System.Windows.Forms.Button button_gecmis_siparis;
        private proje1DataSet2 proje1DataSet2;
        private System.Windows.Forms.BindingSource urunnlerBindingSource;
        private proje1DataSet2TableAdapters.urunnlerTableAdapter urunnlerTableAdapter;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}