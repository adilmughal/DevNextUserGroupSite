using System.Web.Mvc;

namespace DevNext.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}