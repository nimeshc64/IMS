using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace InstituteMS
{
    class Payments
    {
        public int payID;
<<<<<<< HEAD
        public int month;
        public string Month;
        public int year;
        public string payDate;
        public float amount;
        public Image stuphoto;
        public byte[] img;
        public string data;
        public string classid;
        public int max;
        public string status;
    

=======
        public string month;
        public int year;
        public string paymentDate;
        public double amount;

        public int payId {
            get {
                return this.payID;
            }
            set {
                payID = value;
            }
        }
        public string payMonth {
            get {
                return this.month;
            }
            set {
                month = value;
            }
        
        }

        public int payYear {
            get {
                return this.year;
            }
            set {
                year = value;
            }
        }

        public string payDate {
            get {
                return this.paymentDate;
            }
            set {
                paymentDate = value;
            }
        }
        public double payAmount {
            get {
                return this.amount;
            }
            set {
                amount = value;
            }
        }
>>>>>>> 58dbdcbb69879679487c994fc900ee2a862ce14a
    }
}
