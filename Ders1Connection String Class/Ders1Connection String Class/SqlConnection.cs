using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Ders1Connection_String_Class
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=veritabanı;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
