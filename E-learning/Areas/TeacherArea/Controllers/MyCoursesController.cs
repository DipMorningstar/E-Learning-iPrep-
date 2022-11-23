using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class MyCoursesController : Controller
    {

        public IActionResult Indexmycourses()
        {
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "pMycoursegrid";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@TeacherId", HttpContext.Session.GetString("User_id"));
            SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                return View(dt);

            
        }

        //UPDATE COURSES -----------!!!!!!!!  INCOMPLETE CRUD OPERATION  !!!!!!
        public IActionResult updatecourse(string Course_id)
        {

            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spUpdateMyCoursegrid";


            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Courseid", Course_id);
            com.Parameters.AddWithValue("@Course_name", Request.Form["Course_name"].ToString());
            com.Parameters.AddWithValue("@Course_Title", Request.Form["Course_tile"].ToString());
            com.Parameters.AddWithValue("@Course_Category", Request.Form["Course_Category"].ToString());

            sqlcon.Open();
            com.ExecuteNonQuery();
            return new EmptyResult();
        }




        // DELETE COURSES----------  !!!!!!!  DELETE IS WORKING PARTIALLY FROM CRUD OPERATION !!!!!!!!!
        public IActionResult deletecourse(string Course_id)
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pDeleteMycoursegrid";

            
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Courseid", Course_id);
             sqlcon.Open();
             com.ExecuteNonQuery();


          return RedirectToAction("Indexmycourses");
        }

    }
}
