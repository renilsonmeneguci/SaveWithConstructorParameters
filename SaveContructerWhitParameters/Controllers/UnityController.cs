using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SaveContructerWhitParameters.Models;

namespace SaveContructerWhitParameters.Controllers
{
    public class UnityController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Unity
        public ActionResult Index()
        {
            return View(db.Unity.ToList());
        }

        // GET: Unity/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unity unity = db.Unity.Find(id);
            if (unity == null)
            {
                return HttpNotFound();
            }
            return View(unity);
        }

        // GET: Unity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Unity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UnityId,Abreviation,Description")] Unity unity)
        {
            if (ModelState.IsValid)
            {
                var unity1 = new Unity("teste", "teste1");

                unity.UnityId = Guid.NewGuid();
                db.Unity.Add(unity);
                db.Unity.Add(unity1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unity);
        }

        // GET: Unity/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unity unity = db.Unity.Find(id);
            if (unity == null)
            {
                return HttpNotFound();
            }
            return View(unity);
        }

        // POST: Unity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UnityId,Abreviation,Description")] Unity unity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unity);
        }

        // GET: Unity/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unity unity = db.Unity.Find(id);
            if (unity == null)
            {
                return HttpNotFound();
            }
            return View(unity);
        }

        // POST: Unity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Unity unity = db.Unity.Find(id);
            db.Unity.Remove(unity);
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
