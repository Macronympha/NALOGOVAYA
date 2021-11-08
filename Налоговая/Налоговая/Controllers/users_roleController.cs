using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Налоговая.Models;

namespace Налоговая.Controllers
{
    public class users_roleController : Controller
    {
        private НалоговаяEntities db = new НалоговаяEntities();

        // GET: users_role
        public ActionResult Index()
        {
            var users_role = db.users_role.Include(u => u.role).Include(u => u.users);
            return View(users_role.ToList());
        }

        // GET: users_role/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users_role users_role = db.users_role.Find(id);
            if (users_role == null)
            {
                return HttpNotFound();
            }
            return View(users_role);
        }

        // GET: users_role/Create
        public ActionResult Create()
        {
            ViewBag.id_role = new SelectList(db.role, "id_role", "title");
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname");
            return View();
        }

        // POST: users_role/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_users_role,id_role,id_users")] users_role users_role)
        {
            if (ModelState.IsValid)
            {
                db.users_role.Add(users_role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_role = new SelectList(db.role, "id_role", "title", users_role.id_role);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", users_role.id_users);
            return View(users_role);
        }

        // GET: users_role/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users_role users_role = db.users_role.Find(id);
            if (users_role == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_role = new SelectList(db.role, "id_role", "title", users_role.id_role);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", users_role.id_users);
            return View(users_role);
        }

        // POST: users_role/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_users_role,id_role,id_users")] users_role users_role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users_role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_role = new SelectList(db.role, "id_role", "title", users_role.id_role);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", users_role.id_users);
            return View(users_role);
        }

        // GET: users_role/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            users_role users_role = db.users_role.Find(id);
            if (users_role == null)
            {
                return HttpNotFound();
            }
            return View(users_role);
        }

        // POST: users_role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            users_role users_role = db.users_role.Find(id);
            db.users_role.Remove(users_role);
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
