using E_learning.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Models
{
    public class CreateNewTopic
    {

        [Required]
        public String Course_code { get; set; }

        [Required]
        public String Topic_name { get; set; }

        [Required]
        public String Topic_Descripton { get; set; }

        [Required]
        public String videoUrl { get; set; }

        [Required]
        public String FileName { get; set; }
    }
}

  
