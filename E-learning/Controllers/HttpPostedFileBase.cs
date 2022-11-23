using System;
using System.IO;

namespace E_learning.Controllers
{
    public class HttpPostedFileBase
    {
        public string CourseImages { get; internal set; }
        public Stream InputStream { get; internal set; }

        internal void SaveAs(string path)
        {
            throw new NotImplementedException();
        }
    }
}