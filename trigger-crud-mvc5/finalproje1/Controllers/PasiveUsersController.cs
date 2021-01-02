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
    public class PasiveUsersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: PasiveUsers
        public ActionResult Index()
        {
            return View(db.PasiveUsers.ToList());
        }

        // GET: PasiveUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PasiveUser pasiveUser = db.PasiveUsers.Find(id);
            if (pasiveUser == null)
            {
                return HttpNotFound();
            }
            return View(pasiveUser);
        }

        // GET: PasiveUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PasiveUsers/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] PasiveUser pasiveUser)
        {
            if (ModelState.IsValid)
            {
                db.PasiveUsers.Add(pasiveUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pasiveUser);
        }

        // GET: PasiveUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PasiveUser pasiveUser = db.PasiveUsers.Find(id);
            if (pasiveUser == null)
            {
                return HttpNotFound();
            }
            return View(pasiveUser);
        }

        // POST: PasiveUsers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] PasiveUser pasiveUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pasiveUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pasiveUser);
        }

        // GET: PasiveUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PasiveUser pasiveUser = db.PasiveUsers.Find(id);
            if (pasiveUser == null)
            {
                return HttpNotFound();
            }
            return View(pasiveUser);
        }

        // POST: PasiveUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PasiveUser pasiveUser = db.PasiveUsers.Find(id);
            db.PasiveUsers.Remove(pasiveUser);
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
