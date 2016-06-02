using System.Web.Mvc;
using CanAmLegacy.Helpers;
using CanAmLegacy.Models;

namespace CanAmLegacy.Controllers
{   
    public class HoleStatusController : Controller
    {
		private readonly IHoleStatusRepository holestatusRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        private readonly GameTotal gameTotals = new GameTotal();
        
        public HoleStatusController() : this(new HoleStatusRepository())
        {
        }

        public HoleStatusController(IHoleStatusRepository holestatusRepository)
        {
			      this.holestatusRepository = holestatusRepository;
        }

        //
        // GET: /HoleStatus/

        public ViewResult Index()
        {
            ViewBag.GameTotals = gameTotals;
            return View();
        }

        //
        // GET: /HoleStatus/Details/5

        public ViewResult Details(int id)
        {
            ViewBag.GameTotals = gameTotals;
            return View(holestatusRepository.Find(id));
        }

        //
        // GET: /HoleStatus/Create

        public ActionResult Create()
        {
            ViewBag.GameTotals = gameTotals;
            return View();
        } 

        //
        // POST: /HoleStatus/Create

        [HttpPost]
        public ActionResult Create(HoleStatus holestatus)
        {
            if (ModelState.IsValid) {
                holestatusRepository.InsertOrUpdate(holestatus);
                holestatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /HoleStatus/Edit/5
 
        public ActionResult Edit(int id)
        {
            ViewBag.GameTotals = gameTotals; 
            return View(holestatusRepository.Find(id));
        }

        //
        // POST: /HoleStatus/Edit/5

        [HttpPost]
        public ActionResult Edit(HoleStatus holestatus)
        {
            if (ModelState.IsValid) {
                holestatusRepository.InsertOrUpdate(holestatus);
                holestatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /HoleStatus/Delete/5
 
        public ActionResult Delete(int id)
        {
            ViewBag.GameTotals = gameTotals;
            return View(holestatusRepository.Find(id));
        }

        //
        // POST: /HoleStatus/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            holestatusRepository.Delete(id);
            holestatusRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

