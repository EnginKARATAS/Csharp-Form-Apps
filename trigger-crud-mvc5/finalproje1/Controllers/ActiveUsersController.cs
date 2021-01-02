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
    public class ActiveUsersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ActiveUsers
        public ActionResult Index()
        {
            return View(db.ActiveUsers.ToList());
        }

        // GET: ActiveUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveUser activeUser = db.ActiveUsers.Find(id);
            if (activeUser == null)
            {
                return HttpNotFound();
            }
            return View(activeUser);
        }

        // GET: ActiveUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActiveUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] ActiveUser activeUser)
        {
            if (ModelState.IsValid)
            {
                db.ActiveUsers.Add(activeUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(activeUser);
        }

        // GET: ActiveUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveUser activeUser = db.ActiveUsers.Find(id);
            if (activeUser == null)
            {
                return HttpNotFound();
            }
            return View(activeUser);
        }

        // POST: ActiveUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,KullaniciAdi")] ActiveUser activeUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activeUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(activeUser);
        }

        // GET: ActiveUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActiveUser activeUser = db.ActiveUsers.Find(id);
            if (activeUser == null)
            {
                return HttpNotFound();
            }
            return View(activeUser);
        }

        // POST: ActiveUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActiveUser activeUser = db.ActiveUsers.Find(id);
            db.ActiveUsers.Remove(activeUser);
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
