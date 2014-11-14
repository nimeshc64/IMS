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
            commcls.SetValues(int.Parse(clsIDtxt.Text),int.Parse(teaID),clsBatchtxt.Text,clsDaycmb.Text,clsStartTimecmb.Text,clsEndTimecmb.Text,double.Parse(clsFeetxt.Text));
            commcls.RegisterClass();
            clsLastId.Text =  commcls.GetLastClassID().ToString();
            ClearTextFields();

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
            commcls.SetValues(int.Parse(clsIDtxt.Text), int.Parse(teaID), clsBatchtxt.Text, clsDaycmb.Text, clsStartTimecmb.Text, clsEndTimecmb.Text, double.Parse(clsFeetxt.Text));
            commcls.ModifyClass();
            ClearTextFields();

        }
        public void setTextBoxValues()
        {
            
            //CommonClass commcls = new CommonClass();
            //commcls.clsId = int.Parse(clsID.Text);
            //commcls.clsTeaId = 
            //commcls.clsBatch =
            //commcls.clsDay = 
            //commcls.clsStartTime = 
            //commcls.clsEndTime = 
            

        }

        private void couTeaDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void couTeaDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teaIdSelectlbl.Text = couTeaDetails.CurrentRow.Cells[0].Value.ToString();
        }
        public void ClearTextFields() {
            clsIDtxt.Clear();
            clsFeetxt.Clear();
            clsDaycmb.Text = "";
            clsBatchtxt.Clear();
            teaIdSelectlbl.Clear();
            clsStartTimecmb.Text = "";
            clsEndTimecmb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void days_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonClass commcls = new CommonClass();
            commcls.clsDay = days.SelectedItem.ToString();
            clsGridView.DataSource =  commcls.ClassesDayReports();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonClass commcls = new CommonClass();
            commcls.clsId = int.Parse(clsIDtxt.Text);
            commcls.SearchClass();
            teaIdSelectlbl.Text = commcls.clsTeaId.ToString();
            clsBatchtxt.Text = commcls.clsBatch;
            clsDaycmb.Text = commcls.clsDay;
            clsStartTimecmb.Text = commcls.clsStartTime;
            clsEndTimecmb.Text = commcls.clsEndTime;
            clsFeetxt.Text = commcls.clsFees.ToString();

        }
    }
}
