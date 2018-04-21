using System.IO;
using System.Web;
using HRMS.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace HRMS.Controllers
{
    public class RentersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Renters
        public ActionResult Index()
        {
            var renters = db.Renters.Include(r => r.House);
            return View(renters.ToList());
        }

        // GET: Renters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renter renter = db.Renters.Find(id);
            if (renter == null)
            {
                return HttpNotFound();
            }
            return View(renter);
        }

        // GET: Renters/Create
        public ActionResult Create()
        {

            string ownerId = User.Identity.GetUserId().ToString();
            ViewBag.HouseId = new SelectList(db.Houses.Where(x => x.OwnerId == ownerId), "Id", "HouseNo");
            return View();
        }

        // POST: Renters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Renter renter, IEnumerable<HttpPostedFileBase> Files)
        {

            




            if (ModelState.IsValid)
            {






                //if (Picture.ContentLength > 0)
                //{

                //    // code for saving the image file to a physical location.
                //    var fileName = Path.GetFileName(Picture.FileName);
                //    var path = Path.Combine(Server.MapPath("~/Images/RenterImage"), fileName);
                //    Picture.SaveAs(path);
                //    // prepare a relative path to be stored in the database and used to display later on.
                //    var dbpath = Url.Content(Path.Combine("~/Images/RenterImage", fileName));
                //    renter.Picture = dbpath;
                //}

                //if (IdFront.ContentLength > 0)
                //{

                //    // code for saving the image file to a physical location.
                //    var fileName = Path.GetFileName(IdFront.FileName);
                //    var path = Path.Combine(Server.MapPath("~/Images/ID"), fileName);
                //    IdFront.SaveAs(path);
                //    // prepare a relative path to be stored in the database and used to display later on.
                //    var dbpath = Url.Content(Path.Combine("~/Images/ID", fileName));
                //    renter.IdFront = dbpath;
                //}




                //if (IdBack.ContentLength > 0)
                //{

                //    // code for saving the image file to a physical location.
                //    var fileName = Path.GetFileName(IdBack.FileName);
                //    var path = Path.Combine(Server.MapPath("~/Images/ID"), fileName);
                //    IdBack.SaveAs(path);
                //    // prepare a relative path to be stored in the database and used to display later on.
                //    var dbpath = Url.Content(Path.Combine("~/Images/ID", fileName));
                //    renter.IdBack = dbpath;
                //}




                db.Renters.Add(renter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HouseId = new SelectList(db.Houses, "Id", "HouseNo", renter.HouseId);
            return View(renter);
        }

        // GET: Renters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renter renter = db.Renters.Find(id);
            if (renter == null)
            {
                return HttpNotFound();
            }
            ViewBag.HouseId = new SelectList(db.Houses, "Id", "HouseNo", renter.HouseId);
            return View(renter);
        }

        // POST: Renters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Picture,IdFront,IdBack,NumberOfMember,MobileNo,RentDate,LeaveDate,Status,MonthlyRentBill,Advance,ElectricBill,GassBill,WaterBill,CareTakerBill,SecurityManBill,ServiceCharge,HouseId,Owner_Id,FlatNo")] Renter renter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(renter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HouseId = new SelectList(db.Houses, "Id", "HouseNo", renter.HouseId);
            return View(renter);
        }

        // GET: Renters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renter renter = db.Renters.Find(id);
            if (renter == null)
            {
                return HttpNotFound();
            }
            return View(renter);
        }

        // POST: Renters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Renter renter = db.Renters.Find(id);
            db.Renters.Remove(renter);
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
