namespace Proje
{
    partial class Sepetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_bilgilerim = new System.Windows.Forms.Button();
            this.button_anasayfaya = new System.Windows.Forms.Button();
            this.button_alisveris_yap = new System.Windows.Forms.Button();
            this.richTextBox_urun_aciklamasi_sepet = new System.Windows.Forms.RichTextBox();
            this.textBox_urun_id_sepet = new System.Windows.Forms.TextBox();
            this.textBox_urun_adi_sepet = new System.Windows.Forms.TextBox();
            this.textBox_urun_fiyati_sepet = new System.Windows.Forms.TextBox();
            this.textBox_musteri_id = new System.Windows.Forms.TextBox();
            this.sepetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet7 = new Proje.proje1DataSet7();
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet6 = new Proje.proje1DataSet6();
            this.sepetTableAdapter = new Proje.proje1DataSet6TableAdapters.sepetTableAdapter();
            this.sepetTableAdapter1 = new Proje.proje1DataSet7TableAdapters.sepetTableAdapter();
            this.proje1DataSet8 = new Proje.proje1DataSet8();
            this.sepetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sepetTableAdapter2 = new Proje.proje1DataSet8TableAdapters.sepetTableAdapter();
            this.proje1DataSet9 = new Proje.proje1DataSet9();
            this.sepetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sepetTableAdapter3 = new Proje.proje1DataSet9TableAdapters.sepetTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepetimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet10 = new Proje.proje1DataSet10();
            this.sepetimTableAdapter = new Proje.proje1DataSet10TableAdapters.sepetimTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // button_bilgilerim
            // 
            this.button_bilgilerim.BackColor = System.Drawing.Color.Bisque;
            this.button_bilgilerim.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_bilgilerim.Location = new System.Drawing.Point(12, 185);
            this.button_bilgilerim.Name = "button_bilgilerim";
            this.button_bilgilerim.Size = new System.Drawing.Size(122, 73);
            this.button_bilgilerim.TabIndex = 8;
            this.button_bilgilerim.Text = "Geçmiş Siparişlerim";
            this.button_bilgilerim.UseVisualStyleBackColor = false;
            this.button_bilgilerim.Click += new System.EventHandler(this.button_bilgilerim_Click);
            // 
            // button_anasayfaya
            // 
            this.button_anasayfaya.BackColor = System.Drawing.Color.Bisque;
            this.button_anasayfaya.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_anasayfaya.Location = new System.Drawing.Point(12, 365);
            this.button_anasayfaya.Name = "button_anasayfaya";
            this.button_anasayfaya.Size = new System.Drawing.Size(122, 73);
            this.button_anasayfaya.TabIndex = 7;
            this.button_anasayfaya.Text = "Ana Sayfaya Dön";
            this.button_anasayfaya.UseVisualStyleBackColor = false;
            this.button_anasayfaya.Click += new System.EventHandler(this.button_anasayfaya_Click);
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
            // richTextBox_urun_aciklamasi_sepet
            // 
            this.richTextBox_urun_aciklamasi_sepet.Enabled = false;
            this.richTextBox_urun_aciklamasi_sepet.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox_urun_aciklamasi_sepet.Location = new System.Drawing.Point(395, 84);
            this.richTextBox_urun_aciklamasi_sepet.Name = "richTextBox_urun_aciklamasi_sepet";
            this.richTextBox_urun_aciklamasi_sepet.Size = new System.Drawing.Size(255, 111);
            this.richTextBox_urun_aciklamasi_sepet.TabIndex = 28;
            this.richTextBox_urun_aciklamasi_sepet.Text = "";
            // 
            // textBox_urun_id_sepet
            // 
            this.textBox_urun_id_sepet.Enabled = false;
            this.textBox_urun_id_sepet.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_id_sepet.Location = new System.Drawing.Point(207, 83);
            this.textBox_urun_id_sepet.Name = "textBox_urun_id_sepet";
            this.textBox_urun_id_sepet.Size = new System.Drawing.Size(100, 24);
            this.textBox_urun_id_sepet.TabIndex = 25;
            // 
            // textBox_urun_adi_sepet
            // 
            this.textBox_urun_adi_sepet.Enabled = false;
            this.textBox_urun_adi_sepet.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_adi_sepet.Location = new System.Drawing.Point(207, 125);
            this.textBox_urun_adi_sepet.Name = "textBox_urun_adi_sepet";
            this.textBox_urun_adi_sepet.Size = new System.Drawing.Size(100, 24);
            this.textBox_urun_adi_sepet.TabIndex = 26;
            // 
            // textBox_urun_fiyati_sepet
            // 
            this.textBox_urun_fiyati_sepet.Enabled = false;
            this.textBox_urun_fiyati_sepet.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_fiyati_sepet.Location = new System.Drawing.Point(207, 172);
            this.textBox_urun_fiyati_sepet.Name = "textBox_urun_fiyati_sepet";
            this.textBox_urun_fiyati_sepet.Size = new System.Drawing.Size(100, 24);
            this.textBox_urun_fiyati_sepet.TabIndex = 27;
            // 
            // textBox_musteri_id
            // 
            this.textBox_musteri_id.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_musteri_id.Location = new System.Drawing.Point(685, 37);
            this.textBox_musteri_id.Name = "textBox_musteri_id";
            this.textBox_musteri_id.Size = new System.Drawing.Size(100, 24);
            this.textBox_musteri_id.TabIndex = 29;
            // 
            // sepetBindingSource1
            // 
            this.sepetBindingSource1.DataMember = "sepet";
            this.sepetBindingSource1.DataSource = this.proje1DataSet7;
            // 
            // proje1DataSet7
            // 
            this.proje1DataSet7.DataSetName = "proje1DataSet7";
            this.proje1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "sepet";
            this.sepetBindingSource.DataSource = this.proje1DataSet6;
            // 
            // proje1DataSet6
            // 
            this.proje1DataSet6.DataSetName = "proje1DataSet6";
            this.proje1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // sepetTableAdapter1
            // 
            this.sepetTableAdapter1.ClearBeforeFill = true;
            // 
            // proje1DataSet8
            // 
            this.proje1DataSet8.DataSetName = "proje1DataSet8";
            this.proje1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetBindingSource2
            // 
            this.sepetBindingSource2.DataMember = "sepet";
            this.sepetBindingSource2.DataSource = this.proje1DataSet8;
            // 
            // sepetTableAdapter2
            // 
            this.sepetTableAdapter2.ClearBeforeFill = true;
            // 
            // proje1DataSet9
            // 
            this.proje1DataSet9.DataSetName = "proje1DataSet9";
            this.proje1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetBindingSource3
            // 
            this.sepetBindingSource3.DataMember = "sepet";
            this.sepetBindingSource3.DataSource = this.proje1DataSet9;
            // 
            // sepetTableAdapter3
            // 
            this.sepetTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn,
            this.uruidDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.urunaciklamaDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sepetimBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView1.Location = new System.Drawing.Point(211, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uruidDataGridViewTextBoxColumn
            // 
            this.uruidDataGridViewTextBoxColumn.DataPropertyName = "uru_id";
            this.uruidDataGridViewTextBoxColumn.HeaderText = "uru_id";
            this.uruidDataGridViewTextBoxColumn.Name = "uruidDataGridViewTextBoxColumn";
            this.uruidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadDataGridViewTextBoxColumn
            // 
            this.urunadDataGridViewTextBoxColumn.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.Name = "urunadDataGridViewTextBoxColumn";
            this.urunadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunaciklamaDataGridViewTextBoxColumn
            // 
            this.urunaciklamaDataGridViewTextBoxColumn.DataPropertyName = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.HeaderText = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.Name = "urunaciklamaDataGridViewTextBoxColumn";
            this.urunaciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            this.urunfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sepetimBindingSource
            // 
            this.sepetimBindingSource.DataMember = "sepetim";
            this.sepetimBindingSource.DataSource = this.proje1DataSet10;
            // 
            // proje1DataSet10
            // 
            this.proje1DataSet10.DataSetName = "proje1DataSet10";
            this.proje1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetimTableAdapter
            // 
            this.sepetimTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(373, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 35;
            this.label5.Text = "ÜRÜN BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(144, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Numara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(160, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(162, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ürün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(682, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Müşteri Numaranız:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(325, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Açıklama:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(686, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 41;
            this.button1.Text = "Sepete Ekle!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(686, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 42;
            this.button2.Text = "Sipariş Ver!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_musteri_id);
            this.Controls.Add(this.richTextBox_urun_aciklamasi_sepet);
            this.Controls.Add(this.textBox_urun_fiyati_sepet);
            this.Controls.Add(this.textBox_urun_adi_sepet);
            this.Controls.Add(this.textBox_urun_id_sepet);
            this.Controls.Add(this.button_bilgilerim);
            this.Controls.Add(this.button_anasayfaya);
            this.Controls.Add(this.button_alisveris_yap);
            this.Name = "Sepetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.Sepetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_bilgilerim;
        private System.Windows.Forms.Button button_anasayfaya;
        private System.Windows.Forms.Button button_alisveris_yap;
        private System.Windows.Forms.RichTextBox richTextBox_urun_aciklamasi_sepet;
        private System.Windows.Forms.TextBox textBox_urun_id_sepet;
        private System.Windows.Forms.TextBox textBox_urun_adi_sepet;
        private System.Windows.Forms.TextBox textBox_urun_fiyati_sepet;
        private proje1DataSet6 proje1DataSet6;
        private System.Windows.Forms.BindingSource sepetBindingSource;
        private proje1DataSet6TableAdapters.sepetTableAdapter sepetTableAdapter;
        private proje1DataSet7 proje1DataSet7;
        private System.Windows.Forms.BindingSource sepetBindingSource1;
        private proje1DataSet7TableAdapters.sepetTableAdapter sepetTableAdapter1;
        private proje1DataSet8 proje1DataSet8;
        private System.Windows.Forms.BindingSource sepetBindingSource2;
        private proje1DataSet8TableAdapters.sepetTableAdapter sepetTableAdapter2;
        private proje1DataSet9 proje1DataSet9;
        private System.Windows.Forms.BindingSource sepetBindingSource3;
        private proje1DataSet9TableAdapters.sepetTableAdapter sepetTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private proje1DataSet10 proje1DataSet10;
        private System.Windows.Forms.BindingSource sepetimBindingSource;
        private proje1DataSet10TableAdapters.sepetimTableAdapter sepetimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox textBox_musteri_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}