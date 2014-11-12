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
using System.Drawing;
using AForge.Video.DirectShow;//web cam libry
using AForge;//web cam libry
using AForge.Video;//web cam libry
using ZXing;
using ZXing.Common;
using ZXing.Multi;
using ZXing.Multi.QrCode;
using System.Media;


namespace InstituteMS
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            CamDevice();
            dategen();
        }
        DBConnect db = new DBConnect();
        QrEncod encode = new QrEncod();
        ALstudents alstu = new ALstudents();
        StudentPayments stupay = new StudentPayments();

        //-------------------------------Register Start---------------------------------------------//
        private void StuAid_TextChanged(object sender, EventArgs e)
        {
            if (StuRid.Text == null)
            {
                StuRqrpic.Image = null;
            }
            else
            {
                encode.SetData(StuRid.Text);
                encode.Encoding();
                encode.GetImage();
                StuRqrpic.Image = encode.GetImage();
            }
        }        
        private void StuAprint_Click(object sender, EventArgs e)
        {
          //ptineter//
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
            alstu.SetStudentValues(int.Parse(StuRid.Text), StuRfname.Text, StuRlname.Text, StuRadd1.Text, StuRadd2.Text, StuRadd3.Text, Gender, int.Parse(StuRcontact.Text), StuRstupic.Image);

        }
        private void StuAsavebtn_Click(object sender, EventArgs e)
        {
            gender();
            setTextBoxValues();
            alstu.RegisterStudents(filename);
        }

        private void StuAupdatebtn_Click(object sender, EventArgs e)
        {
            gender();
            setTextBoxValues();
            alstu.ModifyStudents();
        }

        private void StuAdeletebtn_Click(object sender, EventArgs e)
        {
            setTextBoxValues();
            alstu.DeleteStudents();
        }
        string filename;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                StuRstupic.Image = new Bitmap(filename);
                
            }
        
        }
        
        private void StuAsearch_Click(object sender, EventArgs e)
        {  
            alstu.SearchStudents(StuRid.Text);
            StuRid.Text = alstu.list[0].ToString();
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
            StuRstupic.Image = alstu.Stuphoto;
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
                        DateTime dt = DateTime.Now;
                        var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
                        StuAstuid.Text = result.ToString();
                        stupay.stupatmentcheck(result.ToString());
                        stupay.stupic(result.ToString());
                        StuAstupic.Image = stupay.stuphoto;
                        monthcheck= stupay.data.ToString();
                        if (monthcheck !=DateTime.Now.Date.ToString("MMMM"))
                        {
                            StuAsatus.BackColor = Color.Red;
                            Console.Beep(2000,1000);
                            StuApaynow.Visible = true;
                            StuAcancel.Visible = true;
                        }
                         
                        img.Dispose();
                    }

                }
                catch (Exception ex)
                {
                }

            }
        }
        private void StuApaynow_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
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
            string month = StuPmonth.SelectedValue.ToString();
            int year = int.Parse(StuPyear.Text);
            float amount = int.Parse(StuPfees.Text);
             stupay.SetValues(month, year, amount);
             stupay.SaveStuPayments(int.Parse(StuPid.Text));
        }
        private void StuPsearch_Click(object sender, EventArgs e)
        {
            alstu.SearchStudents(StuPid.Text);
            StuPname.Text = alstu.list[1].ToString();
            if (alstu.list[1] == null)
            {
                MessageBox.Show("Error");
            }
            alstu.list.Clear();
            alstu.studentimage(StuPid.Text);
            Stuppic.Image = alstu.Stuphoto;
        }

        private void StuPid_TextChanged(object sender, EventArgs e)
        {

        }

       
        


        
    }
}
