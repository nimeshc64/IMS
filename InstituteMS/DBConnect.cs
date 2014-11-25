using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace InstituteMS
{
    class DBConnect
    {
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader read;
        public DataTable table;
        public MySqlDataAdapter adp;
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
            
            int check;
            public void DMLQuery(string query,int type) {
                try
                {
                    cmd.CommandText = query;
                    checkConn();
                    check = cmd.ExecuteNonQuery();
                    checkConn();

                    if (check == 1 && type == 1)
                    {
                        MessageBox.Show("Saved Success");
                    }
                    else if (check == 1 && type == 2)
                    {
                        MessageBox.Show("Modify Success");
                    }
                    else if (check == 1 && type == 3)
                    {
                        MessageBox.Show("Delete Success");
                    }
                    else if (check != 1 && type == 1)
                    {
                        MessageBox.Show("Not saved");
                    }
                    else if (check != 1 && type == 1)
                    {
                        MessageBox.Show("Not Modified");
                    }
                    else if (check != 1 && type == 1)
                    {
                        MessageBox.Show("Not Deleted");
                    }
                }
                catch (MySqlException e) {
                    if (e.Number != 2627) {

                        MessageBox.Show("You Haved Already Used This ID. Please Use anotherone");
                    }
                }

                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
                
            }
            public MySqlDataReader DDLQuery(string query) {
                cmd.CommandText = query;
                checkConn();
                read = cmd.ExecuteReader();
                checkConn();
                return read;
            }
            public DataTable TableResult(string query) {
                cmd.CommandText = query;
                checkConn();
                adp = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adp.Fill(table);
                checkConn();

                return table;
            }
         public int maxId;
            public int GetLastID(string query) {
                cmd.CommandText = query;
                checkConn();
                maxId = int.Parse(cmd.ExecuteScalar().ToString());
                checkConn();
                    
                return maxId;
            }
    }
}
