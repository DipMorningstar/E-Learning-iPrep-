using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Models
{
    interface IUsers
    {
        bool Verify(string User_email, string Password);

        bool Register(Users u);

        bool FindDuplicate(string User_email);
    }
}
