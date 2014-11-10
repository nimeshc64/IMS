using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;




namespace InstituteMS
{
    class CommonClass:Classes
    {
        DBConnect db = new DBConnect();
        private string command;
       


        public void RegisterClass() {
            command = "INSERT INTO "+db.dbName+".class(classid,day,starttime,endtime,batch,fee,teachid) VALUES('"+this.courseID+"','"+this.day+"','"+this.startTime+"','"+this.endTime+"','"+this.batch+"','"+this.fees+"','"+this.teacher+"')";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }

        public void DeleteClass() {
            command = "DELETE FROM "+db.dbName+".class WHERE classID='"+this.courseID+"'";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }
        public void ModifyClass() {
            command = "UPDATE "+db.dbName+".class SET day='"+this.day+"',starttime ='"+this.startTime+"' ,endtime='"+this.endTime+"', batch='"+this.batch+"',fee ='"+this.fees+"',teachid ='"+this.teacher+"' ";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }
        public int GetLastClassID() {
            command = "SELECT MAX(classid) FROM " + db.dbName + ".class";
            db.cmd.CommandText = command;
            db.checkConn();
            int LastID = int.Parse(db.cmd.ExecuteScalar().ToString());
            db.checkConn();
            return LastID;

        }
        public void SetValues() { 
            
        
        }
        public void ClassesAllReports() { 
            
        
        }
        public void ClassesSubReport() { 
        
        }
        public void ClassesDayReports() { 
        
        
        }
        
    
    }
}
