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
            String constring = "Data Source =LAPTOP-5EKSJTJN\\SQLEXPRESS; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pMycoursegrid";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            return View(dt);

        }
    }
}
