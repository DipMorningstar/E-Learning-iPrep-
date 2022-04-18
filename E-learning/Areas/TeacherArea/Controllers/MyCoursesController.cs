﻿using Microsoft.AspNetCore.Mvc;
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
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            return View(dt);

        }
        public ActionResult IndexmyCourses(string Course_name, string dltbutton)
        { 
            if (dltbutton == "Delete")
            {
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                String updatedata = "Delete from Courses where where Course_code=" + Course_name;
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                ViewBag.deletebutton = "";
                ViewBag.updateresult = "Data Has been Deleted Successfully with Course_name" + Course_name;
            }
            return View();
        }
    }
}
