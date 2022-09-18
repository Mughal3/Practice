using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentModel student = new StudentModel();
            //ViewBag.First = "Muzamil";

            student = SetStudentByModel();
            SetStudentByViewBag();
            SetStudentByViewData();
            return View(student);
        }
        public StudentModel SetStudentByModel()
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
        public void SetStudentByViewBag()
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

        public void SetStudentByViewData()
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
    }
}