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

namespace Tutanaklar
{
    public partial class TutanakDetay : Form
    {
        public TutanakDetay()
        {
            InitializeComponent();
        }
        public string id;
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TutanakDetayTbl where TutanakId='" + id + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void TutanakDetay_Load(object sender, EventArgs e)
        {
            


            listele();
        }
    }
}
