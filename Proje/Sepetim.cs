using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class Sepetim : Form
    {
        public Sepetim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
        private void button_alisveris_yap_Click(object sender, EventArgs e)
        {

            AnaAlisveris alisveris = new AnaAlisveris();
            alisveris.Show();
            Close();
        }

        private void button_sepetim_Click(object sender, EventArgs e)
        {

            Bilgilerim bilgilerim = new Bilgilerim();
            bilgilerim.Show();
            Close();
        }

        private void button_bilgilerim_Click(object sender, EventArgs e)
        {
            GecmisSiparislerim gecmisSiparislerim = new GecmisSiparislerim();
            gecmisSiparislerim.Show();
            Close();
        }

        private void button_anasayfaya_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }

        public string id1, ad1, aciklama1, fiyat1;

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox_musteri_id.Text == "" || textBox_musteri_id.Text == String.Empty)
            {
                textBox_musteri_id.BackColor = Color.Red;

                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into sepetim (musteri_id, uru_id, urun_ad, urun_aciklama, urun_fiyat) values  (@musteri_id, @uru_id, @urun_ad, @urun_aciklama, @urun_fiyat)", baglanti);

                komut.Parameters.AddWithValue("@musteri_id", textBox_musteri_id.Text);
                komut.Parameters.AddWithValue("@uru_id", textBox_urun_id_sepet.Text);
                komut.Parameters.AddWithValue("@urun_ad", textBox_urun_adi_sepet.Text);
                komut.Parameters.AddWithValue("@urun_aciklama", richTextBox_urun_aciklamasi_sepet.Text);
                komut.Parameters.AddWithValue("@urun_fiyat", textBox_urun_fiyati_sepet.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select uru_id, urun_ad, urun_aciklama, urun_fiyat from sepetim", baglanti);
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[0].HeaderText = "musteri_id";
                dataGridView1.Columns[1].HeaderText = "uru_id";
                dataGridView1.Columns[2].HeaderText = "urun_ad";
                dataGridView1.Columns[3].HeaderText = "urun_aciklama";
                dataGridView1.Columns[4].HeaderText = "urun_fiyat";
            }

        }
        private void button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBox_musteri_id.Text == "" || textBox_musteri_id.Text == String.Empty)
            {
                textBox_musteri_id.BackColor = Color.Red;


            }
            else
            {
                baglanti.Open();
                string kayit = "SELECT * from sepetim where musteri_id=@musteri_id";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@musteri_id", textBox_musteri_id.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }

        }
        private void Sepetim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje1DataSet10.sepetim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetimTableAdapter.Fill(this.proje1DataSet10.sepetim);
            // TODO: Bu kod satırı 'proje1DataSet9.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter3.Fill(this.proje1DataSet9.sepet);

            this.dataGridView1.Columns[0].Visible = false;
            dataGridView1.DataSource = yenile();

            textBox_urun_id_sepet.Text = id1;
            textBox_urun_adi_sepet.Text = ad1;
            richTextBox_urun_aciklamasi_sepet.Text = aciklama1;
            textBox_urun_fiyati_sepet.Text = fiyat1;

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from sepetim where musteri_id=@musteri_id";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", textBox_musteri_id.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into siparis (musteri_id, uru_id, urun_ad, urun_aciklama, urun_fiyat) values  (@musteri_id, @uru_id, @urun_ad, @urun_aciklama, @urun_fiyat)", baglanti);

            komut.Parameters.AddWithValue("@musteri_id", textBox_musteri_id.Text);
            komut.Parameters.AddWithValue("@uru_id", textBox_urun_id_sepet.Text);
            komut.Parameters.AddWithValue("@urun_ad", textBox_urun_adi_sepet.Text);
            komut.Parameters.AddWithValue("@urun_aciklama", richTextBox_urun_aciklamasi_sepet.Text);
            komut.Parameters.AddWithValue("@urun_fiyat", textBox_urun_fiyati_sepet.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select uru_id, urun_ad, urun_aciklama, urun_fiyat from sepetim", baglanti);
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderText = "musteri_id";
            dataGridView1.Columns[1].HeaderText = "uru_id";
            dataGridView1.Columns[2].HeaderText = "urun_ad";
            dataGridView1.Columns[3].HeaderText = "urun_aciklama";
            dataGridView1.Columns[4].HeaderText = "urun_fiyat";

        }

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepetim", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }
        private void button2_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("delete from sepetim where musteri_id ='" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Ödeme Bilgileriniz İçin Yönlendiriliyorsunuz!");

            dataGridView1.DataSource = yenile();
            GecmisSiparislerim fr = new GecmisSiparislerim();
            fr.deneme = textBox_musteri_id.Text;

            OdemeIslemi odeme = new OdemeIslemi();
            odeme.Show();
            Hide();



        }


    }
}
