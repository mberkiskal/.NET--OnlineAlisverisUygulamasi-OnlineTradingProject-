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
    public partial class AnaAlisveris : Form
    {
        public AnaAlisveris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");
       
       

        private void AnaAlisveris_Load(object sender, EventArgs e)
        {

            // TODO: Bu kod satırı 'proje1DataSet3.urunnler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunnlerTableAdapter.Fill(this.proje1DataSet3.urunnler);
           
        }

       

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_urun_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_urun_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox_urun_aciklamasi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_urun_fiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            

        }

        private void button_sepete_ekle_Click(object sender, EventArgs e)
        {

            Sepetim sepetim = new Sepetim();
            sepetim.id1 = textBox_urun_id.Text;
            sepetim.ad1 = textBox_urun_adi.Text;
            sepetim.aciklama1 = richTextBox_urun_aciklamasi.Text;
            sepetim.fiyat1 = textBox_urun_fiyati.Text;
            sepetim.Show();
            Hide();

         
        }

        private void button_anasayfaya_don_Click_1(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }

        private void button_sepetim_Click_1(object sender, EventArgs e)
        {
            Sepetim sepetim = new Sepetim();
            sepetim.Show();
            Hide();
        }

        private void button_bilgilerim_Click_1(object sender, EventArgs e)
        {
            Bilgilerim bilgilerim = new Bilgilerim();
            bilgilerim.Show();
            Hide();
        }

        private void button_gecmis_siparis_Click(object sender, EventArgs e)
        {
            GecmisSiparislerim gecmisSiparislerim = new GecmisSiparislerim();
            gecmisSiparislerim.Show();
            Close();
        }
    }
}
