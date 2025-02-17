using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace POS
{
    internal class connectDB
    {
        public static SqlConnection ConnectMiniMart()
        {
            string server = "WIRA2004\\SQLEXPRESS";
            string db = "MiniMart";

            string conStr = string.Format("Data Source={0};Initial Catalog={1};" + "Integrated Security=True;Encrypt=False", server, db);


            SqlConnection conn = new SqlConnection(conStr);

            conn.Open();
            return conn;
        }
    }
}
