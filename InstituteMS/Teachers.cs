using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteMS
{
    abstract class Teachers
    {
        private int teaID;
        private string teaFName;
        private string teaLName;
        private string teaNIC;
        private string teaContact;
        public string teaAdd1;
        public string teaAdd2;
        public string teaAdd3;
        private string teaEmail;
        public string teaSubject;

        public int teacId {
            get {
                return this.teaID;
            }
            set {
                teaID = value;
            }
        }

        public string teacFName {
            get {
                return this.teaFName;
            }
            set {
                teaFName = value;
            }
        
        }
        public string teacLName {
            get {
                return this.teaLName;
            }
            set {
                teaLName = value;
            }
            
        }
        public string teacNIC {
            get {
                return this.teaNIC;
            }
            set {
                teaNIC = value;
            }

        }
        public string teacContact {
            get {
                return this.teaContact;
            }
            set {
                teaContact = value;
            }
        }
        public string teacEmail {
            get {
                return this.teaEmail;
            }

            set {
                teaEmail = value;
            }
        }
        abstract public  void RegisterTeacher();
        abstract public void ModifyTeacher();
    }
}
