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
    public class clientsController : Controller
    {
        private RecolteEntities db = new RecolteEntities();

        // GET: clients
        public ActionResult Index()
        {
            var clients = db.clients.Include(c => c.association).Include(c => c.colline);
            return View(clients.ToList());
        }

        // GET: clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: clients/Create
        public ActionResult Create()
        {
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association");
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline");
            return View();
        }

        // POST: clients/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_client,CNI,NOM_client,PRENOM_client,TEL_client,ID_colline,ID_association,DATE_insertion")] client client)
        {
            if (ModelState.IsValid)
            {
                db.clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", client.ID_association);
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", client.ID_colline);
            return View(client);
        }

        // GET: clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", client.ID_association);
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", client.ID_colline);
            return View(client);
        }

        // POST: clients/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_client,CNI,NOM_client,PRENOM_client,TEL_client,ID_colline,ID_association,DATE_insertion")] client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_association = new SelectList(db.associations, "ID_association", "NOM_association", client.ID_association);
            ViewBag.ID_colline = new SelectList(db.collines, "ID_colline", "NOM_colline", client.ID_colline);
            return View(client);
        }

        // GET: clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            client client = db.clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            client client = db.clients.Find(id);
            db.clients.Remove(client);
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
