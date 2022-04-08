using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Models
{
    public class CreateNewTopic
    {
        public String Course_code { get; set; }
        public List<CourseList> Course_name { get; set; }
        public String Topic_name { get; set; }
        public String Econtent_name { get; set; }
    }
}
