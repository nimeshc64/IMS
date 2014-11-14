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
    class PermanentEmployee:Employees
    {
       

        public string command;
        DBConnect db = new DBConnect();

        public void RegisterEmployee()
        {
            command = "INSERT INTO " + db.dbName + ".employee(empid,fname,lname,nic,add1,add2,add3,contact) VALUES('" + emplid + "','" + emplFName + "','" + emplLName + "','" + emplNIC + "','" + emplAdd1 + "','" + emplAdd2 + "','" + emplAdd3 + "','" + emplContact + "') ";
            db.DMLQuery(command, 1);

        }
        public void SearchEmployee() {
            try
            {
                command = "SELECT * FROM " + db.dbName + ".employee WHERE empid=" + emplid + "";
                DataTable datatable = db.TableResult(command);
                emplFName = datatable.Rows[0][1].ToString();
                emplLName = datatable.Rows[0][2].ToString();
                emplNIC = datatable.Rows[0][3].ToString();
                emplAdd1 = datatable.Rows[0][4].ToString();
                emplAdd2 = datatable.Rows[0][5].ToString();
                emplAdd3 = datatable.Rows[0][6].ToString();
                emplContact = datatable.Rows[0][7].ToString();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);   
            }
        }
        public void ModifyEmployee()
        {
            try
            {
                command = "UPDATE " + db.dbName + ".employee SET fname='" + emplFName + "',lname='" + emplLName + "',nic='" + emplNIC + "',add1='" + emplAdd1 + "',add2='" + emplAdd2 + "',add3='" + emplAdd3 + "',contact='" + emplContact + "' WHERE empid ='" + emplid + "'";
                db.DMLQuery(command, 2);
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteEmployee()
        {
            try
            {
                command = "DELETE FROM " + db.dbName + ".employee WHERE empid='" + emplid + "'";
                db.DMLQuery(command, 3);
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

        }
       
        public int GetLastEmployeeId()
        {
            try
            {
                command = "SELECT MAX(empid) FROM " + db.dbName + ".employee";
                return db.GetLastID(command);
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
                return 0;
            }
        
        }
        public DataTable ReportAllEmployee() {
            try
            {
                command = "SELECT * FROM " + db.dbName + ".employee";
                return db.TableResult(command);
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        
    }
}
