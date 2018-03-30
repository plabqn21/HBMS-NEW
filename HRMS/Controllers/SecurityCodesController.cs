using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class SecurityCodesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SecurityCodes
        public ActionResult Index()
        {
            return View(db.SecurityCodes.ToList());
        }

        // GET: SecurityCodes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityCode securityCode = db.SecurityCodes.Find(id);
            if (securityCode == null)
            {
                return HttpNotFound();
            }
            return View(securityCode);
        }

        // GET: SecurityCodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecurityCodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Flag")] SecurityCode securityCode)
        {
            securityCode.Flag = "Not Used";


            if (ModelState.IsValid)
            {
                db.SecurityCodes.Add(securityCode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(securityCode);
        }

        // GET: SecurityCodes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityCode securityCode = db.SecurityCodes.Find(id);
            if (securityCode == null)
            {
                return HttpNotFound();
            }
            return View(securityCode);
        }

        // POST: SecurityCodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Flag")] SecurityCode securityCode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(securityCode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(securityCode);
        }

        // GET: SecurityCodes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityCode securityCode = db.SecurityCodes.Find(id);
            if (securityCode == null)
            {
                return HttpNotFound();
            }
            return View(securityCode);
        }

        // POST: SecurityCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecurityCode securityCode = db.SecurityCodes.Find(id);
            db.SecurityCodes.Remove(securityCode);
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
