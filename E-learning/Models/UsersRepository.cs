using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_learning.Models;
using System.Data.SqlClient;

namespace E_learning.Models
{
    public class UsersRepository : IUsers
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-5EKSJTJN\\SQLEXPRESS;Initial Catalog=PBC; Trusted_Connection=True");
        private SqlCommand com = new SqlCommand();
        private SqlDataReader dr;

        private string str;

        public UsersRepository(string str)
        {
            this.str = str;
        }

        public bool FindDuplicate(string User_email)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From Users101 where User_email='" + User_email + "'";
            dr = com.ExecuteReader();

            List<Users> u = new List<Users>();

            while (dr.Read())
            {
                var x = new Users
                {
                    User_name = dr.GetString(0),
                    User_email=dr.GetString(1),
                    Password=dr.GetString(3)
                };

                u.Add(x);
            }

            con.Close();

            if (u.Count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Verify(string User_email, string Password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from Users101 where User_email='" + User_email + "' and Password='" + Password + "'";
            dr = com.ExecuteReader();

            List<Users> u = new List<Users>();

            while(dr.Read())
            {
                var x = new Users()
                {
                    User_name = dr.GetString(1),
                    User_email = dr.GetString(2),
                    Password = dr.GetString(3),
                    //confirmpass = null
                };

                u.Add(x);
            }

            con.Close();

            if (u.Count==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
