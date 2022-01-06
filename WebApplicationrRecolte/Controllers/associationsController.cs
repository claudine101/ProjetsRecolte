using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationrRecolte.Models;
using Highsoft.Web.Mvc.Charts;


namespace WebApplicationrRecolte.Controllers
{
    public class associationsController : Controller
    {
        private RecolteEntities db = new RecolteEntities();

       
        // GET: associations

        public ActionResult Indexe()
        {
            var association = db.associations.Include(a => a.colline);
            var historique = db.historique_asscociation;
            ViewData["association"] = association.ToList();
            ViewData["historique"] = historique.ToList();
            return View();
        }
        public ActionResult Index()
        {
            //var associations = db.associations.Include(a => a.colline);
            //return View(associations.ToList());
            var association = db.associations.Include(a => a.colline);
            var historique = db.historique_asscociation;
            ViewData["association"] = association.ToList();
            ViewData["historique"] = historique.ToList();
            return View();
        }
        // GET: associations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            association association = db.associations.Find(id);
            if (association == null)
            {
                return HttpNotFound();
            }
            return View(association);
        }

        // GET: associations/Create
        public ActionResult Create()
        {
            ViewBag.ID_province = new SelectList(db.provinces, "ID_province", "NOM_province");
            ViewBag.ID_commune = new SelectList(db.communes, "ID_commune", "NOM_commune");
            ViewBag.ID_zone = new SelectList(db.zones, "ID_zone", "NOM_zone");
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline");
            return View();
        }

        // POST: associations/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_association,ID_colline,NOM_association,TEL_association,DATE_association")] association association)
        {
            if (ModelState.IsValid)
            {
                db.associations.Add(association);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", association.ID_colline);
            return View(association);
        }

        // GET: associations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            association association = db.associations.Find(id);
            if (association == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", association.ID_colline);
            return View(association);
        }

        // POST: associations/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_association,ID_colline,NOM_association,TEL_association,DATE_association")] association association)
        {
            if (ModelState.IsValid)
            {
                db.Entry(association).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", association.ID_colline);
            return View(association);
        }

        // GET: associations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            association association = db.associations.Find(id);
            if (association == null)
            {
                return HttpNotFound();
            }
            return View(association);
        }

        // POST: associations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            association association = db.associations.Find(id);
            db.associations.Remove(association);
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
        //POUR RAPPORT
        ////public ActionResult GetData()
        ////{

        ////    var result = (from A in db.associations
        ////                  join C in db.clients on A.ID_association equals C.ID_association
        ////                  join R in db.recoltes on C.ID_client equals R.ID_client
        ////                  group R by new { A.ID_association, A.NOM_association } into g
        ////                  select new
        ////                  {
        ////                      ID = g.Key.ID_association,
        ////                      name = g.Key.NOM_association,
        ////                      quantite = g.Sum(R => R.quantite)
        ////                  }).ToList();
        ////    return Json(result, JsonRequestBehavior.AllowGet);
        ////}
        public ActionResult GetData()
        {

            RecolteEntities context = new RecolteEntities();
            var list = context.recoltes.GroupBy(t => new { t.qualite, t.quantite,t.ID_recolte })
              .Select(i => new {
                  name = i.Key.qualite,
                  key = i.Key.ID_recolte,
                  count = i.Sum(w => w.quantite)
              }).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
