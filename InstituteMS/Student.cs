using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.IO;

using AForge.Video.DirectShow;//web cam libry
using AForge;//web cam libry
using AForge.Video;//web cam libry
using ZXing;
using ZXing.Common;
using ZXing.Multi;
using ZXing.Multi.QrCode;
using System.Media;

using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace InstituteMS
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            CamDevice();
            dategen();
            showstunewid();
            Classdetail();
           // fillallgrid();
        }
        DBConnect db = new DBConnect();
        QrEncod encode = new QrEncod();
        ALstudents alstu = new ALstudents();
        StudentPayments stupay = new StudentPayments();
        Validation valid = new Validation();

        //-------------------------------Register Start---------------------------------------------//
        private void StuAid_TextChanged(object sender, EventArgs e)
        {        
        }

        public void showstunewid()
        {
            int id = db.GetLastID("SELECT MAX(stuID) FROM ims.student");
            if (id == null)
            {
                id = 1;
            }
            else
            {
                id += 1;
                label26.Text = id.ToString();
                encode.SetData(label26.Text);
                encode.Encoding();
                StuRqrpic.Image=encode.GetImage();
            }
        }

        public void Classdetail()
        {
            CommonClass commcls = new CommonClass();
            StuRgridviwe.DataSource = commcls.ReportAllDetails();
        }

        private void StuAprint_Click(object sender, EventArgs e)
        {
            //printer//
        }
    

        private void StuAqrsave_Click(object sender, EventArgs e)
        {
            encode.SaveImageCapture(StuRqrpic.Image,StuRfname.Text);
        }
        string Gender;
        public void gender()
        {
            if (StuRfemale.Checked == true)
            {
                Gender = "F";
            }
            else
            {
                Gender = "M";
            }
        }
        public void setTextBoxValues()
        {
            alstu.SetStudentValues(int.Parse(label26.Text), int.Parse(StuRclassid.Text), StuRfname.Text, StuRlname.Text, StuRadd1.Text, StuRadd2.Text, StuRadd3.Text, Gender, int.Parse(StuRcontact.Text), filename);
        }
        public void clearbox()
        {
            showstunewid();
            StuRfname.Clear();
            StuRlname.Clear();
            StuRadd1.Clear();
            StuRadd2.Clear();
            StuRadd3.Clear();
            StuRcontact.Clear();
            StuRstupic.Image = null;
            StuRfemale.Checked = false;
            StuRmale.Checked = false;
            StuAstuid.Clear();
            StuAstatus.BackColor = Color.Transparent;
            StuApaynow.Visible = false;
            StuAcancel.Visible = false;
            StuAstupic.Image = null;
            StuPid.Clear();
            StuPyear.Clear();
            StuPfees.Clear();
            StuPname.Clear();
            Stuppic.Image = null;
        }
 
        private void StuAsavebtn_Click(object sender, EventArgs e)
        {
                if (StuRfname.Text==""||StuRlname.Text==""||StuRadd1.Text==""||StuRadd2.Text==""||StuRadd3.Text==""||StuRcontact.Text==""||Gender=="")
                {
                   MessageBox.Show("Fill All The TextBox","Message");
                }
                else
                {
                    gender();
                    setTextBoxValues();
                    alstu.RegisterStudents();
                    clearbox();
                }             
        }

        private void StuAupdatebtn_Click(object sender, EventArgs e)
        {
            gender();
            setTextBoxValues();
            alstu.ModifyStudents();
        }

        private void StuAdeletebtn_Click(object sender, EventArgs e)
        {
            alstu.DeleteStudents(Convert.ToInt16(StuRid.Text));
            showstunewid();
        }
        public string filename;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picloca = dlg.FileName.ToString();
                filename = picloca;
                StuRstupic.ImageLocation = picloca;
            }        
        }
        private void StuAsearch_Click(object sender, EventArgs e)
        {
            try
            {
              
                alstu.SearchStudents(StuRid.Text);
 
                    // StuRid.Text = alstu.list[0].ToString();
                    StuRfname.Text = alstu.list[1].ToString();
                    StuRlname.Text = alstu.list[2].ToString();
                    StuRadd1.Text = alstu.list[3].ToString();
                    StuRadd2.Text = alstu.list[4].ToString();
                    StuRadd3.Text = alstu.list[5].ToString();
                    Gender = alstu.list[6].ToString();
                    if (Gender == "f")
                    {
                        StuRfemale.Checked = true;
                    }
                    else
                    {
                        StuRmale.Checked = true;
                    }
                    StuRcontact.Text = alstu.list[7].ToString();
                    alstu.studentimage(StuRid.Text);
                    StuRstupic.Image = alstu.picture; 
                
            }
            catch (Exception ex){

            }
          
            alstu.list.Clear();
        }

       
        //-------------------Register End-------------------------------//

        //-------------------------Attendenc Start------------------------------------------//
        public FilterInfoCollection filter;
        public VideoCaptureDevice videocap;
        public void CamDevice()
        {
            // List input devices VIDEO
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // CHARGE TO ALL DEVICES COMBO
            foreach (FilterInfo Devics in filter)
            {
                StuAcamdevices.Items.Add(Devics.Name);
            }
            StuAcamdevices.SelectedIndex = 0;
            //  x FilterInfo in Devices
        }
        private void StuAStart_Click(object sender, EventArgs e)
        {
            // START READ
            StuAtimer.Enabled = true;

            // SET DEVICE SELECTED AS A SOURCE OF VIDEO
            videocap = new VideoCaptureDevice(filter[StuAcamdevices.SelectedIndex].MonikerString);
            // RESET CONTROL
            StuAvideoPlayer.VideoSource = videocap;
            // START RECEIVING IMAGES
            StuAvideoPlayer.Start();
        }

        private void StuAstop_Click(object sender, EventArgs e)
        {
            // STOP READ
            StuAtimer.Enabled = false;
            // STOP TAKING OF PICTURES
            StuAvideoPlayer.SignalToStop();
          
        }
        string monthcheck;
        string idcheck;
      
        private void StuAtimer_Tick(object sender, EventArgs e)
        {

            if (StuAvideoPlayer.GetCurrentVideoFrame() != null)
            {
                Bitmap img = new Bitmap(StuAvideoPlayer.GetCurrentVideoFrame());
                try
                {
                    BarcodeReader read = new BarcodeReader();
                    var result = read.Decode(img);
                    if (result == null)
                    {
                        img.Dispose();
                    }
                    else
                    {
                        StuAstuid.Text = result.ToString();
                        StuAclassid.Text = stupay.stuclassselect(StuAstuid.Text);                        
                        alstu.studentimage(StuAstuid.Text);
                        StuAstupic.Image = alstu.picture;
                        string status = stupay.stupaymentcheck(StuAstuid.Text, StuAclassid.Text);

                        if (status !="false")
                        {                          
                            StuAstatus.BackColor = Color.Green;
                            StuApaynow.Visible = false;
                            StuAcancel.Visible = false;
                        }
                        else
                        {                           
                            StuAstatus.BackColor = Color.Red;
                            StuApaynow.Visible = true;
                            StuAcancel.Visible = true;
                            Console.Beep(2000, 1000);
                        }

                    }
                }
                catch (Exception ex)
                {
                }
                img.Dispose();
            }
        }
       
        private void StuApaynow_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }
        private void StuAcancel_Click(object sender, EventArgs e)
        {
            clearbox();
        }
        //-----------------------------------Attendence end----------------------------//
        //-----------------------------------Payment strart--------------------------------//
        private void dategen()
        {
            DateTime dt = DateTime.Now;
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            StuPmonth.DataSource = months;
            StuPyear.Text = dt.Year.ToString();
        }

        private void StuPsave_Click(object sender, EventArgs e)
        {
            int id = db.GetLastID("SELECT MAX(stuPayID) FROM ims.studentpayments");
            if (id ==null)
            {
                id = 1;
            }
            else
            {
                id += 1;
                string month = StuPmonth.SelectedValue.ToString();
                int year = int.Parse(StuPyear.Text);
                float amount = int.Parse(StuPfees.Text);

                stupay.SetValues(id, month, year, amount);

                stupay.stuclassselect(StuPid.Text);
                stupay.SaveStuPayments(int.Parse(StuPid.Text));
                clearbox();
                dategen();
            }
           
        }
        private void StuPsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (StuPname.Text == null)
                {
                    clearbox();
                }
                else
                {
                    alstu.SearchStudents(StuPid.Text);
                    alstu.studentimage(StuPid.Text);
                    Stuppic.Image = alstu.picture;
                    StuPname.Text = alstu.list[1].ToString();
                    if (alstu.list[1] == null)
                    {
                        MessageBox.Show("Error");
                    }
                    alstu.list.Clear();
                }
            }
            catch (Exception ex)
            {
            } 
        }

        //public void fillallgrid()
        //{
        //    stupay.fillgrid();
        //    StuPgrid.DataSource = stupay.grid;
        //    alstu.fillgrid();
        //    StuRgridviwe.DataSource = alstu.grid;
        //}

        private void StuPid_TextChanged(object sender, EventArgs e)
        {

        }

        private void StuRcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StuPfees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }      
        private void StuAstuid_TextChanged(object sender, EventArgs e)
        {
        }

        private void StuRqrpic_Click(object sender, EventArgs e)
        {

        }

        private void StuRcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void StuPyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StuRgridviwe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.imsDataSet1.student);
            // TODO: This line of code loads data into the 'imsDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.imsDataSet.student);
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


      

       
       
    }
}
