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
    public class NGUYENLIEUxController : Controller
    {
        private Model1 db = new Model1();

        // GET: NGUYENLIEUx
        public ActionResult Index()
        {
            var nGUYENLIEU = db.NGUYENLIEU.Include(n => n.NHACUNGCAP);
            return View(nGUYENLIEU.ToList());
        }

        // GET: NGUYENLIEUx/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUYENLIEU nGUYENLIEU = db.NGUYENLIEU.Find(id);
            if (nGUYENLIEU == null)
            {
                return HttpNotFound();
            }
            return View(nGUYENLIEU);
        }

        // GET: NGUYENLIEUx/Create
        public ActionResult Create()
        {
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAP, "MaNCC", "TenNCC");
            return View();
        }

        // POST: NGUYENLIEUx/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNL,TenNL,MaNCC")] NGUYENLIEU nGUYENLIEU)
        {
            if (ModelState.IsValid)
            {
                db.NGUYENLIEU.Add(nGUYENLIEU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNCC = new SelectList(db.NHACUNGCAP, "MaNCC", "TenNCC", nGUYENLIEU.MaNCC);
            return View(nGUYENLIEU);
        }

        // GET: NGUYENLIEUx/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUYENLIEU nGUYENLIEU = db.NGUYENLIEU.Find(id);
            if (nGUYENLIEU == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAP, "MaNCC", "TenNCC", nGUYENLIEU.MaNCC);
            return View(nGUYENLIEU);
        }

        // POST: NGUYENLIEUx/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNL,TenNL,MaNCC")] NGUYENLIEU nGUYENLIEU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nGUYENLIEU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.NHACUNGCAP, "MaNCC", "TenNCC", nGUYENLIEU.MaNCC);
            return View(nGUYENLIEU);
        }

        // GET: NGUYENLIEUx/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NGUYENLIEU nGUYENLIEU = db.NGUYENLIEU.Find(id);
            if (nGUYENLIEU == null)
            {
                return HttpNotFound();
            }
            return View(nGUYENLIEU);
        }

        // POST: NGUYENLIEUx/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NGUYENLIEU nGUYENLIEU = db.NGUYENLIEU.Find(id);
            db.NGUYENLIEU.Remove(nGUYENLIEU);
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
