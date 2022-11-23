using E_learning.Areas.TeacherArea.Models;
using E_learning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class TeacherHome : Controller
    {
        public IActionResult Indexteacherhome()
        {
            if (HttpContext.Session.GetString("User_id") != "")
            {
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "spTeacherCourseDetails";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@UserId", HttpContext.Session.GetString("User_id"));
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                ViewData["Teacherdashboard"] = TeacherDashboard();
                ViewData["TeacherID"] = HttpContext.Session.GetString("User_id");


                DataTable dtr = new DataTable();
                dtr = TeacherDashboard();

       

                ViewData["TotalCourses"] = dtr.Rows[0]["CoursesCount"].ToString();
                ViewData["TotalEnrolled"] = dtr.Rows[0]["StudentsEnrolled"].ToString();
                ViewData["TotalStudents"] = dtr.Rows[0]["TotalStudents"].ToString();
                return View(dt);
            }
               else
            {
                return Redirect("../../SignInSignUp/IndexSignIn");
            }

            }
        public DataTable TeacherDashboard()
        {
            String constring = "Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pDashboard";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@TeacherId", HttpContext.Session.GetString("User_id"));
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;


        }

       
    }
}
