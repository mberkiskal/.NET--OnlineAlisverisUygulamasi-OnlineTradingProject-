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
    public partial class Bilgilerim : Form
    {
        public Bilgilerim()
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

            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            Close();
        }

        private void button_bilgilerim_Click(object sender, EventArgs e)
        {
            GecmisSiparislerim gecmisSiparislerim = new GecmisSiparislerim();
            gecmisSiparislerim.Show();
            Close();
        }

        private void button_anasayfaya_don_Click(object sender, EventArgs e)
        {

            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
        public string deneme1;
        private void Bilgilerim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje1DataSet5.kayıtTutma' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayıtTutmaTableAdapter.Fill(this.proje1DataSet5.kayıtTutma);
            textBox13.Text = deneme1;

        }
    }
}
