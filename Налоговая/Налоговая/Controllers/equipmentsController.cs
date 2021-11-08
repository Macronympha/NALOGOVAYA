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
    public class equipmentsController : Controller
    {
        private НалоговаяEntities db = new НалоговаяEntities();

        // GET: equipments
        [Authorize]
        public ActionResult Index()
        {
            return View(db.equipments.ToList());
        }

        // GET: equipments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipments equipments = db.equipments.Find(id);
            if (equipments == null)
            {
                return HttpNotFound();
            }
            return View(equipments);
        }

        // GET: equipments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: equipments/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_equipments,title")] equipments equipments)
        {
            if (ModelState.IsValid)
            {
                db.equipments.Add(equipments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(equipments);
        }

        // GET: equipments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipments equipments = db.equipments.Find(id);
            if (equipments == null)
            {
                return HttpNotFound();
            }
            return View(equipments);
        }

        // POST: equipments/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_equipments,title")] equipments equipments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(equipments);
        }

        // GET: equipments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            equipments equipments = db.equipments.Find(id);
            if (equipments == null)
            {
                return HttpNotFound();
            }
            return View(equipments);
        }

        // POST: equipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            equipments equipments = db.equipments.Find(id);
            db.equipments.Remove(equipments);
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
