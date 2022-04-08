using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Web.
using E_learning.Models;
using Grpc.Core;

namespace E_learning.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload    
        public ActionResult Index()
        {
            return View();
        }

        public static class MyServer
        {
            public static string MapPath(string path)
            {
                return Path.Combine(
                    (string)AppDomain.CurrentDomain.GetData("ContentRootPath"),
                    path);
            }
        }

        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {

          
            if (ModelState.IsValid)
            {
                try
                {


                    if (file != null)
                    {
                        string path = HttpContext.Current.Server.MapPath("");` //Path.Combine(MyServer.MapPath("~/CourseImages"), Path.GetFileName(file.CourseImages));
                        file.SaveAs(path);

                      


                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                }
                catch (Exception)
                {

                    ViewBag.FileStatus = "Error while file uploading.";
                }

            }
            return View("Index");
        }
    }
}
