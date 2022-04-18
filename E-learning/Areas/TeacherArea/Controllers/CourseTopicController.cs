using E_learning.Areas.TeacherArea.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class CourseTopic : Controller
    {
        public IActionResult Indexcoursetopic()
        {


           // ViewData["topiclist"] = null;
            ViewData["CoursesList"] = GetCoursename();
            return View();
        }

        public ActionResult Indexcoursetopic(string Course_name, string dltbutton)
        {
            if (dltbutton == "Delete")
            {
                String comstring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                String updatedata = "Delete from Coursetopic" + Course_name;
                SqlConnection con = new SqlConnection(comstring);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ViewBag.deletebutton = "disabled";
                ViewBag.updateresult = "Data Has been Deleted Successfully with Course_name" + Course_name;
                  }
            return View("Index");
        }
        public List<CourseList> GetCoursename()
        {

            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select Course_code,Course_id,Course_name from Courses where Course_name<>'' and Status='Active'", sqlcon);
            //sqlcon.Open();
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            adp.Fill(dt);
            List<CourseList> dd = new List<CourseList>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CourseList cnt = new CourseList();
                cnt.CourseCode = dt.Rows[i]["Course_code"].ToString();
                cnt.coursename = dt.Rows[i]["Course_name"].ToString();
                cnt.courseId = Convert.ToInt32(dt.Rows[i]["Course_id"].ToString());
                dd.Add(cnt);

            }

            return dd;
        }

        public IActionResult GetTopiclist()
        {

            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pTopiclist";
           
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@Coursecode",SqlDbType.VarChar).Value= Request.Form["CrList"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter(com);
            DataTable dt = new DataTable();


            adp.Fill(dt);
            List<Showtopic> TopicList = new List<Showtopic>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Showtopic cnt = new Showtopic();
                cnt.Course_code = dt.Rows[i]["Course_code"].ToString();
                cnt.Topic_name = dt.Rows[i]["Topic_name"].ToString();
                cnt.Topic_Description = dt.Rows[i]["Topic_Description"].ToString();
                cnt.Topic_name = dt.Rows[i]["Course_name"].ToString();
              
                TopicList.Add(cnt);

            }
            sqlcon.Close();
            ViewData["CoursesList"] = GetCoursename();
            ViewData["TopicList"] = dt;
            //  Indexcoursetopic();
            return RedirectPermanent("Indexcoursetopic");
        }


        public ActionResult TopicLecture()
        {
            
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pTopicLecture";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Topic_name", Request.Form["Topic_name"].ToString());
            com.Parameters.AddWithValue("@CourseCode", Request.Form["CrList"].ToString());
            com.Parameters.AddWithValue("@Topic_Description", Request.Form["Topic_Description"].ToString());
            com.Parameters.AddWithValue("@videoUrl", Request.Form["videoUrl"].ToString());
            com.Parameters.AddWithValue("@Url", Request.Form["Url"].ToString());
            com.Parameters.AddWithValue("@FileName", Request.Form["FileName"].ToString());

            string msg = com.ExecuteScalar().ToString();
            sqlcon.Close();
            ViewBag.result = msg;
            ViewData["CoursesList"] = GetCoursename();
            /// Indexcoursetopic();
            return View("Indexcoursetopic");

        }
    }
}

