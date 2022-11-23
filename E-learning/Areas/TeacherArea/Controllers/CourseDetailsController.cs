using E_learning.Areas.TeacherArea.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class CourseDetailsController : Controller
    {

        
        public IActionResult IndexCourseDetails(string Course_id)
        {
            String constring = "Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True ";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pgetSingleCourseDetails";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Course_id", Course_id);
            com.Parameters.AddWithValue("@userid", HttpContext.Session.GetString("User_id"));

            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            //return session viewData
            if(HttpContext.Session.GetString("Layout") == null)
            {
                ViewData["layout"] = "";
            }
            ViewData["layout"] = HttpContext.Session.GetString("Layout");
            ViewData["Topics"] = Gettopic(Course_id);
            var session = HttpContext.Session.GetString("User_id");

            if (session == "")
            {
                return Redirect("../../SignInSignUp/IndexSignIn");
            }
            else

                return View(dt);

        }

        //TO SHOW TOPIC OF COURSE 
        public List<Showtopic> Gettopic(string Courseid)
        {

            String constring = "Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True ";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spTopic_EcontentDetails";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Course_code", Courseid);

            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            List<Showtopic> DtValue = new List<Showtopic>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Showtopic ff = new Showtopic();
                ff.Course_code = dt.Rows[i]["Course_code"].ToString();
                ff.Topic_id = dt.Rows[i]["Topic_id"].ToString();
                ff.Topic_name = dt.Rows[i]["Topic_name"].ToString();
                ff.Topic_Description = dt.Rows[i]["Topic_Description"].ToString();
                ff.Video = dt.Rows[i]["video"].ToString();
                ff.attachment = dt.Rows[i]["Attachment"].ToString();
                ff.external_link = dt.Rows[i]["External Link"].ToString();


                DtValue.Add(ff);
            }

            return DtValue;
        }


        // ENROLL COURSE (ENROLL BUTTON)
        public IActionResult EnrollCourse(String Course_id)
        {

            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spEnroll";


            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id"));
            com.Parameters.AddWithValue("@Course_id", Course_id);
            sqlcon.Open();
            com.ExecuteNonQuery();
            return Redirect("IndexCourseDetails?Course_id=" + Course_id);
        }


        // SAVE COURSE FOR FUTURE PURPOSE (SAVE BUTTON)
        public IActionResult SaveCourse(String CId)
        {
            string html = "";
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spSavedCourse";

            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id"));
            com.Parameters.AddWithValue("@Course_id", CId.ToString());
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Load(dr);
            com.ExecuteNonQuery();html = "success";
            return Content(html);
        }

        //FOR PROGRESS BAR ( TOPIC WISE LOG)
        public ActionResult Userlog(string TId)
        {
            string html = "";
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            string pname = "spUserLog";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Topic_id", TId.ToString());
            com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id"));
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            com.ExecuteNonQuery();
            html = "success";
            return Content(html);
        }
    }
}