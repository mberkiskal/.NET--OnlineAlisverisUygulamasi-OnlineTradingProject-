namespace Proje
{
    partial class GecmisSiparislerim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_anasayfaya_don = new System.Windows.Forms.Button();
            this.button_sepetim = new System.Windows.Forms.Button();
            this.button_alisveris_yap = new System.Windows.Forms.Button();
            this.button_sikayet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet11 = new Proje.proje1DataSet11();
            this.siparisTableAdapter = new Proje.proje1DataSet11TableAdapters.siparisTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.musteriidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uruidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisdurumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet12 = new Proje.proje1DataSet12();
            this.siparisTableAdapter1 = new Proje.proje1DataSet12TableAdapters.siparisTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.proje1DataSet13 = new Proje.proje1DataSet13();
            this.siparisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisTableAdapter2 = new Proje.proje1DataSet13TableAdapters.siparisTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_anasayfaya_don
            // 
            this.button_anasayfaya_don.BackColor = System.Drawing.Color.Bisque;
            this.button_anasayfaya_don.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_anasayfaya_don.Location = new System.Drawing.Point(12, 365);
            this.button_anasayfaya_don.Name = "button_anasayfaya_don";
            this.button_anasayfaya_don.Size = new System.Drawing.Size(122, 73);
            this.button_anasayfaya_don.TabIndex = 7;
            this.button_anasayfaya_don.Text = "Ana Sayfaya Dön";
            this.button_anasayfaya_don.UseVisualStyleBackColor = false;
            this.button_anasayfaya_don.Click += new System.EventHandler(this.button_gecmis_siparis_Click);
            // 
            // button_sepetim
            // 
            this.button_sepetim.BackColor = System.Drawing.Color.Bisque;
            this.button_sepetim.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_sepetim.Location = new System.Drawing.Point(12, 182);
            this.button_sepetim.Name = "button_sepetim";
            this.button_sepetim.Size = new System.Drawing.Size(122, 73);
            this.button_sepetim.TabIndex = 6;
            this.button_sepetim.Text = "Sepetim";
            this.button_sepetim.UseVisualStyleBackColor = false;
            this.button_sepetim.Click += new System.EventHandler(this.button_sepetim_Click);
            // 
            // button_alisveris_yap
            // 
            this.button_alisveris_yap.BackColor = System.Drawing.Color.Bisque;
            this.button_alisveris_yap.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alisveris_yap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_alisveris_yap.Location = new System.Drawing.Point(12, 12);
            this.button_alisveris_yap.Name = "button_alisveris_yap";
            this.button_alisveris_yap.Size = new System.Drawing.Size(122, 73);
            this.button_alisveris_yap.TabIndex = 5;
            this.button_alisveris_yap.Text = "Alışveriş Yap!";
            this.button_alisveris_yap.UseVisualStyleBackColor = false;
            this.button_alisveris_yap.Click += new System.EventHandler(this.button_alisveris_yap_Click);
            // 
            // button_sikayet
            // 
            this.button_sikayet.BackColor = System.Drawing.Color.Red;
            this.button_sikayet.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_sikayet.ForeColor = System.Drawing.Color.White;
            this.button_sikayet.Location = new System.Drawing.Point(331, 406);
            this.button_sikayet.Name = "button_sikayet";
            this.button_sikayet.Size = new System.Drawing.Size(217, 32);
            this.button_sikayet.TabIndex = 10;
            this.button_sikayet.Text = "Sorununu Bizimle Paylaş!";
            this.button_sikayet.UseVisualStyleBackColor = false;
            this.button_sikayet.Click += new System.EventHandler(this.button_sikayet_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(315, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Herhangi bir sorun mu yaşıyorsunuz?";
            // 
            // siparisBindingSource
            // 
            this.siparisBindingSource.DataMember = "siparis";
            this.siparisBindingSource.DataSource = this.proje1DataSet11;
            // 
            // proje1DataSet11
            // 
            this.proje1DataSet11.DataSetName = "proje1DataSet11";
            this.proje1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisTableAdapter
            // 
            this.siparisTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.ColumnHeadersHeight = 20;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn1,
            this.uruidDataGridViewTextBoxColumn1,
            this.urunadDataGridViewTextBoxColumn1,
            this.urunaciklamaDataGridViewTextBoxColumn1,
            this.urunfiyatDataGridViewTextBoxColumn1,
            this.siparisdurumDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.siparisBindingSource2;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView2.Location = new System.Drawing.Point(140, 121);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(637, 257);
            this.dataGridView2.TabIndex = 13;
            // 
            // musteriidDataGridViewTextBoxColumn1
            // 
            this.musteriidDataGridViewTextBoxColumn1.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn1.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn1.Name = "musteriidDataGridViewTextBoxColumn1";
            this.musteriidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uruidDataGridViewTextBoxColumn1
            // 
            this.uruidDataGridViewTextBoxColumn1.DataPropertyName = "uru_id";
            this.uruidDataGridViewTextBoxColumn1.HeaderText = "uru_id";
            this.uruidDataGridViewTextBoxColumn1.Name = "uruidDataGridViewTextBoxColumn1";
            this.uruidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urunadDataGridViewTextBoxColumn1
            // 
            this.urunadDataGridViewTextBoxColumn1.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn1.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn1.Name = "urunadDataGridViewTextBoxColumn1";
            this.urunadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urunaciklamaDataGridViewTextBoxColumn1
            // 
            this.urunaciklamaDataGridViewTextBoxColumn1.DataPropertyName = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn1.HeaderText = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn1.Name = "urunaciklamaDataGridViewTextBoxColumn1";
            this.urunaciklamaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urunfiyatDataGridViewTextBoxColumn1
            // 
            this.urunfiyatDataGridViewTextBoxColumn1.DataPropertyName = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn1.HeaderText = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn1.Name = "urunfiyatDataGridViewTextBoxColumn1";
            this.urunfiyatDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // siparisdurumDataGridViewTextBoxColumn1
            // 
            this.siparisdurumDataGridViewTextBoxColumn1.DataPropertyName = "siparis_durum";
            this.siparisdurumDataGridViewTextBoxColumn1.HeaderText = "siparis_durum";
            this.siparisdurumDataGridViewTextBoxColumn1.Name = "siparisdurumDataGridViewTextBoxColumn1";
            this.siparisdurumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // siparisBindingSource1
            // 
            this.siparisBindingSource1.DataMember = "siparis";
            this.siparisBindingSource1.DataSource = this.proje1DataSet12;
            // 
            // proje1DataSet12
            // 
            this.proje1DataSet12.DataSetName = "proje1DataSet12";
            this.proje1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisTableAdapter1
            // 
            this.siparisTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(674, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Müşteri Numaranız:";
            // 
            // proje1DataSet13
            // 
            this.proje1DataSet13.DataSetName = "proje1DataSet13";
            this.proje1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisBindingSource2
            // 
            this.siparisBindingSource2.DataMember = "siparis";
            this.siparisBindingSource2.DataSource = this.proje1DataSet13;
            // 
            // siparisTableAdapter2
            // 
            this.siparisTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(599, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 30);
            this.button2.TabIndex = 41;
            this.button2.Text = "Geçmiş Siparişlerimi Görüntüle!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GecmisSiparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_sikayet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_anasayfaya_don);
            this.Controls.Add(this.button_sepetim);
            this.Controls.Add(this.button_alisveris_yap);
            this.Name = "GecmisSiparislerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GecmisSiparislerim";
            this.Load += new System.EventHandler(this.GecmisSiparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_anasayfaya_don;
        private System.Windows.Forms.Button button_sepetim;
        private System.Windows.Forms.Button button_alisveris_yap;
        private System.Windows.Forms.Button button_sikayet;
        private System.Windows.Forms.Label label1;
        private proje1DataSet11 proje1DataSet11;
        private System.Windows.Forms.BindingSource siparisBindingSource;
        private proje1DataSet11TableAdapters.siparisTableAdapter siparisTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private proje1DataSet12 proje1DataSet12;
        private System.Windows.Forms.BindingSource siparisBindingSource1;
        private proje1DataSet12TableAdapters.siparisTableAdapter siparisTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uruidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisdurumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private proje1DataSet13 proje1DataSet13;
        private System.Windows.Forms.BindingSource siparisBindingSource2;
        private proje1DataSet13TableAdapters.siparisTableAdapter siparisTableAdapter2;
        private System.Windows.Forms.Button button2;
    }
}