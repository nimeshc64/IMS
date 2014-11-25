using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.ComponentModel;

namespace InstituteMS
{
    class ALstudents:Students
    {
        public MySqlDataReader read;
        public DataTable dTable;
        public string command;

        int checkStatus;
        public ArrayList list = new ArrayList();
        DBConnect db = new DBConnect();

        public void SetStudentValues(int StuId, string StuFName, string StuLName, string StuAdd1, string StuAdd2, string StuAdd3, string StuGender, int Stucontact, string stuphoto)
        {
            this.StuID = StuId;
            this.StuFName = StuFName;
            this.StuLName = StuLName;
            this.Stuadd1 = StuAdd1;
            this.Stuadd2 = StuAdd2;
            this.Stuadd3 = StuAdd3;
            this.Stucontact =Stucontact;
            this.Stugender = StuGender;
            this.Stuphoto =stuphoto;
            
        }
        public override void RegisterStudents()
        {
            try
            {
                byte[] imagebt = null;
                FileStream fst = new FileStream(Stuphoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fst);
                imagebt = br.ReadBytes((int)fst.Length);
                db.DMLQuery("INSERT INTO " + db.dbName + ".student(stuID,fName,lName,address1,address2,address3,Gender,contact,photo) VALUES('" + this.StuID + "','" + this.StuFName + "','" + this.StuLName + "','" + this.Stuadd1 + "','" + this.Stuadd2 + "','" + this.Stuadd3 + "','" + this.Stugender + "','" + this.Stucontact + "',@img)", 1);             
                db.cmd.Parameters.Add(new MySqlParameter("@img", imagebt));             
                db.checkConn();               
            }
            catch
            {

            }
        }
        public override void ModifyStudents()
        {
            //try
            //{
            //    command = "UPDATE " + db.dbName + ".student SET stuID='" + this.StuID + "',fname='" + this.StuFName + "',lname='" + this.StuLName + "',address1='" + this.Stuadd1 + "',address2='" + this.Stuadd2 + "',address3='" + this.Stuadd3 + "',Gender='" + this.Stugender + "',contact='" + this.Stucontact + "' WHERE stuID='" + this.StuID + "'";
            //    db.dmlQuery(command, 2);
            //}
            //catch
            //{

            //}
        }
        public override void DeleteStudents(string nom)
        {
            //try
            //{
            //   command= "DELETE FROM " + db.dbName + ".student WHERE stuID='" +nom+ "'";
            //   db.dmlQuery(command, 3);
            //}
            //catch
            //{

            //}
        }
        public ArrayList SearchStudents(string stuid)
        {
            try
            {
                db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".student WHERE stuID='" + stuid + "'";
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
                MessageBox.Show("Invalid ID Number Enter Again");
            }              
                db.checkConn();
                return list;           
        }
        public Image studentimage(string stuid)
        {
            try
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
                        picture = System.Drawing.Image.FromStream(mst);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            db.checkConn();
           return picture;

        }

        public DataGridView grid;
        public DataGridView fillgrid()
        {
            db.TableResult("SELECT * FROM ims.student");
            grid.DataSource = db.table;
            return grid;
        }
    }
}
