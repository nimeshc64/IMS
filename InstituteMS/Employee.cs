using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteMS
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void empSavebtn_Click(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            perEmp.emplid = int.Parse(empIdtxt.Text);
            perEmp.emplFName = empFNametxt.Text;
            perEmp.emplLName = empLNametxt.Text;
            perEmp.emplNIC = empNICtxt.Text;
            perEmp.emplAdd1 = empAdd1txt.Text;
            perEmp.emplAdd2 = empAdd2txt.Text;
            perEmp.emplAdd3 = empAdd3txt.Text;
            perEmp.emplContact = empContacttxt.Text;
            perEmp.RegisterEmployee();
            ClearTextFields();
            
            empLastIdlbl.Text = perEmp.GetLastEmployeeId().ToString();
            

        }

        private void empModbtn_Click(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            perEmp.emplid = int.Parse(empIdtxt.Text);
            perEmp.emplFName = empFNametxt.Text;
            perEmp.emplLName = empLNametxt.Text;
            perEmp.emplNIC = empNICtxt.Text;
            perEmp.emplAdd1 = empAdd1txt.Text;
            perEmp.emplAdd2 = empAdd2txt.Text;
            perEmp.emplAdd3 = empAdd3txt.Text;
            perEmp.emplContact = empContacttxt.Text;
            perEmp.ModifyEmployee();
            ClearTextFields();
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmployeesPayments empPayment = new EmployeesPayments();
            MenuHandle mHandle = new MenuHandle();
            empPayment.payEmpId =int.Parse( payEmpIdtxt.Text);
            empPayment.payMonth = payEmpMonthcmb.Text;
            empPayment.payYear = int.Parse(payEmpYeartxt.Text);
            empPayment.payDate = mHandle.GetDate();
            empPayment.payAmount = double.Parse(payEmpAmounttxt.Text);
            empPayment.RegisterEmployeePayments();
            ClearTextFields();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            empAlldatagrid.DataSource = perEmp.ReportAllEmployee();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            MenuHandle mHandle = new MenuHandle();
            payEmpIdtxt.Items.Clear();
            payEmpYeartxt.Text = mHandle.GetYear();
            for (int x=0; x < perEmp.ReportAllEmployee().Rows.Count; x++) {
                payEmpIdtxt.Items.Add(perEmp.ReportAllEmployee().Rows[x][0]);
            }
            
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            empLastIdlbl.Text = perEmp.GetLastEmployeeId().ToString();
        }

        public void ClearTextFields() {
            empIdtxt.Clear();
            empFNametxt.Clear();
            empLNametxt.Clear();
            empAdd1txt.Clear();
            empAdd2txt.Clear();
            empAdd3txt.Clear();
            empContacttxt.Clear();
            empNICtxt.Clear();
            payEmpAmounttxt.Clear();
            payEmpIdtxt.Text = "";
            
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            perEmp.emplid = int.Parse(empIdtxt.Text);
            perEmp.SearchEmployee();
            empFNametxt.Text = perEmp.emplFName;
            empLNametxt.Text = perEmp.emplLName;
            empNICtxt.Text = perEmp.emplNIC;
            empAdd1txt.Text = perEmp.emplAdd1;
            empAdd2txt.Text = perEmp.emplAdd2;
            empAdd3txt.Text = perEmp.emplAdd3;
            empContacttxt.Text = perEmp.emplContact;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PermanentEmployee perEmp = new PermanentEmployee();
            EmployeesPayments empPayment = new EmployeesPayments();
            perEmp.emplid = int.Parse(empIdtxt.Text);
            empPayment.payEmpId = int.Parse(empIdtxt.Text);
            empPayment.DeleteEmployee2();
            perEmp.DeleteEmployee();
        }
       

        

        
    }
}
