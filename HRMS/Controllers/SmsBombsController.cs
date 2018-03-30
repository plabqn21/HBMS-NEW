using HRMS.Models;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web.Mvc;

namespace HRMS.Controllers
{
    public class SmsBombsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SmsBombs


        // GET: SmsBombs/Details/5


        // GET: SmsBombs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SmsBombs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Number,Message,Size")] SmsBomb smsBomb)
        {

            string baseURI = "http://console.hishab.co/api/send_sms/?token=6366a35c-29a7-4e25-981f-e961b41ffe32&content=" + smsBomb.Message + "&number=" + smsBomb.Number + "";


            int a = Convert.ToInt32(smsBomb.Size);
            for (int i = 1; i <= a; i++)
            {
                Thread.Sleep(30000);
                WebRequest request = WebRequest.Create(baseURI);
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(responseStream, encode);
                string html = reader.ReadToEnd();
                reader.Close();
                responseStream.Close();
                response.Close();


            }

            return View(smsBomb);
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
