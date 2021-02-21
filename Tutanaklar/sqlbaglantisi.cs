using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tutanaklar
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=ANKAMELISA\SQLEXPRESS;Initial Catalog=TutanakDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
