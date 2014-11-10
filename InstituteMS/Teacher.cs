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
        InternalTeachers tea = new InternalTeachers();
        DBConnect db = new DBConnect();
        TeachersPayments teaPay = new TeachersPayments();
        private void button1_Click(object sender, EventArgs e)
        {
            //tea.teaID =int.Parse( teaID.Text);
            //tea.teaFName = teaFName.Text;
            //tea.teaLName = teaLName.Text;
            //tea.teaContact = teaContact.Text;
            //tea.teaNIC = teaNIC.Text;
            //tea.teaAdd1 = teaAdd1.Text;
            //tea.teaAdd2 = teaAdd2.Text;
            //tea.teaAdd3 = teaAdd3.Text;
            //tea.teaEmail = teaEmail.Text;
            //tea.teaSubject = teaSubject.Text;
            setTextBoxValues();
            tea.RegisterTeacher();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTextBoxValues();
            tea.ModifyTeacher();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void setTextBoxValues() {
            tea.setTeacherValues(int.Parse(teaID.Text), teaFName.Text, teaLName.Text, teaContact.Text, teaNIC.Text, teaAdd1.Text, teaAdd2.Text, teaAdd3.Text, teaEmail.Text, teaSubject.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            tea.SearchTeacher(teaID.Text);
            teaID.Text = tea.list[0].ToString();
            teaFName.Text = tea.list[1].ToString();
            teaLName.Text = tea.list[2].ToString();
            teaNIC.Text = tea.list[3].ToString();
            teaContact.Text = tea.list[4].ToString();
            teaAdd1.Text = tea.list[5].ToString();
            teaAdd2.Text = tea.list[6].ToString();
            teaAdd3.Text = tea.list[7].ToString();
            teaEmail.Text = tea.list[8].ToString();
            teaSubject.Text = tea.list[9].ToString();
            tea.list.Clear();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }
        private void teaAllRbn_CheckedChanged(object sender, EventArgs e)
        {
            InternalTeachers tr = new InternalTeachers();
            teaReportGrid.DataSource = tr.ReportAllDetails();
            
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
                teaReportGrid.DataSource = tea.ReportSubject(teaSubCombo.Text);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            lastID.Text = tea.GetLastTeachersID().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = int.Parse(teaIDPay.Text);
            int month = int.Parse(teaMonth.Text) ;
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
    }
}
