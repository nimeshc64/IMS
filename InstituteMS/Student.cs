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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        QrEncod encode = new QrEncod();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StuAid_TextChanged(object sender, EventArgs e)
        {
            if (StuAid.Text == null)
            {
                StuAqrpic.Image = null;
            }
            else
            {
                encode.SetData(StuAid.Text);
                encode.Encoding();
                encode.GetImage();
                StuAqrpic.Image = encode.GetImage();
            }
        }
    }
}
