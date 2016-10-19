
using System.Linq;
using System.Web.Mvc;

namespace DevProApp.Controllers
{
    [RouteArea("Home", AreaPrefix = "Home")]
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route]
        [Route("Index")]
        public ActionResult Index()
        {

            return View();
        }

        [Route("~/Home/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [Route("~/Home/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("~/Home/Error")]
        public ActionResult Error()
        {
            return View();
        }

        [Route("~/Home/UnderConstruction")]
        public ActionResult UnderConstruction()
        {
            return View();
        }
    }
}
