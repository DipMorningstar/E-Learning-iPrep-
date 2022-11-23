using E_learning.Areas.TeacherArea.Models;
using E_learning.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class CourseTopic : Controller
    {
        public IActionResult Indexcoursetopic()
        {


           /// ViewData["topiclist"] = null;
            ViewData["CoursesList"] = GetCoursename();
            
            return View();
        }


        public IActionResult Deletecoursetopic(string id)
        {


          
            return View("Indexcoursetopic");
        }

        //public ActionResult Indexcoursetopic(string Course_name, string id, string dltbutton)
        //{
        //    if (dltbutton == "Delete")
        //    {
        //        String comstring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
        //        String updatedata = "Delete from Coursetopic" + Course_name;
        //        SqlConnection con = new SqlConnection(comstring);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandText = updatedata;
        //        cmd.Connection = con;
        //        cmd.ExecuteNonQuery();
        //        ViewBag.deletebutton = "disabled";
        //        ViewBag.updateresult = "Data Has been Deleted Successfully with Course_name" + Course_name;
        //          }
        //    return View("Index");
        //}


        //COURSE LIST
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
        // TOPIC LIST
        public IActionResult GetTopiclist()
        {

            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pTopiclist";
           
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@Coursecode",SqlDbType.VarChar).Value= Request.Form["CrList"].ToString();
            //SqlDataAdapter adp = new SqlDataAdapter(com);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
           


            //adp.Fill(dt);
            List<Showtopic> TopicList = new List<Showtopic>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Showtopic cnt = new Showtopic();
                cnt.Course_code = dt.Rows[i]["Course_code"].ToString();
                cnt.Topic_name = dt.Rows[i]["Topic_name"].ToString();
                cnt.Topic_Description = dt.Rows[i]["Topic_Description"].ToString();
                cnt.Topic_id = dt.Rows[i]["Topic_id"].ToString();
                
                cnt.Status = dt.Rows[i]["Status"].ToString();
                TopicList.Add(cnt);
                            }
            sqlcon.Close();
            ViewData["CoursesList"] = GetCoursename();
            ViewData["TopicList"] = TopicList;
            //  Indexcoursetopic();
           
            return View("Indexcoursetopic");
        }

        // ADD TOPIC AND QUESTIONS
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
    
            com.Parameters.AddWithValue("@Questions1", Request.Form["Question_1"].ToString());


            com.Parameters.AddWithValue("@Questions_option1A", Request.Form["Questions_options_A_1"].ToString());
            com.Parameters.AddWithValue("@Questions_option1B", Request.Form["Questions_options_B_1"].ToString());
            com.Parameters.AddWithValue("@Questions_option1C", Request.Form["Questions_options_C_1"].ToString());
            com.Parameters.AddWithValue("@Questions_option1D", Request.Form["Questions_options_D_1"].ToString());
            
            //if("@Questions1"=="@Questions_option1A")
            if(Request.Form["OptionA_1"].ToString()!="")
                com.Parameters.AddWithValue("@isAnswer1", "1");
            if (Request.Form["OptionB_1"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer1", "2");
            if (Request.Form["OptionC_1"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer1", "3");
            if (Request.Form["OptionD_1"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer1", "4");

            //com.Parameters.AddWithValue("@isAnswer1A", Request.Form["OptionA_1"].ToString());
            //com.Parameters.AddWithValue("@isAnswer1B", Request.Form["OptionB_1"].ToString());
            //com.Parameters.AddWithValue("@isAnswer1C", Request.Form["OptionC_1"].ToString());
            //com.Parameters.AddWithValue("@isAnswer1D", Request.Form["OptionD_1"].ToString());


            com.Parameters.AddWithValue("@Questions2", Request.Form["Question_2"].ToString());
            com.Parameters.AddWithValue("@Questions_option2A", Request.Form["Questions_options_A_2"].ToString());
            com.Parameters.AddWithValue("@Questions_option2B", Request.Form["Questions_options_B_2"].ToString());
            com.Parameters.AddWithValue("@Questions_option2C", Request.Form["Questions_options_C_2"].ToString());
            com.Parameters.AddWithValue("@Questions_option2D", Request.Form["Questions_options_D_2"].ToString());
            if (Request.Form["OptionA_2"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer2", "1");
            if (Request.Form["OptionB_2"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer2", "2");
            if (Request.Form["OptionC_2"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer2", "3");
            if (Request.Form["OptionD_2"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer2", "4");


            com.Parameters.AddWithValue("@Questions3", Request.Form["Question_1"].ToString());
            com.Parameters.AddWithValue("@Questions_option3A", Request.Form["Questions_options_A_3"].ToString());
            com.Parameters.AddWithValue("@Questions_option3B", Request.Form["Questions_options_B_3"].ToString());
            com.Parameters.AddWithValue("@Questions_option3C", Request.Form["Questions_options_C_3"].ToString());
            com.Parameters.AddWithValue("@Questions_option3D", Request.Form["Questions_options_D_3"].ToString());
            if (Request.Form["OptionA_3"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer3", "1");
            if (Request.Form["OptionB_3"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer3", "2");
            if (Request.Form["OptionC_3"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer3", "3");
            if (Request.Form["OptionD_3"].ToString() != "")
                com.Parameters.AddWithValue("@isAnswer3", "4");









            string msg = com.ExecuteScalar().ToString();
            sqlcon.Close();
            ViewBag.result = msg;
            ViewData["CoursesList"] = GetCoursename();
            /// Indexcoursetopic();
            return View("Indexcoursetopic");

        }
           // DYNAMIC TABLE FOR ECONTENT LIST
        public static string ConvertDataTableToHTML(DataTable dt)
        {
            string html = "<table class='table ucp-table'>";
            //add header row
            html += "<thead scope='col'>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<th>" + dt.Columns[i].ColumnName + "</th>";
            html += "</thead>";
            //add rows
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                    html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                html += "</tr>";
            }
            html += "</table>";
            return html;
        }

      //ECONTENT LIST 
        public ActionResult GetEcontentList(int TId)
        {

            String htmltable = "";
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            //SqlCommand cmd = new SqlCommand(" Select Econtent_type, Econtent_name from Econtent where Topic_Id=@Topic_id and Econtent_name <> ''", sqlcon);
            //sqlcon.Open();


            String pname = "spEcontent";

            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@Topicid", SqlDbType.VarChar).Value = TId.ToString();
            //SqlDataAdapter adp = new SqlDataAdapter(com);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);




            //adp.Fill(dt);
            htmltable = htmltable + ConvertDataTableToHTML(dt);
           

            //List<EContent> EcontentList  = new List<EContent>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    EContent cnt = new EContent();
            //    cnt.Econtent_name = dt.Rows[i]["Econtent_name"].ToString();
            //    cnt.Econtent_type = dt.Rows[i]["Econtent_type"].ToString();

            //    EcontentList.Add(cnt);
            //}


            sqlcon.Close();

           // ViewData["EcontentList"] = EcontentList;

            ////
            //  Indexcoursetopic();

            return Content(htmltable);
        }

    }
}

