using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        const string connectionString = "Data Source=DESKTOP-RAH6IHC;Initial Catalog=QL_Spa;Integrated Security=True";
        protected SqlConnection conn = null;
        public void Moketnoi()
        {
            if (conn == null)
                conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void dongketnoi() {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
