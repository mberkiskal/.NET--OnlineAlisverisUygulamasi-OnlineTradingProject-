namespace Proje
{
    partial class AnaAlisveris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gecmis_siparis = new System.Windows.Forms.Button();
            this.button_sepetim = new System.Windows.Forms.Button();
            this.button_anasayfaya_don = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunnlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje1DataSet3 = new Proje.proje1DataSet3();
            this.urunnlerTableAdapter = new Proje.proje1DataSet3TableAdapters.urunnlerTableAdapter();
            this.richTextBox_urun_aciklamasi = new System.Windows.Forms.RichTextBox();
            this.textBox_urun_fiyati = new System.Windows.Forms.TextBox();
            this.textBox_urun_adi = new System.Windows.Forms.TextBox();
            this.textBox_urun_id = new System.Windows.Forms.TextBox();
            this.button_sepete_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunnlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gecmis_siparis
            // 
            this.button_gecmis_siparis.BackColor = System.Drawing.Color.Bisque;
            this.button_gecmis_siparis.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_gecmis_siparis.Location = new System.Drawing.Point(12, 185);
            this.button_gecmis_siparis.Name = "button_gecmis_siparis";
            this.button_gecmis_siparis.Size = new System.Drawing.Size(122, 73);
            this.button_gecmis_siparis.TabIndex = 11;
            this.button_gecmis_siparis.Text = "Geçmiş Siparişlerim";
            this.button_gecmis_siparis.UseVisualStyleBackColor = false;
            this.button_gecmis_siparis.Click += new System.EventHandler(this.button_gecmis_siparis_Click);
            // 
            // button_sepetim
            // 
            this.button_sepetim.BackColor = System.Drawing.Color.Bisque;
            this.button_sepetim.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold);
            this.button_sepetim.Location = new System.Drawing.Point(12, 12);
            this.button_sepetim.Name = "button_sepetim";
            this.button_sepetim.Size = new System.Drawing.Size(122, 73);
            this.button_sepetim.TabIndex = 10;
            this.button_sepetim.Text = "Sepetim";
            this.button_sepetim.UseVisualStyleBackColor = false;
            this.button_sepetim.Click += new System.EventHandler(this.button_sepetim_Click_1);
            // 
            // button_anasayfaya_don
            // 
            this.button_anasayfaya_don.BackColor = System.Drawing.Color.Bisque;
            this.button_anasayfaya_don.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_anasayfaya_don.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_anasayfaya_don.Location = new System.Drawing.Point(12, 366);
            this.button_anasayfaya_don.Name = "button_anasayfaya_don";
            this.button_anasayfaya_don.Size = new System.Drawing.Size(122, 72);
            this.button_anasayfaya_don.TabIndex = 9;
            this.button_anasayfaya_don.Text = "Ana Sayfaya Dön";
            this.button_anasayfaya_don.UseVisualStyleBackColor = false;
            this.button_anasayfaya_don.Click += new System.EventHandler(this.button_anasayfaya_don_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Dosis", 7F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunadDataGridViewTextBoxColumn,
            this.urunaciklamaDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunnlerBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView1.Location = new System.Drawing.Point(157, 207);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urun_id";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadDataGridViewTextBoxColumn
            // 
            this.urunadDataGridViewTextBoxColumn.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.Name = "urunadDataGridViewTextBoxColumn";
            // 
            // urunaciklamaDataGridViewTextBoxColumn
            // 
            this.urunaciklamaDataGridViewTextBoxColumn.DataPropertyName = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.HeaderText = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.Name = "urunaciklamaDataGridViewTextBoxColumn";
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            // 
            // urunnlerBindingSource
            // 
            this.urunnlerBindingSource.DataMember = "urunnler";
            this.urunnlerBindingSource.DataSource = this.proje1DataSet3;
            // 
            // proje1DataSet3
            // 
            this.proje1DataSet3.DataSetName = "proje1DataSet3";
            this.proje1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunnlerTableAdapter
            // 
            this.urunnlerTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox_urun_aciklamasi
            // 
            this.richTextBox_urun_aciklamasi.Enabled = false;
            this.richTextBox_urun_aciklamasi.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.richTextBox_urun_aciklamasi.Location = new System.Drawing.Point(434, 117);
            this.richTextBox_urun_aciklamasi.Name = "richTextBox_urun_aciklamasi";
            this.richTextBox_urun_aciklamasi.Size = new System.Drawing.Size(224, 61);
            this.richTextBox_urun_aciklamasi.TabIndex = 23;
            this.richTextBox_urun_aciklamasi.Text = "";
            // 
            // textBox_urun_fiyati
            // 
            this.textBox_urun_fiyati.Enabled = false;
            this.textBox_urun_fiyati.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_fiyati.Location = new System.Drawing.Point(222, 117);
            this.textBox_urun_fiyati.Multiline = true;
            this.textBox_urun_fiyati.Name = "textBox_urun_fiyati";
            this.textBox_urun_fiyati.Size = new System.Drawing.Size(100, 32);
            this.textBox_urun_fiyati.TabIndex = 22;
            // 
            // textBox_urun_adi
            // 
            this.textBox_urun_adi.Enabled = false;
            this.textBox_urun_adi.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_adi.Location = new System.Drawing.Point(434, 52);
            this.textBox_urun_adi.Multiline = true;
            this.textBox_urun_adi.Name = "textBox_urun_adi";
            this.textBox_urun_adi.Size = new System.Drawing.Size(224, 35);
            this.textBox_urun_adi.TabIndex = 21;
            // 
            // textBox_urun_id
            // 
            this.textBox_urun_id.Enabled = false;
            this.textBox_urun_id.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_urun_id.Location = new System.Drawing.Point(222, 57);
            this.textBox_urun_id.Multiline = true;
            this.textBox_urun_id.Name = "textBox_urun_id";
            this.textBox_urun_id.Size = new System.Drawing.Size(100, 30);
            this.textBox_urun_id.TabIndex = 20;
            // 
            // button_sepete_ekle
            // 
            this.button_sepete_ekle.BackColor = System.Drawing.Color.Bisque;
            this.button_sepete_ekle.Font = new System.Drawing.Font("Dosis", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sepete_ekle.ForeColor = System.Drawing.Color.Black;
            this.button_sepete_ekle.Location = new System.Drawing.Point(688, 130);
            this.button_sepete_ekle.Name = "button_sepete_ekle";
            this.button_sepete_ekle.Size = new System.Drawing.Size(100, 48);
            this.button_sepete_ekle.TabIndex = 19;
            this.button_sepete_ekle.Text = "Sepete Gönder!";
            this.button_sepete_ekle.UseVisualStyleBackColor = false;
            this.button_sepete_ekle.Click += new System.EventHandler(this.button_sepete_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(159, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(175, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(379, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ürün:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dosis", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(354, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dosis", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(321, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "ÜRÜN BİLGİLERİ";
            // 
            // AnaAlisveris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_urun_aciklamasi);
            this.Controls.Add(this.textBox_urun_fiyati);
            this.Controls.Add(this.textBox_urun_adi);
            this.Controls.Add(this.textBox_urun_id);
            this.Controls.Add(this.button_sepete_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_gecmis_siparis);
            this.Controls.Add(this.button_sepetim);
            this.Controls.Add(this.button_anasayfaya_don);
            this.Name = "AnaAlisveris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaAlisveris";
            this.Load += new System.EventHandler(this.AnaAlisveris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunnlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_gecmis_siparis;
        private System.Windows.Forms.Button button_sepetim;
        private System.Windows.Forms.Button button_anasayfaya_don;
        private System.Windows.Forms.DataGridView dataGridView1;
        private proje1DataSet3 proje1DataSet3;
        private System.Windows.Forms.BindingSource urunnlerBindingSource;
        private proje1DataSet3TableAdapters.urunnlerTableAdapter urunnlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox_urun_aciklamasi;
        private System.Windows.Forms.TextBox textBox_urun_fiyati;
        private System.Windows.Forms.TextBox textBox_urun_adi;
        private System.Windows.Forms.TextBox textBox_urun_id;
        private System.Windows.Forms.Button button_sepete_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}