using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InstituteMS
{
     abstract class Students
    {
        public int StuID;
        public int Classid;
        public string StuFName;
        public string StuLName;
        public string Stuadd1;
        public string Stuadd2;
        public string Stuadd3;
        public string Stugender;
        public int Stucontact;
        public string Stuphoto;
        public Image picture;
        public byte[] img;


        abstract public void RegisterStudents();
        abstract public void ModifyStudents();
        abstract public void DeleteStudents(int nom);
        
    }
}
