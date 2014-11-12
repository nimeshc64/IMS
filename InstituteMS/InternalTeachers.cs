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
               command = "INSERT INTO " + db.dbName + ".Teachers(teaID,fname,lname,nic,contact,address1,address2,address3,mail,subName) VALUES('" + this.teaID + "','" + this.teaFName + "','" + this.teaLName + "','" + this.teaNIC + "','" + this.teaContact + "','" + this.teaAdd1 + "','" + this.teaAdd2 + "','" + this.teaAdd3 + "','" + this.teaEmail + "','" + this.teaSubject + "')";
               db.DMLQuery(command, 1);
            }
            catch { 
            
            }
        }
        public override void ModifyTeacher() {
            try
            {
               command = "UPDATE " + db.dbName + ".Teachers SET teaID='" + this.teaID + "',fname='" + this.teaFName + "',lname='" + this.teaLName + "',nic='" + this.teaNIC + "',contact='" + this.teaContact + "',address1='" + this.teaAdd1 + "',address2='" + this.teaAdd2 + "',address3='" + this.teaAdd3 + "',mail='" + this.teaEmail + "',subName='" + this.teaSubject + "' WHERE teaID='" + this.teaID + "'";
               db.DMLQuery(command, 2);
            }
            catch { 
            
            }
        }
        public void DeleteTeacher() { 
        
        
        }
        
        //public ArrayList SearchTeacher(string teaid)
        //{
            
        //        db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + teaid + "'";
        //        db.checkConn();
        //        read = db.cmd.ExecuteReader();
        //        read.Read();
                
        //            for (int c = 0; c < read.FieldCount; c++)
        //            {
        //                list.Add(read[c].ToString());
        //            }
               
        //        db.checkConn();
        //        return list;
            
          
        
        //}
        public DataTable SearchTeacher()
        {
            command = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + this.teaID + "'";
            return db.TableResult(command);
        }
       

        public DataTable ReportAllDetails()
        {
            command = "SELECT *From "+db.dbName+".Teachers";
            return db.TableResult(command);
           
        }

        public DataTable ReportSubject(string subj) {
            command = "SELECT cls.classid,cls.day,cls.starttime,cls.endtime,cls.batch,cls.fee,tea.fname,tea.lname FROM " + db.dbName + ".Teachers tea," + db.dbName + ".class cls  WHERE subName='" + subj + "'";
            return db.TableResult(command);
        }

        public DataTable getTeachers()
        {

            command = "SELECT teaid,fname,lname FROM " + db.dbName + ".Teachers ";
            return db.TableResult(command);
        }

        public int GetLastTeachersID() {
            command = "SELECT MAX(teaid) FROM "+db.dbName+".Teachers";
            return db.GetLastID(command);
        }
    }
}
