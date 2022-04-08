using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.ProjectArea.Controllers
{
    //[Area("ProjectArea")]
    public class ForgetPassword : Controller
    {
       
        public IActionResult IndexForgetPasssword()
        {
            return View();
        }
    }
}
