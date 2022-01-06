using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationrRecolte.Models;

namespace WebApplicationrRecolte.Controllers
{
    public class historique_asscociationController : Controller
    {
        private RecolteEntities db = new RecolteEntities();

        // GET: historique_asscociation
        public ActionResult Index()
        {
            var historique_asscociation = db.historique_asscociation.Include(h => h.association);
            return View(historique_asscociation.ToList());
        }

        // GET: historique_asscociation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historique_asscociation historique_asscociation = db.historique_asscociation.Find(id);
            if (historique_asscociation == null)
            {
                return HttpNotFound();
            }
            return View(historique_asscociation);
        }

        // GET: historique_asscociation/Create
        public ActionResult Create()
        {
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association");
            return View();
        }

        // POST: historique_asscociation/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_histoAssoc,ID_association,DATE_desactive")] historique_asscociation historique_asscociation)
        {
            if (ModelState.IsValid)
            {
                db.historique_asscociation.Add(historique_asscociation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", historique_asscociation.ID_association);
            return View(historique_asscociation);
        }

        // GET: historique_asscociation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historique_asscociation historique_asscociation = db.historique_asscociation.Find(id);
            if (historique_asscociation == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", historique_asscociation.ID_association);
            return View(historique_asscociation);
        }

        // POST: historique_asscociation/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_histoAssoc,ID_association,DATE_desactive")] historique_asscociation historique_asscociation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historique_asscociation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", historique_asscociation.ID_association);
            return View(historique_asscociation);
        }

        // GET: historique_asscociation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            historique_asscociation historique_asscociation = db.historique_asscociation.Find(id);
            if (historique_asscociation == null)
            {
                return HttpNotFound();
            }
            return View(historique_asscociation);
        }

        // POST: historique_asscociation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            historique_asscociation historique_asscociation = db.historique_asscociation.Find(id);
            db.historique_asscociation.Remove(historique_asscociation);
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
