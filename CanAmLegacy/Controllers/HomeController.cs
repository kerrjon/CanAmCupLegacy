using System.Web.Mvc;
using CanAmLegacy.Helpers;

namespace CanAmLegacy.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameTotal gameTotals = new GameTotal();

        public ActionResult Index()
        {           
            ViewBag.GameTotals = gameTotals;
            return View();
        }


        public ActionResult CreateCookie()
        {
            ViewBag.GameTotals = gameTotals;
            return View();
        }

    }
}
