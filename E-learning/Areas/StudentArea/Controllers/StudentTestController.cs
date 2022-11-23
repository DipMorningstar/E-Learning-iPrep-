
using E_learning.Areas.StudentArea.Model;
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
    public class StudentTestController : Controller
    {
        public IActionResult IndexStudentTest(int Topic_id)
        {
            ViewData["Question"] = Questions(Topic_id);
            return View();
        }

        //Questions and options
        public List<StudentTest>Questions(int Topic_id)
            {
            String constring = "Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True ";
            SqlConnection sqlcon = new SqlConnection(constring);
            String pname = "spQuestion";
            sqlcon.Open();
            SqlCommand com = new SqlCommand(pname, sqlcon);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Topic_id", Topic_id);

            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(dr);
            List<StudentTest> DtValue = new List<StudentTest>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StudentTest ff = new StudentTest();

                
                ff.Questions = dt.Rows[i]["Questions"].ToString();
                ff.QuestionsId = dt.Rows[i]["QuestionBank_id"].ToString();

                //ff.Options_2 = dt.Rows[i]["Options_2"].ToString();
                //ff.Options_3 = dt.Rows[i]["Options_3"].ToString();
                //ff.Options_4 = dt.Rows[i]["Options_4"].ToString();
                ff.Question_option = dt.Rows[i]["Question_option"].ToString();
                //ff.Question_option = dt.Rows[i]["Question_option"].ToString();
                //ff.Question_option = dt.Rows[i]["Question_option"].ToString();
                //ff.Question_option = dt.Rows[i]["Question_option"].ToString();


                DtValue.Add(ff);
            }

            return DtValue;
        }

    }
}