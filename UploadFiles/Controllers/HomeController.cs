using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class HomeController : Controller
    {
        UploadFileContext db = new UploadFileContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UploadFile()
        {
            ViewData["Success"] = string.Empty;
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(string titulo)
        {
            try
            {
                byte[] conteudo;
                using (var binaryReader = new BinaryReader(Request.Files["file"].InputStream))
                {
                    conteudo = binaryReader.ReadBytes(Request.Files["file"].ContentLength);
                }

                db.Upload.Add(new Upload() { Titulo = titulo, Conteudo = conteudo });
                db.SaveChanges();

                ViewData["Success"] = "Success";
            }
            catch (Exception)
            {
                ViewData["Success"] = "Upload Failed";
            }

            return View();
        }

        public ActionResult DownloadFile(int id)
        {
            Upload upload = db.Upload.FirstOrDefault(m => m.IDUpload == id);
            if(upload != null)
                return new FileContentResult(upload.Conteudo, "application/pdf");

            return View();
        }
    }
}
