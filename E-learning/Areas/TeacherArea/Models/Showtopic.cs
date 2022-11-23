using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learning.Areas.TeacherArea.Models
{
    public class Showtopic
    {
        public string Course_code { get; set; }
        public string Course_name { get; set; }
        public string Topic_id { get; set; }
        public string Topic_name { get; set; }
        public string Topic_Description { get; set; }
        public string Video { get; set; }
        public string Status { get; set; }
        public string attachment { get; set; }
        public string external_link { get; set; }
    }
    public class EContent
    {
        public string Econtent_name { get; set; }
        public string Econtent_type { get; set; }
        public string Topic_id { get; set; }
    }
}
