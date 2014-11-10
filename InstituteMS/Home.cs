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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee t = new Employee();
            t.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportsPayment r = new ReportsPayment();
            r.ShowDialog();
        }
    }
}
