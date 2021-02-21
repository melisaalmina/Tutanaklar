using DevExpress.XtraEditors;
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
    public partial class frmTutanakEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmTutanakEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select TutanakNo,Tarih,Aciklama,Sebep,IsverenHakedisindekiDurumu,Tutar From IsverenTutanakTbl", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into IsverenTutanakTbl(TutanakNo,Tarih,Aciklama,Sebep,IsverenHakedisindekiDurumu) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTutanakno.Text);
            komut.Parameters.AddWithValue("@p2", txtTarih.Text);
            komut.Parameters.AddWithValue("@p3", txtAciklama.Text);
            komut.Parameters.AddWithValue("@p4", txtSebep.Text);
            komut.Parameters.AddWithValue("@p5", txtisverenhkdsdrm.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Tutanak Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

       

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTutanakEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            TutanakDetay fr = new TutanakDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.id = dr["TutanakNo"].ToString();
            }
            fr.Show();
        }
    }
}