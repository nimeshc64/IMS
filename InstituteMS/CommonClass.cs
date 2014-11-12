using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;




namespace InstituteMS
{
    class CommonClass:Classes
    {
        DBConnect db = new DBConnect();
        private string command;
        DataTable dTable;


        public void RegisterClass() {
            command = "INSERT INTO "+db.dbName+".class(classid,day,starttime,endtime,batch,fee,teachid) VALUES('"+clsId+"','"+clsDay+"','"+clsStartTime+"','"+clsEndTime+"','"+clsBatch+"','"+clsFees+"','"+clsTeaId+"')";
            db.DMLQuery(command, 1);
        }

        public void DeleteClass() {
            command = "DELETE FROM "+db.dbName+".class WHERE classID='"+clsId+"'";
            db.DMLQuery(command, 3);
        }
        public void ModifyClass() {
            command = "UPDATE "+db.dbName+".class SET day='"+clsDay+"',starttime ='"+clsStartTime+"' ,endtime='"+clsEndTime+"', batch='"+clsBatch+"',fee ='"+clsFees+"',teachid ='"+clsTeaId+"' WHERE classID = '"+clsId+"' ";
            db.DMLQuery(command, 2);
        }
        public int GetLastClassID() {
            command = "SELECT MAX(classid) FROM " + db.dbName + ".class";
            return db.GetLastID(command);

        }
        public void SetValues(int clsid,int teaId,string batch,string day,string startTime,string endTime,double fees) {
            clsId = clsid;
            clsTeaId = teaId;
            clsBatch = batch;
            clsDay = day;
            clsStartTime = startTime;
            clsEndTime = endTime;
            clsFees = fees;

        
        }
        public DataTable ReportAllDetails()
        {
            command = "SELECT cls.classid,cls.day,cls.starttime,cls.endtime,cls.batch,cls.fee,tea.fname As TeacherFirstName,tea.lname As TeacherLastName FROM " + db.dbName + ".Teachers tea JOIN " + db.dbName + ".class cls WHERE tea.teaid = cls.teachid";
            return db.TableResult(command);

        }
        public void ClassesSubReport() { 
            
        }
        public DataTable ClassesDayReports()
        { 
            command = "SELECT cls.classid,cls.day,cls.starttime,cls.endtime,cls.batch,cls.fee,tea.fname,tea.lname FROM " + db.dbName + ".Teachers tea JOIN " + db.dbName + ".class cls WHERE tea.teaid = cls.teachid AND cls.day='"+clsDay+"'";
            return db.TableResult(command);
        }
        
    
    }
}
