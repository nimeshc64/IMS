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
        InternalTeachers tea = new InternalTeachers();
        private void Course_Load(object sender, EventArgs e)
        {
           couTeaDetails.DataSource =  tea.getTeachers();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string teaID = couTeaDetails.CurrentRow.Cells[0].Value.ToString();
            
        }
    }
}
