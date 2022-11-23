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
    public class SavedCourseController : Controller
    {
        public IActionResult IndexSavedCourse( string SavedCourse_id)
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spCourseSaved";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.Parameters.AddWithValue("@UserId", HttpContext.Session.GetString("User_id"));
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ViewData["CountofCourses"] = dt.Rows.Count;
            ViewData["UserId"] = HttpContext.Session.GetString("User_id");
           

            return View(dt);
            
        }

        // DELETE SAVED COURSE INDIVIDUALLY
        public IActionResult DeleteSavedCourse(string SavedCourse_id)
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spRemove_saved_courses";


            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@UserId", HttpContext.Session.GetString("User_id"));
            com.Parameters.AddWithValue("@SavedCourseid", SavedCourse_id);
            sqlcon.Open();
            com.ExecuteNonQuery();


            return RedirectToAction("IndexSavedCourse");
        }


        // DELETE ALL SAVED COURSE AT ONE CLICK REMOVE BUTTON
        public IActionResult DeleteAllSavedCourse(string SavedCourse_id)
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spRemoveAll_saved_courses";


            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@UserId", HttpContext.Session.GetString("User_id"));

            sqlcon.Open();
            com.ExecuteNonQuery();


            return RedirectToAction("IndexSavedCourse");
        }
    }
}
