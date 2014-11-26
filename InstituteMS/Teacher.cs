using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InstituteMS
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        InternalTeachers interteach = new InternalTeachers();
        DBConnect db = new DBConnect();
        TeachersPayments teaPay = new TeachersPayments();
        private void button1_Click(object sender, EventArgs e)
        {
            setTextBoxValues();
            interteach.RegisterTeacher();
            lastIDlbl.Text = interteach.GetLastTeachersID().ToString();
            ClearAllFields();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTextBoxValues();
            interteach.ModifyTeacher();
            ClearAllFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void setTextBoxValues() {
            interteach.setTeacherValues(int.Parse(teaIDtxt.Text), teaFNametxt.Text, teaLNametxt.Text, teaContacttxt.Text, teaNICtxt.Text, teaAdd1txt.Text, teaAdd2txt.Text, teaAdd3txt.Text, teaEmailtxt.Text, teaSubjecttxt.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InternalTeachers interteach = new InternalTeachers();
            interteach.teacId = int.Parse(teaIDtxt.Text);
            interteach.SearchTeacher();
            teaFNametxt.Text = interteach.teacFName;
            teaLNametxt.Text = interteach.teacLName;
            teaNICtxt.Text = interteach.teacNIC;
            teaContacttxt.Text = interteach.teacContact;
            teaAdd1txt.Text = interteach.teaAdd1;
            teaAdd2txt.Text = interteach.teaAdd2;
            teaAdd3txt.Text = interteach.teaAdd3;
            teaEmailtxt.Text = interteach.teacEmail;
            teaSubjecttxt.Text = interteach.teaSubject;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }
        private void teaAllRbn_CheckedChanged(object sender, EventArgs e)
        {
            InternalTeachers tr = new InternalTeachers();
          //  teaReportGrid.DataSource = tr.ReportAllDetails();
            InternalTeachers interteach = new InternalTeachers();
            teaReportGrid.DataSource = interteach.ReportAllDetails();
          
        }

        private void teaSubRbn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void teaSubCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (teaSubCombo.Text == "")
            {

            }
            else
            {

                //teaReportGrid.DataSource = tea.ReportSubject(teaSubCombo.Text);

                teaReportGrid.DataSource = interteach.ReportSubject(teaSubCombo.Text);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            lastIDlbl.Text = interteach.GetLastTeachersID().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = int.Parse(teaIDPay.Text);
            string month = teaMonth.Text ;
            int year =int.Parse( teaYear.Text);
            string type = null;
            if (teaPayType.SelectedIndex  == 0){
                type = "A";
            }
            else if(teaPayType.SelectedIndex ==1){
                type = "B";
            }
           
            float amount = float.Parse(teaAmount.Text);

            teaPay.SetValues(id, type, month, year, amount);
            teaPay.MainPayments();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public void ClearAllFields() {
            teaIDtxt.Clear();
            teaFNametxt.Clear();
            teaLNametxt.Clear();
            teaNICtxt.Clear();
            teaContacttxt.Clear();
            teaAdd1txt.Clear();
            teaAdd2txt.Clear();
            teaAdd3txt.Clear();
            teaEmailtxt.Clear();
            teaSubjecttxt.Text = "";
        
        
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            InternalTeachers interteach = new InternalTeachers();
             

            teaSubjecttxt.Items.Clear();
            for (int c = 0; c < interteach.GetSubjects().Rows.Count; c++)
            {
                teaSubjecttxt.Items.Add(interteach.GetSubjects().Rows[c][0].ToString());
            }

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            InternalTeachers interteach = new InternalTeachers();


            teaSubjecttxt.Items.Clear();
            for (int c = 0; c < interteach.GetSubjects().Rows.Count; c++)
            {
                teaSubCombo.Items.Add(interteach.GetSubjects().Rows[c][0].ToString());
            }
        }
       
    }
}
