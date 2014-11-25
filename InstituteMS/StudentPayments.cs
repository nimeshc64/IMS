using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace InstituteMS
{
    class StudentPayments:Payments
    {
        DBConnect db = new DBConnect();
        public MySqlDataReader read;
        public ArrayList list;
        public string command;
        public string stuclassselect(string stuid)
        {
            try
            {
                db.cmd.CommandText = "SELECT * FROM " + db.dbName + ".studentclass WHERE stuID='" + stuid + "'";
                db.checkConn();
                read = db.cmd.ExecuteReader();
                read.Read();
                classid = read["classID"].ToString();
            }
            catch (Exception em)
            {
                MessageBox.Show("errornnnn");
            }
            db.checkConn();
            return classid;
        }

        public void SaveStuPayments(int stuid)
        {
            //try
            //{
            //    command= "INSERT INTO " + db.dbName + ".studentpayments(stuPayID,month,year,amount,stuID,classID) VALUES('" + max + "','" + Month + "','" + year + "','" + amount + "','" +stuid + "','" +int.Parse(classid)+ "')";
            //    db.dmlQuery(command, 1);
            //}
            //catch (Exception em)
            //{
            //}
        }
        public void SetValues(int max, string Month, int year, float amount)
        {
            this.Month = Month;
            this.year = year;
            this.amount = amount;
            this.max=max;

        }
        
        public string stupaymentcheck(string stuid)
        {
            try
            {
                db.cmd.CommandText = "SELECT month FROM " + db.dbName + ".studentpayments WHERE stuID='" + stuid + "' AND month='" + DateTime.Now.Date.ToString("MMMM") +"'";
                db.checkConn();
                read = db.cmd.ExecuteReader();
                status=read.Read().ToString();                
               // status = read["month"].ToString();                
            }
            catch (Exception em)
            {
              //  MessageBox.Show("error");
            }
            db.checkConn();
            return status;
            
        }
        public ArrayList SearchStudents(string stuid)
        {
            try
            {
                db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".studentpayments WHERE stuID='" + stuid + "'";
                db.checkConn();
                read = db.cmd.ExecuteReader();
                read.Read();
                

                for (int c = 0; c < read.FieldCount; c++)
                {
                    list.Add(read[c].ToString());
                }
            }
            catch (Exception em)
            {
                MessageBox.Show("error");
            }
            db.checkConn();
            return list;
        }
  
        public Image stupic(string stuid)
        {
            db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".student WHERE stuID='" + stuid + "'";
            db.checkConn();
            read = db.cmd.ExecuteReader();
            while (read.Read())
            {
                img = (byte[])(read["photo"]);
                if (img == null)
                {

                }
                else
                {
                    MemoryStream mst = new MemoryStream(img);
                    stuphoto= System.Drawing.Image.FromStream(mst);
                }
            }
            return stuphoto;
        }
        public DataGridView grid;
        public DataGridView fillgrid()
        {
            db.TableResult("SELECT * FROM ims.studentpayments");
            grid.DataSource = db.table;
            return grid;
        }
          
    }
}
