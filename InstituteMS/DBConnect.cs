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
            public void dmlQuery(string query,int type) {
               
                cmd.CommandText = query;
                checkConn();
                check = cmd.ExecuteNonQuery();
                checkConn();

                if (check == 1 && type == 1) {
                    MessageBox.Show("Saved Success");
                }
                else if (check == 1 && type == 2) {
                    MessageBox.Show("Modify Success");
                }
                else if(check ==1 && type ==3){
                    MessageBox.Show("Delete Success");
                }
                else if (check != 1 && type == 1) {
                    MessageBox.Show("Not saved");
                }
                else if (check != 1 && type == 1) {
                    MessageBox.Show("Not Modified");
                } 
                else if(check !=1 && type == 1){
                    MessageBox.Show("Not Deleted");
                }
                
            }
            public MySqlDataReader ddlQuery(string query) {
                cmd.CommandText = query;
                checkConn();
                read = cmd.ExecuteReader();
                checkConn();
                return read;
            }
            public DataTable tableResult(string query) {
                cmd.CommandText = query;
                checkConn();
                adp = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adp.Fill(table);
                checkConn();

                return table;
            }
    }
}
