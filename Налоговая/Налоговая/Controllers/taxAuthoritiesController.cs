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
    public class taxAuthoritiesController : Controller
    {
        private НалоговаяEntities db = new НалоговаяEntities();

        // GET: taxAuthorities
        [Authorize]
        public ActionResult Index()
        {
            return View(db.taxAuthority.ToList());
        }

        // GET: taxAuthorities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taxAuthority taxAuthority = db.taxAuthority.Find(id);
            if (taxAuthority == null)
            {
                return HttpNotFound();
            }
            return View(taxAuthority);
        }

        // GET: taxAuthorities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: taxAuthorities/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_taxAuthority,addres")] taxAuthority taxAuthority)
        {
            if (ModelState.IsValid)
            {
                db.taxAuthority.Add(taxAuthority);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taxAuthority);
        }

        // GET: taxAuthorities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taxAuthority taxAuthority = db.taxAuthority.Find(id);
            if (taxAuthority == null)
            {
                return HttpNotFound();
            }
            return View(taxAuthority);
        }

        // POST: taxAuthorities/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_taxAuthority,addres")] taxAuthority taxAuthority)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taxAuthority).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taxAuthority);
        }

        // GET: taxAuthorities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            taxAuthority taxAuthority = db.taxAuthority.Find(id);
            if (taxAuthority == null)
            {
                return HttpNotFound();
            }
            return View(taxAuthority);
        }

        // POST: taxAuthorities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            taxAuthority taxAuthority = db.taxAuthority.Find(id);
            db.taxAuthority.Remove(taxAuthority);
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
