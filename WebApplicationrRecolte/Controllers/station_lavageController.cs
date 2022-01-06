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
    public class station_lavageController : Controller
    {
        private RecolteEntities db = new RecolteEntities();

        // GET: station_lavage
        public ActionResult Index()
        {
            var station_lavage = db.station_lavage.Include(s => s.zone);
            return View(station_lavage.ToList());
        }

        // GET: station_lavage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            station_lavage station_lavage = db.station_lavage.Find(id);
            if (station_lavage == null)
            {
                return HttpNotFound();
            }
            return View(station_lavage);
        }

        // GET: station_lavage/Create
        public ActionResult Create()
        {
            ViewBag.ID_Zone = new SelectList(db.zones, "ID_zone", "NOM_zone");
            return View();
        }

        // POST: station_lavage/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_station,ID_Zone,NOM_station,TEL_station,DATE_insertion")] station_lavage station_lavage)
        {
            if (ModelState.IsValid)
            {
                db.station_lavage.Add(station_lavage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Zone = new SelectList(db.zones, "ID_zone", "NOM_zone", station_lavage.ID_Zone);
            return View(station_lavage);
        }

        // GET: station_lavage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            station_lavage station_lavage = db.station_lavage.Find(id);
            if (station_lavage == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Zone = new SelectList(db.zones, "ID_zone", "NOM_zone", station_lavage.ID_Zone);
            return View(station_lavage);
        }

        // POST: station_lavage/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_station,ID_Zone,NOM_station,TEL_station,DATE_insertion")] station_lavage station_lavage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(station_lavage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Zone = new SelectList(db.zones, "ID_zone", "NOM_zone", station_lavage.ID_Zone);
            return View(station_lavage);
        }

        // GET: station_lavage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            station_lavage station_lavage = db.station_lavage.Find(id);
            if (station_lavage == null)
            {
                return HttpNotFound();
            }
            return View(station_lavage);
        }

        // POST: station_lavage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            station_lavage station_lavage = db.station_lavage.Find(id);
            db.station_lavage.Remove(station_lavage);
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
