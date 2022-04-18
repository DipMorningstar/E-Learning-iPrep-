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
        
        public String Topic_name { get; set; }
        public String Topic_Descripton { get; set;  }
        public String videoUrl { get; set; }
        public String FileName { get; set; }
    }
}
