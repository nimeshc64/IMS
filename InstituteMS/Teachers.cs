using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteMS
{
    abstract class Teachers
    {
        public int teaID;
        public string teaFName;
        public string teaLName;
        public string teaNIC;
        public string teaContact;
        public string teaAdd1;
        public string teaAdd2;
        public string teaAdd3;
        public string teaEmail;
        public string teaSubject;

        abstract public  void RegisterTeacher();
        abstract public void ModifyTeacher();
    }
}
