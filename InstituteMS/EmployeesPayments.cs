using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteMS
{
    class EmployeesPayments:Payments
    {
        public string command;
        DBConnect db = new DBConnect();
        private int pEmpid;

        public int payEmpId {
            get {
                return this.pEmpid;
            }
            set {
                pEmpid = value;
            }
        }
        

        public void RegisterEmployeePayments() {
            command = "INSERT INTO " + db.dbName + ".emppayments(month,year,paydate,amount,empid) VALUES('" + payMonth + "','" + payYear + "','" + payDate + "','" + payAmount + "','" + pEmpid + "')";
            db.DMLQuery(command, 1);
        }
        public void DeleteEmployee2()
        {
            try
            {
                command = "DELETE FROM " + db.dbName + ".emppayments WHERE empid='" + payEmpId + "'";
                db.DMLQuery(command, 3);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
