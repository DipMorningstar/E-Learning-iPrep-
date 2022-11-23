using E_learning.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace E_learning.Controllers
{
    public class SignInSignUpController : Controller
    {
        private SqlConnection con = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=PBC; Trusted_Connection=True");
        private SqlCommand com = new SqlCommand();
        private SqlDataReader dr;
        private string str;
        private readonly IUsers iu;
        public IActionResult IndexSignIn()
        {
            HttpContext.Session.SetString("User_id", "");
            
            return View();
        }
        public IActionResult Login(string User_email, string Password,string User_name)
        {
            DataTable dt = new DataTable();
            dt = VerifyUser(User_name, Password, User_email);
            
            if (dt.Rows[0]["Msg"].ToString() == "valid User")
            {
                //create session layout
                HttpContext.Session.SetString("Layout",dt.Rows[0]["Layout"].ToString());

                //create session login
                HttpContext.Session.SetString("User_id", dt.Rows[0]["User_id"].ToString());
                HttpContext.Session.SetString("User_Name", dt.Rows[0]["Name"].ToString());
                return RedirectPermanent(dt.Rows[0]["Url"].ToString());
                
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("IndexSignIn");
            }
        }


        public IActionResult IndexSignUp()
        {
            return View();
        }
        public string RegisterFunction(Users u)
        {
            string msg = "";
            try
            {
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "psignup";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                com.Parameters.AddWithValue("@User_name", Request.Form["User_name"].ToString());
                com.Parameters.AddWithValue("@Password", Request.Form["Password"].ToString());
                com.Parameters.AddWithValue("@User_email", Request.Form["User_email"].ToString());
                com.Parameters.AddWithValue("@User_Phone", Request.Form["User_Phone"].ToString());
                com.Parameters.AddWithValue("@DateOfBirth", Request.Form["DateOfBirth"].ToString());
                com.Parameters.AddWithValue("@User_Gender", Request.Form["User_gender"].ToString());
                com.Parameters.AddWithValue("@RoleId", Request.Form["User_role"].ToString());

                com.CommandType = CommandType.StoredProcedure;
                msg = com.ExecuteScalar().ToString();
                con.Close();
                return msg;
                //return true;
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                return "Error Occured.Kindly Try again Later.";
                ///return false;
            }
        }
        //login verifie
        public DataTable VerifyUser(string Username, string password,string Useremail)
        {
            DataTable dt = new DataTable();
            try
            {
                //con.Open();
                //com.Connection = con;
                //com.CommandText = "Select User_id from Users where User_email='" + Username + "' and Password='" + password + "'";
                String constring = "Data Source =(localdb)\\Local; Initial Catalog = PBC; Trusted_Connection = True";
                SqlConnection sqlcon = new SqlConnection(constring);
                String pname = "PSignIn";
                sqlcon.Open();
                SqlCommand com = new SqlCommand(pname, sqlcon);
                
               
                com.Parameters.AddWithValue("@User_email", Useremail);
                com.Parameters.AddWithValue("@Password", password);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(com);
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                return dt;
            }
        }
        public IActionResult Register(Users u)
        {
            string x = RegisterFunction(u);
            TempData["message"] = x.ToString();
            //return RedirectToAction("IndexSignUp");
            return RedirectToAction("IndexSignUp");
        }
        public ValidationError Validation(Users u)
        {
            ValidationError ve = new ValidationError();
            if (u.User_name == null || u.User_email == null || u.Password == null)
            {
                ve.retval = false;
                ve.retmsg = "Input can no be blank.";
                return ve;
            }
            else if (iu.FindDuplicate(u.User_email) == false)
            {
                ve.retval = false;
                ve.retmsg = "You have already registered with this email.";
                return ve;
            }
            else if (u.Password.Length < 8 || u.Password.Length > 12)
            {
                ve.retval = false;
                ve.retmsg = "Password must be more than 8 and less than 12 characters.";
                return ve;
            }

            else
            {
                ve.retval = true;
                ve.retmsg = null;

                return ve;
            }
        }
    }
}