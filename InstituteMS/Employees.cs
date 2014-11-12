using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteMS
{
    class Employees
    {
        public int empId;
        public string empFName;
        public string empLName;
        public string empNIC;
        public string empAdd1;
        public string empAdd2;
        public string empAdd3;
        public string empContact;
        public string command;
        DBConnect db = new DBConnect();
        public void RegisterEmployee() {
            command = "INSERT INTO "+db.dbName+".employee(empid,fname,lname,nic,add1,add2,add3,contact) VALUES('"+this.empId+"','"+this.empFName+"','"+this.empLName+"','"+this.empNIC+"','"+this.empAdd1+"','"+this.empAdd2+"','"+this.empAdd3+"','"+this.empContact+"') ";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }
        public void ModifyEmployee() {
            command = "UPDATE "+db.dbName+".employee SET fname='"+this.empFName+"',lname='"+this.empLName+"',nic='"+this.empNIC+"',add1='"+this.empAdd1+"',add2='"+this.empAdd2+"',add3='"+this.empAdd3+"',contact='"+this.empContact+"' WHERE empid ='"+this.empId+"'";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();
        }
        public void DeleteEmployee() {
            command = "DELETE FROM "+db.dbName+".employee WHERE empid='"+this.empId+"'";
            db.cmd.CommandText = command;
            db.checkConn();
            db.cmd.ExecuteNonQuery();
            db.checkConn();

        
        }
        public int GetLastEmployeeId() {
            command = "SELECT MAX(empid) F";
            return 2;
        }

    }
}
