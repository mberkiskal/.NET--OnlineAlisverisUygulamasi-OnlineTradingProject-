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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class GecmisSiparislerim : Form
    {
        public GecmisSiparislerim()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
        DataTable tablo = new DataTable();

        SqlDataAdapter adtr = new SqlDataAdapter();
        internal string deneme;

        private void button_alisveris_yap_Click(object sender, EventArgs e)
        {

            AnaAlisveris alisveris = new AnaAlisveris();
            alisveris.Show();
            Close();
        }

        private void button_sepetim_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            Close();
        }

        private void button_bilgilerim_Click(object sender, EventArgs e)
        {
            Bilgilerim bilgilerim = new Bilgilerim();
            bilgilerim.Show();
            Close();
        }

        private void button_gecmis_siparis_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
        private void button_sikayet_Click(object sender, EventArgs e)
        {

            Sikayet sikayet = new Sikayet();
            sikayet.Show();
            Close();
        }

        private void button_sikayet_Click_1(object sender, EventArgs e)
        {
            Sikayet sikayet = new Sikayet();
            sikayet.Show();
            Close();
        }
        
        private void GecmisSiparislerim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje1DataSet13.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter2.Fill(this.proje1DataSet13.siparis);
            // TODO: Bu kod satırı 'proje1DataSet12.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter1.Fill(this.proje1DataSet12.siparis);
            // TODO: Bu kod satırı 'proje1DataSet11.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.proje1DataSet11.siparis);

            this.dataGridView2.Columns[0].Visible = false;
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from siparis", baglanti);

            adtr.Fill(tablo);

            dataGridView2.DataSource = tablo;

            adtr.Dispose();

            baglanti.Close();

            dataGridView2.Columns[0].HeaderText = "musteri_id";

            dataGridView2.Columns[1].HeaderText = "uru_id";

            dataGridView2.Columns[2].HeaderText = "urun_ad";

            dataGridView2.Columns[3].HeaderText = "urun_aciklama";

            dataGridView2.Columns[4].HeaderText = "urun_fiyat";

            dataGridView2.Columns[5].HeaderText = "siparis_durum";




        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            tablo.Clear();

            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from siparis Where musteri_id='" + textBox1.Text + "'", baglanti);

            adtr.Fill(tablo);

            dataGridView2.DataSource = tablo;

            adtr.Dispose();

            baglanti.Close();

            
        }
    }

}
