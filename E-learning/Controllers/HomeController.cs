using E_learning.Areas.TeacherArea.Models;
using E_learning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Indexlandingpage()
        {
            String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pCourseDetails";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            return View(dt);


            //ViewBag.result = "";
            //return View();
            //ViewData["CoursesDetails"] = GetCourseDetails();
            //return View();
        }
         
        //public List<CourseDetails> GetCourseDetails()
        //{

        //    String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
        //    SqlConnection sqlcon = new SqlConnection(constring);
        //    String pname = "pCreateNewCourse";
        //    sqlcon.Open();
        //    SqlCommand com = new SqlCommand(pname, sqlcon);
        //    com.CommandType = CommandType.StoredProcedure;

        //    com.Parameters.AddWithValue("@Course_name", Request.Form["Course_name"].ToString());
        //    com.Parameters.AddWithValue("@Course_Title", Request.Form["Course_Title"].ToString());
        //    com.Parameters.AddWithValue("@Course_Description", Request.Form["Course_Description"].ToString());
        //    com.Parameters.AddWithValue("@Course_Category", Request.Form["Course_Category"].ToString());
        //    com.Parameters.AddWithValue("@Course_Level", Request.Form["Course_Level"].ToString());

        //    SqlDataAdapter adp = new SqlDataAdapter(com);
        //    DataTable dt = new DataTable();


        //    adp.Fill(dt);
        //    List<CourseDetails> Courses = new List<CourseDetails>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        CourseDetails cnt = new CourseDetails();
        //        cnt.Course_name = dt.Rows[i]["Course_name"].ToString();
        //        cnt.Course_Title = dt.Rows[i]["Course_Title"].ToString();
        //        cnt.Course_Description = dt.Rows[i]["Course_Description"].ToString();
        //        cnt.Course_Category = dt.Rows[i]["Course_Category"].ToString();
        //        cnt.Course_Level = dt.Rows[i]["Course_Level"].ToString();

        //        Courses.Add(cnt);

        //    }

        //    return Courses;
       // }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
