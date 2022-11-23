using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Enter your Name")]
        public string User_name { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}"+ @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @" .)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Email is not valid")]
        public string User_email { get; set; }


        [Required(ErrorMessage = "Enter your Phone Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Phone Number is not Valid")]
        public int User_Phone { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string User_gender { get; set; }
        public string User_role { get; set; }


    }
}
