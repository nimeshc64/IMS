using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstituteMS
{
    abstract class Classes
    {
        private int classID;
        private int teaid;
        private string batch;
        private string day;
        private string startTime;
        private string endTime;
        private double fees;

        public int clsId {
            get {
                return this.classID;
            }
            
            set {
                if (value < 10)
                    classID = value;
                else
                    MessageBox.Show("bellow11");
                }
        
        }
        public int clsTeaId {
            get {
                return this.teaid;
            }
            set {
                teaid = value;
            }
        }
        public string clsBatch {
            get {
                return this.batch;
            }
            set {
                batch = value;
            }
        }
        public string clsDay {
            get {
                return this.day;
            }
            set {
                day = value;
            }
            
        }
        public string clsStartTime {
            get {
                return this.batch;
            }
            set {
                batch = value;
            }
        }
        public string clsEndTime {
            get {
                return this.batch;
            }
            set {
                batch = value;
            }
            
        }
        public double clsFees {
            get {
                return this.fees;
            }
            set {
                fees = value;
            }
        }
    }
}
