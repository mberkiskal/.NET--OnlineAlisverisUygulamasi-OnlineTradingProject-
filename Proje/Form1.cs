using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Telefon Numaranızı Giriniz";
            textBox2.Text = "Sifrenizi Giriniz";
            textBox1.ForeColor = Color.LightGray;
            textBox2.ForeColor = Color.LightGray;

        }

        private void button_kayitol_Click(object sender, EventArgs e)
        {
            KayıtOl kayıtol = new KayıtOl();
            kayıtol.Show();
            Hide();
            
        }
        bool isThere;
       
        private void button_GirisYap_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
               
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                string girisTelNo = textBox1.Text;
                string girisSifre = textBox2.Text;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select* from kayıtTutma", baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (girisTelNo == reader["telefon_no"].ToString().TrimEnd() && girisSifre == reader["sifre"].ToString().TrimEnd())
                    {
                        isThere = true;
                        break;

                    }
                    else
                    {

                        isThere = false;
                    }
                }

                baglanti.Close();

                if (isThere)
                {
                    Anasayfa fr = new Anasayfa();
                    fr.deneme = textBox1.Text;
                    fr.Show();
                    Hide();

                }
                else
                {

                    MessageBox.Show("Giriş yapamadınız. Lütfen bilgilerinizi kontrol edip tekrar deneyin!");

                }

            }
           
            
        }
       
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Telefon Numaranızı Giriniz")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Telefon Numaranızı Giriniz";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Sifrenizi Giriniz")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Sifrenizi Giriniz";
                textBox2.ForeColor = Color.LightGray;
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
