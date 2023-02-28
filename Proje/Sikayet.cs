using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Sikayet : Form
    {
        public Sikayet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");

        private void button_sikayet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into sikayetBilgileri (urun_id,sikayet_metni) values  (@urun_id, @sikayet_metni)", baglanti);

            komut.Parameters.AddWithValue("@urun_id", textBox1.Text);
            komut.Parameters.AddWithValue("@sikayet_metni", richTextBox1.Text);
            

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şikayetiniz Gönderildi!");

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }

        private void button_alisveris_yap_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
        
        
    }
}
