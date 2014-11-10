using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InstituteMS
{
    class TeachersPayments:Payments
    {
        DBConnect db = new DBConnect();
        private float toInsAmount;
        private float fromInsAmount;
        private int teaPayID;
        int check;
        public int teaID;
        public string payType;
        public MySqlDataReader read;


        public void MainPayments()
        {
            if (-1 == checkCurrentPayments())
            {
                SaveTeaPayments();
                teaPayID = GetLastPayments();
                if (payType == "A")
                {
                    ToInsPayments();
                }
                else if(payType == "B"){
                    FromInsPayments();
                }
            }
            else {
                teaPayID = checkCurrentPayments();
                if (payType == "A") {
                    ToInsPayments();
                }
                else if (payType == "B") {
                    FromInsPayments();
                }
            }
        
        
        }
        public void ToInsPayments() {
        
                db.cmd.CommandText = "INSERT INTO " + db.dbName + ".TeaToInstittute(teaPayID,amount,date) VALUES('" + teaPayID + "','" + amount + "','" + payDate + "')";
                db.checkConn();
                check = db.cmd.ExecuteNonQuery();
                if (check == 1)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not saved");
                }
                db.checkConn();
            
        }
        public void FromInsPayments(){
            db.cmd.CommandText = "INSERT INTO " + db.dbName + ".TeaFromInstitute(teaPayID,amount,date) VALUES('" + teaPayID + "','" + amount + "','" + payDate + "')";
            db.checkConn();
            check = db.cmd.ExecuteNonQuery();
            if (check == 1)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not saved");
            }
            db.checkConn();
        }
        public int checkCurrentPayments() {
           
            db.cmd.CommandText = "SELECT teacPayID FROM " + db.dbName + ".TeachersPayments WHERE month='"+month+"' AND year ='"+year+"' AND teacID='"+teaID+"'";
            db.checkConn();
            read = db.cmd.ExecuteReader();
            read.Read();
            if (read.HasRows)
            {
               teaPayID = int.Parse(read["teacPayID"].ToString());
            }
            else {
                teaPayID = -1;
            }
            db.checkConn();              
            return teaPayID;
        }

        public void SaveTeaPayments() {
            int pid = GetLastPayments() + 1;
            db.cmd.CommandText = "INSERT INTO " + db.dbName + ".TeachersPayments(teacpayid,month,year,teacID) VALUES('"+pid+"','"+month+"','"+year+"','"+teaID+"')";
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        
        }
        public int GetLastPayments() {
            db.cmd.CommandText = "SELECT MAX(teacpayid) FROM " + db.dbName + ".TeachersPayments";
            db.checkConn();
            int maxPayID =int.Parse( db.cmd.ExecuteScalar().ToString());
            db.checkConn();
            return maxPayID;
        }
        public void SetValues(int teaID,string payType,int month,int year,float amount) {
            this.teaID = teaID;
            this.payType = payType;
            this.month = month;
            this.year = year;
            this.amount = amount;
        
        }
        
    }
}
