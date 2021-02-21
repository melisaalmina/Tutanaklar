using DevExpress.XtraBars;
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
    public partial class FrmAnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        frmTutanakEkle fr;
        private void btnTutanakEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new frmTutanakEkle();
                fr.MdiParent = this;
                fr.Show();

            }
           
        }
        Tutanak frm;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frm == null)
            {
                frm = new Tutanak();
                frm.MdiParent = this;
                frm.Show();

            }
        }
    }
}