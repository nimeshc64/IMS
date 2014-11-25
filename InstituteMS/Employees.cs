using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteMS
{
    class Employees
    {
        private int empId;
        private string empFName;
        private string empLName;
        private string empNIC;
        private string empAdd1;
        private string empAdd2;
        private string empAdd3;
        private string empContact;

        public int emplid
        {
            get
            {
                return this.empId;
            }
            set
            {
                empId = value;
            }

        }

        public string emplFName
        {
            get
            {
                return this.empFName;
            }
            set
            {
                empFName = value;
            }

        }

        public string emplLName
        {
            get
            {
                return this.empLName;
            }
            set
            {
                empLName = value;
            }
        }

        public string emplNIC
        {
            get
            {
                return this.empNIC;
            }
            set
            {
                empNIC = value;
            }

        }
        public string emplAdd1
        {
            get
            {
                return this.empAdd1;
            }
            set
            {
                empAdd1 = value;
            }
        }

        public string emplAdd2
        {
            get
            {
                return this.empAdd2;
            }
            set
            {
                empAdd2 = value;
            }

        }

        public string emplAdd3
        {
            get
            {
                return this.empAdd3;
            }
            set
            {
                empAdd3 = value;
            }
        }
        public string emplContact
        {
            get
            {
                return this.empContact;
            }
            set
            {
                empContact = value;
            }

        }
       

    }
}
