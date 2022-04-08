using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class TeacherHome: Controller
    {
        public IActionResult Indexteacherhome()
        {
            return View();
        }
    }
}
