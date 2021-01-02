using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using finalproje1;
using finalproje1.Models;

namespace finalproje1.Controllers
{
    public class DeleteUsersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: DeleteUsers
        public ActionResult Index()
        {
            return View(db.DeleteUsers.ToList());
        }

        // GET: DeleteUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeleteUsers deleteUsers = db.DeleteUsers.Find(id);
            if (deleteUsers == null)
            {
                return HttpNotFound();
            }
            return View(deleteUsers);
        }

        // GET: DeleteUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeleteUsers/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] DeleteUsers deleteUsers)
        {
            if (ModelState.IsValid)
            {
                db.DeleteUsers.Add(deleteUsers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deleteUsers);
        }

        // GET: DeleteUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeleteUsers deleteUsers = db.DeleteUsers.Find(id);
            if (deleteUsers == null)
            {
                return HttpNotFound();
            }
            return View(deleteUsers);
        }

        // POST: DeleteUsers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] DeleteUsers deleteUsers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deleteUsers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deleteUsers);
        }

        // GET: DeleteUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeleteUsers deleteUsers = db.DeleteUsers.Find(id);
            if (deleteUsers == null)
            {
                return HttpNotFound();
            }
            return View(deleteUsers);
        }

        // POST: DeleteUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeleteUsers deleteUsers = db.DeleteUsers.Find(id);
            db.DeleteUsers.Remove(deleteUsers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
