using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data;
using System.Drawing;

namespace Practice.Controllers
{
    public class StudentController : Controller
    {
       
        public ActionResult Index()
        {
            //StudentModel student = new StudentModel();
            //ViewBag.First = "Muzamil";

           DB();

           // DBnonq();

            var student = SetStudentByModel();
            SetStudentByViewBag();
            SetStudentByViewData();
            return View(student);
        }

        public ActionResult Subject()
        {
            var sub = SetSubjectModel();
            return View(sub);
        }
        public ActionResult Details()
        {
            return View();
        }
        private StudentModel SetStudentByModel()
        {
            StudentModel student = new StudentModel()
            {
                StudentName ="Muzamil",
                FatherName =" Sarwar",
                Address =" Lahore",
                Age=28
                
            };
            return student;
        }
        private void SetStudentByViewBag()
        {
            StudentModel obj = new StudentModel()
            {
                StudentName = "Asad",
                FatherName = " Azam",
                Address = " ISB",
                Age = 30
            };

            ViewBag.xyz=obj;
        }

        // sending student model data via viewBag
        private void SetStudentByViewData()
        {
            StudentModel obj = new StudentModel()
            {
                StudentName = "Majid Ali",
                FatherName = "Azam ",
                Address = " ISB",
                Age = 32
            };

            ViewData["vdata"] = obj;

        }

        private List<SubjectModel> SetSubjectModel()
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            SubjectModel obj = new SubjectModel()
            {
                SubjectID = 10,
                SubjectName = "Computer",
                CreaditHourse = " 3 ",
                Insturctor_Name = "SanaUlllah",
                GPA = "4.0 "

            }; 
            SubjectModel ob1 = new SubjectModel()
            {
                SubjectID = 10,
                SubjectName = "Computer",
                CreaditHourse = " 3 ",
                Insturctor_Name = "SanaUlllah",
                GPA = "4.0 "

            };

            SubjectModel obj2 = new SubjectModel()
            {
                SubjectID = 10,
                SubjectName = "Computer",
                CreaditHourse = " 3 ",
                Insturctor_Name = "SanaUlllah",
                GPA = "4.0 "

            };
            subjects.Add(obj);
            subjects.Add(ob1);
            subjects.Add(obj2);
            return subjects;

        }


        private static SqlConnection _con;
        private static SqlCommand _cmd;
        private static SqlDataAdapter da;
        private static DataTable dt = new DataTable();
        public void DB()
        {
            string cons = "Data Source=DESKTOP-UL2SOTR;Initial Catalog=ClassLecture;Integrated Security=True";//"User ID=sa;Password=Alaska@123;";

            // SqlConnection _Con = new SqlConnection()

            _con = new SqlConnection(cons);
            _con.Open();

            _cmd = new SqlCommand("select * from birds", _con);

            SqlDataAdapter sda = new SqlDataAdapter(_cmd);
          
            sda.Fill(dt);


            _cmd.Dispose();
            
            _con.Close();
        }


        public void DBnonq()
        {
            string cons = "Data Source=DESKTOP-UL2SOTR;Initial Catalog=ClassLecture;Integrated Security=True";//"User ID=sa;Password=Alaska@123;";
            // SqlConnection _Con = new SqlConnection()

            _con = new SqlConnection(cons);
            _con.Open();

            _cmd = new SqlCommand("insert into birds (BirdName,TypeOfBird,ScientificName)values ('king','kong','pak')", _con);

            _cmd.ExecuteNonQuery();


            _cmd.Dispose();

            _con.Close();
        }


    }

   
}