using E_learning.Areas.TeacherArea.Models;
using E_learning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Indexlandingpage()
        {
            if (HttpContext.Session.Keys.Count()==0)
            {
                HttpContext.Session.SetString("User_id", "");
            }
            String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "pCourseDetails";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return View(dt);


        }
         
        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
