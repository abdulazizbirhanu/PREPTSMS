using System.Web.Mvc;

namespace AdminLTE2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View("Index");
        }

        public ActionResult AnotherLink()
        {
            return View("Index");
        }
    }
}
