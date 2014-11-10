using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InstituteMS
{
    class DBConnect
    {
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public string dbName = "IMS";
            public DBConnect(){
                conn = new MySqlConnection();
                cmd = new MySqlCommand();

                conn.ConnectionString = "server=localhost;password=;user id=root;database=ims";
                cmd.Connection = conn;
        }
            public void checkConn()
            {
                if (conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                else  {
                    conn.Close();
                }
            }
    }
}
