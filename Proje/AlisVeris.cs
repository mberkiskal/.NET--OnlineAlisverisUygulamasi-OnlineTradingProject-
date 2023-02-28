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
    public partial class AlisVeris : Form
    {
        public AlisVeris()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=proje1;Integrated Security=True");

        



        private void AlisVeris_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje1DataSet1.urunnler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunnlerTableAdapter.Fill(this.proje1DataSet1.urunnler);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
