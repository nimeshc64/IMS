using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace InstituteMS
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        
        private void Course_Load(object sender, EventArgs e)
        {
           InternalTeachers tea = new InternalTeachers();
           CommonClass commcls = new CommonClass();
           couTeaDetails.DataSource =  tea.getTeachers();
           clsLastId.Text= commcls.GetLastClassID().ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonClass commcls = new CommonClass();

            string teaID = couTeaDetails.CurrentRow.Cells[0].Value.ToString();
            commcls.SetValues(int.Parse(clsID.Text),int.Parse(teaID),clsBatch.Text,clsDay.Text,clsStartTime.Text,clsEndTime.Text,double.Parse(clsFee.Text));
            commcls.RegisterClass();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CommonClass commcls = new CommonClass();
            if (clsAllRbn.Checked) {
                clsGridView.DataSource = commcls.ReportAllDetails();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonClass commcls = new CommonClass();
            string teaID = couTeaDetails.CurrentRow.Cells[0].Value.ToString();
            commcls.SetValues(int.Parse(clsID.Text), int.Parse(teaID), clsBatch.Text, clsDay.Text, clsStartTime.Text, clsEndTime.Text, double.Parse(clsFee.Text));
            commcls.ModifyClass();
        }
        
    }
}
