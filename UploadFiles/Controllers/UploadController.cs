using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadFiles.Models;

namespace UploadFiles.Controllers
{
    public class UploadController : Controller
    {
        private UploadFileContext db = new UploadFileContext();

        //
        // GET: /Upload/

        public ActionResult Index()
        {
            return View(db.Upload.ToList());
        }

        public ActionResult Download(int id = 0)
        {
            Upload upload = db.Upload.Find(id);
            
            if (upload != null)
                return File(upload.Conteudo, "application/pdf");

            return View(upload);
        }

        //
        // GET: /Upload/Details/5

        public ActionResult Details(int id = 0)
        {
            Upload upload = db.Upload.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        //
        // GET: /Upload/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Upload/Create

        [HttpPost]
        public ActionResult Create(Upload upload)
        {
            if (ModelState.IsValid)
            {
                db.Upload.Add(upload);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(upload);
        }

        //
        // GET: /Upload/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Upload upload = db.Upload.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        //
        // POST: /Upload/Edit/5

        [HttpPost]
        public ActionResult Edit(Upload upload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(upload).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upload);
        }

        //
        // GET: /Upload/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Upload upload = db.Upload.Find(id);
            if (upload == null)
            {
                return HttpNotFound();
            }
            return View(upload);
        }

        //
        // POST: /Upload/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Upload upload = db.Upload.Find(id);
            db.Upload.Remove(upload);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}