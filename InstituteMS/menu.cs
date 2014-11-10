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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        subMenus stMenu = new subMenus();
        Panel p;
        private void button1_Click(object sender, EventArgs e)
        {
            loadSub(stMenu.panelStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadSub(stMenu.panelTeachers);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadSub(stMenu.panelEmloyee);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadSub(stMenu.panelReport);
           
        }
        //Load subforms
        public void loadSub(Panel p)
        {
            subMenu.Controls.Clear();
            p.Location = topPanel.Location;
            subMenu.Controls.Add(p); 
        }
        
    }
}
