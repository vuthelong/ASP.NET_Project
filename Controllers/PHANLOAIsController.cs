using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Project.Models;

namespace ASP.NET_Project.Controllers
{
    public class PHANLOAIsController : Controller
    {
        private Model1 db = new Model1();

        // GET: PHANLOAIs
        public ActionResult Index()
        {
            return View(db.PHANLOAI.ToList());
        }

        // GET: PHANLOAIs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHANLOAI pHANLOAI = db.PHANLOAI.Find(id);
            if (pHANLOAI == null)
            {
                return HttpNotFound();
            }
            return View(pHANLOAI);
        }

        // GET: PHANLOAIs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHANLOAIs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoai,TenLoai")] PHANLOAI pHANLOAI)
        {
            if (ModelState.IsValid)
            {
                db.PHANLOAI.Add(pHANLOAI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHANLOAI);
        }

        // GET: PHANLOAIs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHANLOAI pHANLOAI = db.PHANLOAI.Find(id);
            if (pHANLOAI == null)
            {
                return HttpNotFound();
            }
            return View(pHANLOAI);
        }

        // POST: PHANLOAIs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoai,TenLoai")] PHANLOAI pHANLOAI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHANLOAI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHANLOAI);
        }

        // GET: PHANLOAIs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHANLOAI pHANLOAI = db.PHANLOAI.Find(id);
            if (pHANLOAI == null)
            {
                return HttpNotFound();
            }
            return View(pHANLOAI);
        }

        // POST: PHANLOAIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PHANLOAI pHANLOAI = db.PHANLOAI.Find(id);
            db.PHANLOAI.Remove(pHANLOAI);
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
