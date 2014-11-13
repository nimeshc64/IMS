using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InstituteMS
{
    class PermanentEmployee:Employees
    {
       

        public string command;
        DBConnect db = new DBConnect();

        public void RegisterEmployee()
        {
            command = "INSERT INTO " + db.dbName + ".employee(empid,fname,lname,nic,add1,add2,add3,contact) VALUES('" + emplid + "','" + emplFName + "','" + emplLName + "','" + emplNIC + "','" + emplAdd1 + "','" + emplAdd2 + "','" + emplAdd3 + "','" + emplContact + "') ";
            db.DMLQuery(command, 1);

        }

        public void ModifyEmployee()
        {
            command = "UPDATE " + db.dbName + ".employee SET fname='" + emplFName + "',lname='" + emplLName + "',nic='" + emplNIC + "',add1='" + emplAdd1 + "',add2='" + emplAdd2 + "',add3='" + emplAdd3 + "',contact='" + emplContact + "' WHERE empid ='" + emplid + "'";
            db.DMLQuery(command, 2);
        }

        public void DeleteEmployee()
        {
            command = "DELETE FROM " + db.dbName + ".employee WHERE empid='" + emplid + "'";
            db.DMLQuery(command, 3);


        }

        public int GetLastEmployeeId()
        {
            command = "SELECT MAX(empid) FROM " + db.dbName + ".employee";
            return db.GetLastID(command);
        
        }
        public DataTable ReportAllEmployee() { 
            command  = "SELECT * FROM "+db.dbName+".employee";
            return db.TableResult(command);
        }

    }
}
