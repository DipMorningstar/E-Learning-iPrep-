using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Models
{
    public class CreateQuestion
    {
        public int QuestionBank_id { get; set; }
        public String Questions { get; set; }
        public String Question_option { get; set; }
        public Char isAnswer { get; set; }
    }
}
