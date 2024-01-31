using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourseAssign.Models;

namespace WebAppCourseAssign.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> listcourses = new List<Course>()
        {
            new Course{ Id=1,Name="Sam",Fee=5000,Technology="Java",Start=new DateTime(day:23,month:11,year:2019),End=new DateTime(day:23,month:02,year:2020)},
            new Course{ Id=2,Name="Saranya",Fee=3000,Technology="Python",Start=new DateTime(day:22,month:06,year:2020),End=new DateTime(day:05,month:08,year:2020)},
            new Course{ Id=3,Name="Rithu",Fee=4000,Technology="AI",Start=new DateTime(day:13,month:11,year:2022),End=new DateTime(day:05,month:02,year:2023)},
            new Course{ Id=4,Name="Gaja",Fee=6000,Technology="MachineLearning",Start=new DateTime(day:26,month:05,year:2019),End=new DateTime(day:23,month:09,year:2019)},
            new Course{ Id=5,Name="Naziya",Fee=4500,Technology="Devops",Start=new DateTime(day:15,month:06,year:2023),End=new DateTime(day:26,month:10,year:2023)},
        };


        public ActionResult Index()
        {
            return View(listcourses);
        }
    }
}