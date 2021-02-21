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
    public partial class Tutanak : DevExpress.XtraEditors.XtraForm
    {
        public Tutanak()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into IsverenTutanakTbl(TutanakNo,Tarih,Aciklama) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTutanakno.Text);
            komut.Parameters.AddWithValue("@p2", txtTarih.Text);
            komut.Parameters.AddWithValue("@p3", txtAciklama.Text);            
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Tutanak Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        TutanakDBEntities tb = new TutanakDBEntities();
        private void Tutanak_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn col1 = new DataGridViewComboBoxColumn();
            col1.Name = "PozId";
            col1.HeaderText = "PozId";
            col1.DataSource = tb.BirimFiyatTbl.ToList();
            col1.DisplayMember = "PozId";
            dataGridView1.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "PozNo";
            col2.HeaderText = "PozNo";
            dataGridView1.Columns.Add(col2);

        }

        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int t = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                //int t = Convert.ToInt32(e.ColumnIndex);
                var res = from x in tb.BirimFiyatTbl
                          where x.PozId.ToString() == t
                          select new { PozNo = x.PozNo };
                var s = res.FirstOrDefault();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = s.PozNo;
                
            }

        }

    }
}