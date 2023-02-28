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
    public partial class OdemeIslemi : Form
    {
        public OdemeIslemi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
        private void button_sepete_don_Click(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            Close();
        }

        private void button_siparisi_tamamla_Click(object sender, EventArgs e)
        {

            if (maskedTextBox_musteri_num.Text == "" || maskedTextBox_kart_num.Text == "" || maskedTextBox_skt.Text == "" || maskedTextBox_cvc.Text == "" || textBox_ad_soyad.Text == "" || textBox_urun_id.Text == "" ||
                 maskedTextBox_musteri_num.Text == String.Empty || maskedTextBox_kart_num.Text == String.Empty || maskedTextBox_skt.Text == String.Empty || maskedTextBox_cvc.Text == String.Empty || textBox_ad_soyad.Text == String.Empty || textBox_urun_id.Text == String.Empty)
            {
                maskedTextBox_musteri_num.BackColor = Color.Red;
                maskedTextBox_kart_num.BackColor = Color.Red;
                maskedTextBox_skt.BackColor = Color.Red;
                maskedTextBox_cvc.BackColor = Color.Red;
                textBox_ad_soyad.BackColor = Color.Red;
                textBox_urun_id.BackColor = Color.Red;
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {

                SqlCommand komut = new SqlCommand("insert into odeme (musteri_id, kart_num, son_kul_tarihi, cvc, kart_isim_soyisim, urun_id) values  (@musteri_id, @kart_num, @son_kul_tarihi, @cvc, @kart_isim_soyisim, @urun_id)", baglanti);

                komut.Parameters.AddWithValue("@musteri_id", maskedTextBox_musteri_num.Text);
                komut.Parameters.AddWithValue("@kart_num", maskedTextBox_kart_num.Text);
                komut.Parameters.AddWithValue("@son_kul_tarihi", maskedTextBox_skt.Text);
                komut.Parameters.AddWithValue("@cvc", maskedTextBox_cvc.Text);
                komut.Parameters.AddWithValue("@kart_isim_soyisim", textBox_ad_soyad.Text);
                komut.Parameters.AddWithValue("@urun_id", textBox_urun_id.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Sipariş Tamamlandı!");
                GecmisSiparislerim gecmisSiparislerim = new GecmisSiparislerim();
                gecmisSiparislerim.Show();
                Close();
            }
        }

        
        
            
        
    }
}
