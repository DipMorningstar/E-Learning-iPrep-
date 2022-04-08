using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using E_learning.Areas.TeacherArea.Models;
using System.Linq;
using System.Threading.Tasks;
 
using System.Configuration;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class CreateCoursesController : Controller
    {
        public ActionResult Indexcreatecourses()
        {
            ViewBag.result = "";
            return View();
        }
        //[HttpPost]
        public ActionResult IndexcreatecoursesSave()
        {
            String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pCreateNewCourse";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;

            //com.Parameters.Add("@Course_name", SqlDbType.VarChar).Value = Request.Form["Course_name"];

            com.Parameters.AddWithValue("@Course_name", Request.Form["Course_name"].ToString());
            com.Parameters.AddWithValue("@Course_Title", Request.Form["Course_Title"].ToString());
            com.Parameters.AddWithValue("@Course_Description", Request.Form["Course_Description"].ToString());
            com.Parameters.AddWithValue("@Course_Category", Request.Form["Course_Category"].ToString());
            com.Parameters.AddWithValue("@Course_Level", Request.Form["Course_Level"].ToString());
            com.Parameters.AddWithValue("@Course_Image", Request.Form["Course_Image"].ToString());
            string msg=com.ExecuteScalar().ToString();
            sqlcon.Close();
            ViewBag.result = msg;
            return View("Indexcreatecourses");
        }

    }
}



