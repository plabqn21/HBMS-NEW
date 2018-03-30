using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace HRMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var user = User.Identity.GetUserId();
            if (user != null)
            {
               return RedirectToAction("Index","AfterLogIn");
            }
            return View();
        }

     
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      
    }
}