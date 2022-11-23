using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.StudentArea.Controllers
{
    [Area("StudentArea")]
    public class ShowCoursesListController : Controller
    {
        //TO SHOW COURSES THAT'S BEEN CREATED BY FACULTY/TEACHER
        public IActionResult IndexShowCoursesList(string SavedCourse_id)
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spMyCourses";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id"));
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ViewData["UserId"] = HttpContext.Session.GetString("User_id");


            return View(dt);

        }
    }
}
