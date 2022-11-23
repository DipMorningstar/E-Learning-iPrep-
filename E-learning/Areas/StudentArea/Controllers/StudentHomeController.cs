using E_learning.Areas.StudentArea.Model;
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
    public class StudentHomeController : Controller
    {
        public IActionResult IndexStudentHome(string gg)
        {
            
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "pCourseDetails";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                com.Parameters.AddWithValue("@UserId", HttpContext.Session.GetString("User_id"));
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                ViewData["Enrolled"] = EnrollCourse();
                ViewData["UserId"] = HttpContext.Session.GetString("User_id");

               
                return View(dt);
           
            
        }


        // ENROLLED COURSE BY STUDENT ONLY
        public IActionResult EnrolledCourse(String Course_id)
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
            return Redirect("IndexStudentHome");
        }

        //PROGRESS BAR CARD
        public List<StudentHome> EnrollCourse( )
        {
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spEnrolledstudent";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@User_id", HttpContext.Session.GetString("User_id"));

            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            List<StudentHome> DtValue = new List<StudentHome>();
            for( int i=0;i<dt.Rows.Count;i++)
            {
                StudentHome EC = new StudentHome();
                EC.User_id = dt.Rows[i]["User_id"].ToString();
                EC.Enroll_id = dt.Rows[i]["Enroll_id"].ToString();
                EC.Course_id = dt.Rows[i]["Course_id"].ToString();
                EC.Course_name = dt.Rows[i]["Course_name"].ToString();
                EC.Course_Category = dt.Rows[i]["Course_Category"].ToString();
                EC.Course_Image = dt.Rows[i]["Course_Image"].ToString();
                EC.Percentage = dt.Rows[i]["ProgressPercent"].ToString();
                DtValue.Add(EC);
            }
            return DtValue;
        }


        //public ActionResult Search(string searchbar)
        //{
        //    String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
        //    SqlConnection sqlcon = new SqlConnection(constring);
        //    String pname = "Select * from Courses where Course_name like'%"+searchbar+"%'";
        //    SqlCommand com = new SqlCommand(pname, sqlcon);
        //    sqlcon.Open();
        //    SqlDataAdapter da = new SqlDataAdapter(com);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    List<StudentHome> SH = new List<StudentHome>;


        //}
       

    }
}
