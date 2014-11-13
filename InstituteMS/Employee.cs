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
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            PermanentEmployee perEmp=new PermanentEmployee ();
            empAlldatagrid.DataSource = perEmp.ReportAllEmployee();
        }

       

        

        
    }
}
