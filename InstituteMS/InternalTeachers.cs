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
            teacId = teaID;
            teacFName = teaFName;
            teacLName = teaLName;
            teacNIC = teaNIC;
            teacContact = teaContact;
            this.teaAdd1 = teaAdd1;
            this.teaAdd2 = teaAdd2;
            this.teaAdd3 = teaAdd3;
            teacEmail = teaEmail;
            this.teaSubject = teaSubject;
        }
        public override void RegisterTeacher() {

<<<<<<< HEAD
            //try
            //{
            //   command = "INSERT INTO " + db.dbName + ".Teachers(teaID,fname,lname,nic,contact,address1,address2,address3,mail,subName) VALUES('" + this.teaID + "','" + this.teaFName + "','" + this.teaLName + "','" + this.teaNIC + "','" + this.teaContact + "','" + this.teaAdd1 + "','" + this.teaAdd2 + "','" + this.teaAdd3 + "','" + this.teaEmail + "','" + this.teaSubject + "')";
            //   db.dmlQuery(command, 1);
            //}
            //catch { 
=======
            try
            {
                command = "INSERT INTO " + db.dbName + ".Teachers(teaID,fname,lname,nic,contact,address1,address2,address3,mail,subName) VALUES('" + teacId + "','" + teacFName + "','" + teacLName + "','" + teacNIC + "','" + teacContact + "','" + this.teaAdd1 + "','" + this.teaAdd2 + "','" + this.teaAdd3 + "','" + teacEmail + "','" + this.teaSubject + "')";
               db.DMLQuery(command, 1);
            }
            catch { 
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a
            
            //}
        }
        public override void ModifyTeacher() {
<<<<<<< HEAD
            //try
            //{
            //   command = "UPDATE " + db.dbName + ".Teachers SET teaID='" + this.teaID + "',fname='" + this.teaFName + "',lname='" + this.teaLName + "',nic='" + this.teaNIC + "',contact='" + this.teaContact + "',address1='" + this.teaAdd1 + "',address2='" + this.teaAdd2 + "',address3='" + this.teaAdd3 + "',mail='" + this.teaEmail + "',subName='" + this.teaSubject + "' WHERE teaID='" + this.teaID + "'";
            //   db.dmlQuery(command, 2);
            //}
            //catch { 
=======
            try
            {
               command = "UPDATE " + db.dbName + ".Teachers SET teaID='" + teacId + "',fname='" + teacFName + "',lname='" + teacLName + "',nic='" + teacNIC + "',contact='" + teacContact + "',address1='" + this.teaAdd1 + "',address2='" + this.teaAdd2 + "',address3='" + this.teaAdd3 + "',mail='" + teacEmail + "',subName='" + this.teaSubject + "' WHERE teaID='" + teacId+ "'";
               db.DMLQuery(command, 2);
            }
            catch { 
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a
            
            //}
        }
        public void DeleteTeacher() { 
        
        
        }
       
        public void SearchTeacher()
        {
            try
            {
                command = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + teacId + "'";
                DataTable teaTable = db.TableResult(command);
                teacFName = teaTable.Rows[0][1].ToString();
                teacLName = teaTable.Rows[0][2].ToString();
                teacNIC = teaTable.Rows[0][3].ToString();
                teacContact = teaTable.Rows[0][4].ToString();
                teaAdd1 = teaTable.Rows[0][5].ToString();
                teaAdd2 = teaTable.Rows[0][6].ToString();
                teaAdd3 = teaTable.Rows[0][7].ToString();
                teacEmail = teaTable.Rows[0][8].ToString();
                teaSubject = teaTable.Rows[0][9].ToString();
            }
            catch { 
                
            }
        }
       

<<<<<<< HEAD
       // public DataTable ReportAllDetails()
      //  { 
      // //     command = "SELECT *FROM "+db.dbName+".Teachers";
      //   //   return db.tableResult(command);
=======
        public DataTable ReportAllDetails()
        {
            command = "SELECT teaid,CONCAT(fname,' ',lname)AS Name ,nic ,contact , CONCAT(address1,' ,',address2,' ,',address3) As Address,mail As EMail,subname AS SubjectName FROM "+db.dbName+".Teachers";
            return db.TableResult(command);
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a
           
      //  }

<<<<<<< HEAD
      ////  public DataTable ReportSubject(string subj) {
      ////      command = "SELECT *FROM " + db.dbName + ".Teachers WHERE subName='" +subj+ "'";
      //  //    return db.tableResult(command);
      //  }
=======
        public DataTable ReportSubject(string subj) {
            command = "SELECT cls.classid,cls.day,cls.starttime,cls.endtime,cls.batch,cls.fee,CONCAT(tea.fname,' ',tea.lname)AS Name FROM " + db.dbName + ".Teachers tea," + db.dbName + ".class cls  WHERE subName='" + subj + "'";
            return db.TableResult(command);
        }
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a

      //  //public DataTable getTeachers()
      // // {

<<<<<<< HEAD
      // //     command = "SELECT teaid,fname,lname FROM " + db.dbName + ".Teachers ";
      //     // return db.tableResult(command);
     //   }
=======
            command = "SELECT teaid As TeacherID,CONCAT(fname,' ',lname) As Name FROM " + db.dbName + ".Teachers ";
            return db.TableResult(command);
        }
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a

        public int GetLastTeachersID() {
            try
            {
                command = "SELECT MAX(teaid) FROM " + db.dbName + ".Teachers";
                return db.GetLastID(command);
            }
            catch
            {
                command = "SELECT MAX(teaid) FROM " + db.dbName + ".Teachers";
                return db.GetLastID(command);

            }
        }

        public DataTable GetSubjects() { 
            try{
                command = "SELECT DISTINCT subname FROM " + db.dbName + ".Teachers ";

                return db.TableResult(command);
            }
            catch{
                return null;
            }
        
        }
    }
}
