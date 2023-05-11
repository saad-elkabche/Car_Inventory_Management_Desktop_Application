using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisonVoiApp
{
    class Connection
    {
         static string serverName = @"DESKTOP-BLMEKEU\MSSQLSERVER1";
        public static string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        public static SqlConnection con = new SqlConnection($@"Data Source={serverName};Initial Catalog=MaisonAuto;Integrated Security=True");
        public static void close_connection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
