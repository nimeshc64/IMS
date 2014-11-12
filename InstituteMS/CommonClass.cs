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
            command = "INSERT INTO "+db.dbName+".class(classid,day,starttime,endtime,batch,fee,teachid) VALUES('"+this.classID+"','"+this.day+"','"+this.startTime+"','"+this.endTime+"','"+this.batch+"','"+this.fees+"','"+this.teaid+"')";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }

        public void DeleteClass() {
            command = "DELETE FROM "+db.dbName+".class WHERE classID='"+this.classID+"'";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }
        public void ModifyClass() {
            command = "UPDATE "+db.dbName+".class SET day='"+this.day+"',starttime ='"+this.startTime+"' ,endtime='"+this.endTime+"', batch='"+this.batch+"',fee ='"+this.fees+"',teachid ='"+this.teaid+"' WHERE classID = '"+this.classID+"' ";
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
        public void SetValues(int clsid,int teaid,string batch,string day,string startTime,string endTime,double fees) {
            this.classID = clsid;
            this.teaid = teaid;
            this.batch = batch;
            this.day = day;
            this.startTime = startTime;
            this.endTime = endTime;
            this.fees = fees;

        
        }
        public DataTable ReportAllDetails()
        {
            command = "SELECT *FROM " + db.dbName + ".class";
            db.cmd.CommandText = command;
            db.checkConn();
            MySqlDataAdapter dataAdap = new MySqlDataAdapter(db.cmd);
            dTable = new DataTable();
            dataAdap.Fill(dTable);
            db.checkConn();

            return dTable;

        }
        public void ClassesSubReport() { 
        
        }
        public void ClassesDayReports() { 
        
        
        }
        
    
    }
}
