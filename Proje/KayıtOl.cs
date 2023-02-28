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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
        private void KayıtOl_Load_1(object sender, EventArgs e)
        {
            //textBox_ad.Text = "Adınızı Giriniz";
            //textBox_soyad.Text = "Soyadınızı Giriniz";
            //textBox_telefon_no.Text = "Telefon Numaranızı Giriniz";
            //textBox_adres.Text = "Adres Bilgilerinizi Giriniz";
            //textBox_eposta.Text = "E-postanızı Giriniz";
            //textBox_sifre.Text = "Sifrenizi Belirleyiniz";
            //textBox_ad.ForeColor = Color.LightGray;
            //textBox_soyad.ForeColor = Color.LightGray;
            //textBox_telefon_no.ForeColor = Color.LightGray;
            //textBox_adres.ForeColor = Color.LightGray;
            //textBox_eposta.ForeColor = Color.LightGray;
            //textBox_sifre.ForeColor = Color.LightGray;
        }

        private void textBox_ad_Enter(object sender, EventArgs e)
        {
            if (textBox_ad.Text == "Adınızı Giriniz")
            {
                textBox_ad.Text = "";
                textBox_ad.ForeColor = Color.Black;
            }
        }

        private void textBox_ad_Leave(object sender, EventArgs e)
        {
            if (textBox_ad.Text == "")
            {
                textBox_ad.Text = "Adınızı Giriniz";
                textBox_ad.ForeColor = Color.LightGray;
            }
        }

        private void button_hesabimi_olustur_Click_1(object sender, EventArgs e)
        {
            if (textBox_ad.Text == "" || textBox_soyad.Text == "" || textBox_telefon_no.Text == "" || textBox_adres.Text == "" || textBox_sifre.Text == "" ||
                textBox_ad.Text == String.Empty || textBox_soyad.Text == String.Empty || textBox_telefon_no.Text == String.Empty || textBox_sifre.Text == String.Empty)
            {
                textBox_ad.BackColor = Color.Red;
                textBox_soyad.BackColor = Color.Red;
                textBox_telefon_no.BackColor = Color.Red;
                textBox_adres.BackColor = Color.Red;
                textBox_sifre.BackColor = Color.Red;
               
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into kayıtTutma (ad, soyad, telefon_no, adres, eposta, sifre) values  (@ad, @soyad, @telefon_no, @adres, @eposta, @sifre)", baglanti);

                komut.Parameters.AddWithValue("@ad", textBox_ad.Text);
                komut.Parameters.AddWithValue("@soyad", textBox_soyad.Text);
                komut.Parameters.AddWithValue("@telefon_no", textBox_telefon_no.Text);
                komut.Parameters.AddWithValue("@adres", textBox_adres.Text);
                komut.Parameters.AddWithValue("@eposta", textBox_eposta.Text);
                komut.Parameters.AddWithValue("@sifre", textBox_sifre.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");


                Form1 hesabimiOlustur = new Form1();
                hesabimiOlustur.Show();
                Hide();

            }
                
        }


        private void textBox_soyad_Enter(object sender, EventArgs e)
        {
            if (textBox_soyad.Text == "Soyadınızı Giriniz")
            {
                textBox_soyad.Text = "";
                textBox_soyad.ForeColor = Color.Black;
            }
        }

        private void textBox_soyad_Leave(object sender, EventArgs e)
        {
            if (textBox_soyad.Text == "")
            {
                textBox_soyad.Text = "Soyadınızı Giriniz";
                textBox_soyad.ForeColor = Color.LightGray;
            }
        }

        private void textBox_telefon_no_Enter(object sender, EventArgs e)
        {
            if (textBox_telefon_no.Text == "Telefon Numaranızı Giriniz")
            {
                textBox_telefon_no.Text = "";
                textBox_telefon_no.ForeColor = Color.Black;
            }
        }

        private void textBox_telefon_no_Leave(object sender, EventArgs e)
        {
            if (textBox_telefon_no.Text == "")
            {
                textBox_telefon_no.Text = "Telefon Numaranızı Giriniz";
                textBox_telefon_no.ForeColor = Color.LightGray;
            }
        }

        private void textBox_adres_Enter(object sender, EventArgs e)
        {
            if (textBox_adres.Text == "Adres Bilgilerinizi Giriniz")
            {
                textBox_adres.Text = "";
                textBox_adres.ForeColor = Color.Black;
            }
        }

        private void textBox_adres_Leave(object sender, EventArgs e)
        {
            if (textBox_adres.Text == "")
            {
                textBox_adres.Text = "Adres Bilgilerinizi Giriniz";
                textBox_adres.ForeColor = Color.LightGray;
            }
        }

        private void textBox_eposta_Enter(object sender, EventArgs e)
        {
            if (textBox_eposta.Text == "E-postanızı Giriniz")
            {
                textBox_eposta.Text = "";
                textBox_eposta.ForeColor = Color.Black;
            }
        }

        private void textBox_eposta_Leave(object sender, EventArgs e)
        {
            if (textBox_eposta.Text == "")
            {
                textBox_eposta.Text = "E-postanızı Giriniz";
                textBox_eposta.ForeColor = Color.LightGray;
            }
        }

        private void textBox_sifre_Enter(object sender, EventArgs e)
        {
            if (textBox_sifre.Text == "Sifrenizi Belirleyiniz")
            {
                textBox_sifre.Text = "";
                textBox_sifre.ForeColor = Color.Black;
            }
        }

        private void textBox_sifre_Leave(object sender, EventArgs e)
        {
            if (textBox_sifre.Text == "")
            {
                textBox_sifre.Text = "Sifrenizi Belirleyiniz";
                textBox_sifre.ForeColor = Color.LightGray;
            }
        }
    }
}
