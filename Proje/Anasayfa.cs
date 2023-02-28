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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
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

        private void button_gecmis_siparis_Click(object sender, EventArgs e)
        {
            GecmisSiparislerim gecmisSiparislerim = new GecmisSiparislerim();
            gecmisSiparislerim.Show();
            Close();
        }

        public string deneme;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje1DataSet2.urunnler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunnlerTableAdapter.Fill(this.proje1DataSet2.urunnler);

            textBox1.Text= deneme;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
