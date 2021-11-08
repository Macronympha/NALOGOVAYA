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
    public class ACTs1Controller : Controller
    {
        private НалоговаяEntities db = new НалоговаяEntities();

        // GET: ACTs1
        [Authorize]
        public ActionResult Index()
        {
            var aCT = db.ACT.Include(a => a.conclusion).Include(a => a.equipments).Include(a => a.taxAuthority).Include(a => a.termsOfUse).Include(a => a.type).Include(a => a.users);
            return View(aCT.ToList());
        }

        // GET: ACTs1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACT aCT = db.ACT.Find(id);
            if (aCT == null)
            {
                return HttpNotFound();
            }
            return View(aCT);
        }

        // GET: ACTs1/Create
        public ActionResult Create()
        {
            ViewBag.id_conclusion = new SelectList(db.conclusion, "id_conclusion", "content");
            ViewBag.id_equipments = new SelectList(db.equipments, "id_equipments", "title");
            ViewBag.id_taxAuthority = new SelectList(db.taxAuthority, "id_taxAuthority", "addres");
            ViewBag.id_termsOfUse = new SelectList(db.termsOfUse, "id_termsOfUse", "title");
            ViewBag.id_type = new SelectList(db.type, "id_type", "title");
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname");
            return View();
        }

        // POST: ACTs1/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_act,id_type,id_termsOfUse,id_taxAuthority,id_conclusion,id_equipments,id_users,name,manufacturer,condition,year_of_issue,commissioning,equipment_number,assessment,date,application")] ACT aCT)
        {
            if (ModelState.IsValid)
            {
                db.ACT.Add(aCT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_conclusion = new SelectList(db.conclusion, "id_conclusion", "content", aCT.id_conclusion);
            ViewBag.id_equipments = new SelectList(db.equipments, "id_equipments", "title", aCT.id_equipments);
            ViewBag.id_taxAuthority = new SelectList(db.taxAuthority, "id_taxAuthority", "addres", aCT.id_taxAuthority);
            ViewBag.id_termsOfUse = new SelectList(db.termsOfUse, "id_termsOfUse", "title", aCT.id_termsOfUse);
            ViewBag.id_type = new SelectList(db.type, "id_type", "title", aCT.id_type);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", aCT.id_users);
            return View(aCT);
        }

        // GET: ACTs1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACT aCT = db.ACT.Find(id);
            if (aCT == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_conclusion = new SelectList(db.conclusion, "id_conclusion", "content", aCT.id_conclusion);
            ViewBag.id_equipments = new SelectList(db.equipments, "id_equipments", "title", aCT.id_equipments);
            ViewBag.id_taxAuthority = new SelectList(db.taxAuthority, "id_taxAuthority", "addres", aCT.id_taxAuthority);
            ViewBag.id_termsOfUse = new SelectList(db.termsOfUse, "id_termsOfUse", "title", aCT.id_termsOfUse);
            ViewBag.id_type = new SelectList(db.type, "id_type", "title", aCT.id_type);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", aCT.id_users);
            return View(aCT);
        }

        // POST: ACTs1/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_act,id_type,id_termsOfUse,id_taxAuthority,id_conclusion,id_equipments,id_users,name,manufacturer,condition,year_of_issue,commissioning,equipment_number,assessment,date,application")] ACT aCT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_conclusion = new SelectList(db.conclusion, "id_conclusion", "content", aCT.id_conclusion);
            ViewBag.id_equipments = new SelectList(db.equipments, "id_equipments", "title", aCT.id_equipments);
            ViewBag.id_taxAuthority = new SelectList(db.taxAuthority, "id_taxAuthority", "addres", aCT.id_taxAuthority);
            ViewBag.id_termsOfUse = new SelectList(db.termsOfUse, "id_termsOfUse", "title", aCT.id_termsOfUse);
            ViewBag.id_type = new SelectList(db.type, "id_type", "title", aCT.id_type);
            ViewBag.id_users = new SelectList(db.users, "id_users", "surname", aCT.id_users);
            return View(aCT);
        }

        // GET: ACTs1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACT aCT = db.ACT.Find(id);
            if (aCT == null)
            {
                return HttpNotFound();
            }
            return View(aCT);
        }

        // POST: ACTs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACT aCT = db.ACT.Find(id);
            db.ACT.Remove(aCT);
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
