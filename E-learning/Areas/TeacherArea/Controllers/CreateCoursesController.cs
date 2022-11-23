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
            //TempData["AlertMessage"] = "Course saved";
            ViewBag.result = "";
            return View();
        }
        //[HttpPost]

        //ADD COURSES
        public ActionResult IndexcreatecoursesSave()
        {
            try
            {
                String constring = "Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True ";
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
                com.Parameters.AddWithValue("@Course_Image", Request.Form["convertImg"].ToString());
                com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id").ToString());
                string msg = com.ExecuteScalar().ToString();
                sqlcon.Close();

                TempData["Msg"] = msg;

               // TempData["AlertMessage"] = "Course saved";
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Error Occured. Kindly Try Again Later";

                // TempData["AlertMessage"] = "Course saved";
                //if (sqlcon.state == system.data.connectionstate.open)
                //{
                //    sqlcon.close();
                //}
                //return "error occured.kindly try again later.";
            }
            return View("Indexcreatecourses");
        }
    }
}