using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vreme.Models;
using Highsoft.Web.Mvc;

namespace Vreme.Controllers
{
    public class PodatkiController : Controller
    {
        private VremeContext db = new VremeContext();
        // GET: Podatki
        public ActionResult Index(string id)
        {
           
            var data = from x in db.Podatkis
                       select x;

            if (!String.IsNullOrEmpty(id))
            {
                int newid = int.Parse(id);
                data = data.Where( s => s.IdPostaje==newid);
            }

            data = from y in data
                   orderby y.Id descending
                   select y;

            return View(data);
        }

        // GET: Podatki/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podatki podatki = db.Podatkis.Find(id);
            if (podatki == null)
            {
                return HttpNotFound();
            }
            return View(podatki);
        }

        // GET: Podatki/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Podatki/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdPostaje,Cas,Temp,Vlaga,Nekaj,Nevem")] Podatki podatki)
        {
            if (ModelState.IsValid)
            {
                db.Podatkis.Add(podatki);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(podatki);
        }

        // GET: Podatki/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podatki podatki = db.Podatkis.Find(id);
            if (podatki == null)
            {
                return HttpNotFound();
            }
            return View(podatki);
        }

        // POST: Podatki/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdPostaje,Cas,Temp,Vlaga,Nekaj,Nevem")] Podatki podatki)
        {
            if (ModelState.IsValid)
            {
                db.Entry(podatki).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(podatki);
        }

        // GET: Podatki/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Podatki podatki = db.Podatkis.Find(id);
            if (podatki == null)
            {
                return HttpNotFound();
            }
            return View(podatki);
        }

        // POST: Podatki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Podatki podatki = db.Podatkis.Find(id);
            db.Podatkis.Remove(podatki);
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
