using System;

namespace E_learning.Controllers
{
    public class HttpPostedFileBase
    {
        public string CourseImages { get; internal set; }

        internal void SaveAs(string path)
        {
            throw new NotImplementedException();
        }
    }
}