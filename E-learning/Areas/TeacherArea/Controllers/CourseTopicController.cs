using E_learning.Areas.TeacherArea.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class CourseTopic : Controller
    {
        public IActionResult Indexcoursetopic()
        {

            //List<CreateNewTopic> Coursetopic = new List<CreateNewTopic>();
            //String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            //SqlConnection sqlcon = new SqlConnection(constring);
            //// = "Select * from Courses where Course_name='" + Course_name + "'";
            ////sqlcon.Open();

            ////SqlCommand com = new SqlCommand();
            //////com.CommandType = CommandType.StoredProcedure;
            //////com.Parameters.AddWithValue("@id", Request.Form["SelectList"].ToString());
            /////


            //SqlDataReader rdr = com.ExecuteReader();
            //while (rdr.Read())
            //{
            //    CreateNewTopic cnt = new CreateNewTopic();
            //    cnt.Course_name = rdr["Course_name"].ToString();
            //    Coursetopic.Add(cnt);
            //}
            //SelectList list = new SelectList(Coursetopic, "Course_name", "Course_name");
            //ViewBag.DropdownList = list;

            ViewData["CoursesList"] = GetCoursename();
            return View();
        }

        //public ActionResult DropdownControl()
        //{
        //    CreateNewTopic dropdown_list = new CreateNewTopic
        //    {
        //        Course_name = GetCoursename()
        //    };
        //    return View(dropdown_list);
        //}
        public List<CourseList> GetCoursename()
        {

            String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select Course_code,Course_id,Course_name from Courses where Course_name<>'' and Status='Active'", sqlcon);
            //sqlcon.Open();
            cmd.Connection = sqlcon;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
         
          
            adp.Fill(dt);
            List<CourseList> dd = new List<CourseList>();
            for(int i=0; i<dt.Rows.Count;i++)
            {
                CourseList cnt = new CourseList();
                cnt.CourseCode = dt.Rows[i]["Course_code"].ToString();
                cnt.coursename = dt.Rows[i]["Course_name"].ToString();
                cnt.courseId = Convert.ToInt32(dt.Rows[i]["Course_id"].ToString());
                dd.Add(cnt);

            }

            return dd;
        }
        
        public ActionResult TopicLecture()
        {
            String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pTopiclecture";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;

            //com.Parameters.Add("@Course_name", SqlDbType.VarChar).Value = Request.Form["Course_name"];

            com.Parameters.AddWithValue("@Topic_name", Request.Form["Topic_name"].ToString());

            string msg = com.ExecuteScalar().ToString();
            sqlcon.Close();
            
            ViewBag.result = msg;
            return View("Indexcoursetopic");
        }
    }
}
    
