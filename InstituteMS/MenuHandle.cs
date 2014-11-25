using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InstituteMS
{
    class MenuHandle
    {

        public string GetDate() {
            DateTime datetime = DateTime.Now;
            string date = datetime.ToString("yyyy:mm:dd");
            return date;
        }

        public string GetYear() {
            DateTime date = DateTime.Now;
            string year = date.ToString("yyyy");
            return year;
        }
    }
}
