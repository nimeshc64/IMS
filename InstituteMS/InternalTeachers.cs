using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace InstituteMS
{
    class InternalTeachers:Teachers
    {
        
        public MySqlDataReader read;
        public DataTable dTable;
        public string command;
       
        int checkStatus;
        public ArrayList list = new ArrayList();
        DBConnect db = new DBConnect();
        
        public void setTeacherValues(int teaID,string teaFName,string teaLName,string teaNIC, string teaContact,string teaAdd1,string teaAdd2,string teaAdd3,string teaEmail,string teaSubject) {
            this.teaID = teaID;
            this.teaFName = teaFName;
            this.teaLName = teaLName;
            this.teaNIC = teaNIC;
            this.teaContact = teaContact;
            this.teaAdd1 = teaAdd1;
            this.teaAdd2 = teaAdd2;
            this.teaAdd3 = teaAdd3;
            this.teaEmail = teaEmail;
            this.teaSubject = teaSubject;
        }
        public override void RegisterTeacher() {

            try
            {
                db.cmd.CommandText = "INSERT INTO " + db.dbName + ".Teachers(teaID,fname,lname,nic,contact,address1,address2,address3,mail,subName) VALUES('" + this.teaID + "','" + this.teaFName + "','" + this.teaLName + "','" + this.teaNIC + "','" + this.teaContact + "','" + this.teaAdd1 + "','" + this.teaAdd2 + "','" + this.teaAdd3 + "','" + this.teaEmail + "','" + this.teaSubject + "')";
                db.checkConn();
                checkStatus = db.cmd.ExecuteNonQuery();
                db.checkConn();
                if (checkStatus == 1)
                {
                    MessageBox.Show("Save");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch { 
            
            }
        }
        public override void ModifyTeacher() {
            try
            {
                db.cmd.CommandText = "UPDATE " + db.dbName + ".Teachers SET teaID='" + this.teaID + "',fname='" + this.teaFName + "',lname='" + this.teaLName + "',nic='" + this.teaNIC + "',contact='" + this.teaContact + "',address1='" + this.teaAdd1 + "',address2='" + this.teaAdd2 + "',address3='" + this.teaAdd3 + "',mail='" + this.teaEmail + "',subName='" + this.teaSubject + "' WHERE teaID='" + this.teaID + "'";
                db.checkConn();
                checkStatus = db.cmd.ExecuteNonQuery();
                db.checkConn();
                if (checkStatus == 1)
                {
                    MessageBox.Show("Updated");
                }
                else
                    MessageBox.Show("not Updated");
            }
            catch { 
            
            }
        }
        public void DeleteTeacher() { 
        
        
        }
        
        public ArrayList SearchTeacher(string teaid)
        {
            
                db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + teaid + "'";
                db.checkConn();
                read = db.cmd.ExecuteReader();
                read.Read();
                
                    for (int c = 0; c < read.FieldCount; c++)
                    {
                        list.Add(read[c].ToString());
                    }
               
                db.checkConn();
                return list;
            
          
        
        }
      
        //public Tuple <string , string, string>SearchTeacher2() {
        //    Teacher teaFor = new Teacher();
        //    db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + this.teaID + "'";
        //    db.checkConn();
        //    MySqlDataReader read = db.cmd.ExecuteReader();
        //    read.Read();
        //        string a = read["teaID"].ToString();
        //        string b = read["lname"].ToString();
        //        string c = read["contact"].ToString();
        //    db.checkConn();
        //    return new Tuple<string, string, string>(a, b, c);
        //}

        public DataTable ReportAllDetails()
        { 
            command = "SELECT *FROM "+db.dbName+".Teachers";
            db.cmd.CommandText = command;
            db.checkConn();
            MySqlDataAdapter dataAdap = new MySqlDataAdapter(db.cmd);
            dTable =new DataTable ();
            dataAdap.Fill(dTable);
            db.checkConn();

            return dTable;
        
        }

        public DataTable ReportSubject(string subj) {
            command = "SELECT *FROM " + db.dbName + ".Teachers WHERE subName='" +subj+ "'";
            db.cmd.CommandText = command;
            db.checkConn();
            MySqlDataAdapter dataAdap=new MySqlDataAdapter (db.cmd);
            dTable =new DataTable();
            dataAdap.Fill(dTable);
            db.checkConn();

            return dTable;
        }
        public DataTable getTeachers()
        {

            command = "SELECT teaid,fname,lname FROM " + db.dbName + ".Teachers ";
            db.cmd.CommandText = command;
            db.checkConn();
            MySqlDataAdapter dataAdap = new MySqlDataAdapter(db.cmd);
            dTable = new DataTable();
            dataAdap.Fill(dTable);
            db.checkConn();

            return dTable;
        }

        public int GetLastTeachersID() {
            command = "SELECT MAX(teaid) FROM "+db.dbName+".Teachers";
            db.cmd.CommandText = command;
            db.checkConn();
            int max = int.Parse(db.cmd.ExecuteScalar().ToString());
            db.checkConn();

            return max;
        }
    }
}
