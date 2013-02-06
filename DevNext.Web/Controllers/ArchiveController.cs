using System.Linq;
using System.Web.Mvc;
using DevNext.Web.Models;

namespace DevNext.Web.Controllers
{
    public class ArchiveController : Controller
    {
        private readonly DevNextDbContext _context = new DevNextDbContext();

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(_context.TechnicalContents.AsEnumerable());
        }
    }
}