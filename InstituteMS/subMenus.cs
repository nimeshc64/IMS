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
    public partial class subMenus : Form
    {
        public subMenus()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            stuAttendent st = new stuAttendent();
            m.mainForm.Controls.Add(st.panel3);
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            stuRegister st = new stuRegister();
            st.TopLevel = false;
            st.Dock = DockStyle.Fill;
            m.mainForm.Controls.Add(st);
            st.Show();
            //loadMainForms(new stuRegister().stuReg);

        }
        public void loadMainForms(Panel p)
        {
           
          // main.mainForms.Controls.Add(p);
        }
    }
}
