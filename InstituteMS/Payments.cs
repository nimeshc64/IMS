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
        public string Month;   
        public string payDate;               
        public string classid;
        public int max;
         
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

        //public string payDate
        //{
        //    get
        //    {
        //        return this.paymentDate;
        //    }
        //    set
        //    {
        //        paymentDate = value;
        //    }
        //}

        public double payAmount {
            get {
                return this.amount;
            }
            set {
                amount = value;
            }
        }

    }
}
