using System;
using System.Web.Mvc;
using CanAmLegacy.Helpers;
using CanAmLegacy.Models;

namespace CanAmLegacy.Controllers
{   
    public class TerraceView18Controller : Controller
    {
		private readonly IHoleStatusRepository holestatusRepository;
		private readonly ITerraceView18Repository terraceview18Repository;
    private readonly GameTotal gameTotals = new GameTotal();

		// If you are using Dependency Injection, you can delete the following constructor
        public TerraceView18Controller() : this(new HoleStatusRepository(), new TerraceView18Repository())
        {
        }

        public TerraceView18Controller(IHoleStatusRepository holestatusRepository, ITerraceView18Repository terraceview18Repository)
        {
			    this.holestatusRepository = holestatusRepository;
			    this.terraceview18Repository = terraceview18Repository;
        }

        //
        // GET: /TerraceView18/

        public ViewResult Index()
        {
            ViewBag.GameTotals = gameTotals;
            return View(terraceview18Repository.AllIncluding(terraceview18 => terraceview18.Hole1, terraceview18 => terraceview18.Hole2, terraceview18 => terraceview18.Hole3, terraceview18 => terraceview18.Hole4, terraceview18 => terraceview18.Hole5, terraceview18 => terraceview18.Hole6, terraceview18 => terraceview18.Hole7, terraceview18 => terraceview18.Hole8, terraceview18 => terraceview18.Hole9, terraceview18 => terraceview18.Hole10, terraceview18 => terraceview18.Hole11, terraceview18 => terraceview18.Hole12, terraceview18 => terraceview18.Hole13, terraceview18 => terraceview18.Hole14, terraceview18 => terraceview18.Hole15, terraceview18 => terraceview18.Hole16, terraceview18 => terraceview18.Hole17, terraceview18 => terraceview18.Hole18));
        }

        //
        // GET: /TerraceView18/Details/5

        public ViewResult Details(int id)
        {
            ViewBag.GameTotals = gameTotals;
            return View(terraceview18Repository.Find(id));
        }

        //
        // GET: /TerraceView18/Create
        //[Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.GameTotals = gameTotals;
            ViewBag.PossibleHole1 = holestatusRepository.All;
            ViewBag.PossibleHole2 = holestatusRepository.All;
            ViewBag.PossibleHole3 = holestatusRepository.All;
            ViewBag.PossibleHole4 = holestatusRepository.All;
            ViewBag.PossibleHole5 = holestatusRepository.All;
            ViewBag.PossibleHole6 = holestatusRepository.All;
            ViewBag.PossibleHole7 = holestatusRepository.All;
            ViewBag.PossibleHole8 = holestatusRepository.All;
            ViewBag.PossibleHole9 = holestatusRepository.All;
            ViewBag.PossibleHole10 = holestatusRepository.All;
            ViewBag.PossibleHole11 = holestatusRepository.All;
            ViewBag.PossibleHole12 = holestatusRepository.All;
            ViewBag.PossibleHole13 = holestatusRepository.All;
            ViewBag.PossibleHole14 = holestatusRepository.All;
            ViewBag.PossibleHole15 = holestatusRepository.All;
            ViewBag.PossibleHole16 = holestatusRepository.All;
            ViewBag.PossibleHole17 = holestatusRepository.All;
            ViewBag.PossibleHole18 = holestatusRepository.All;
            return View();
        } 

        //
        // POST: /TerraceView18/Create
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(TerraceView18 terraceview18)
        {
            if (ModelState.IsValid) {
                terraceview18Repository.InsertOrUpdate(terraceview18);
                terraceview18Repository.Save();
                return RedirectToAction("Index");
            } else {
                ViewBag.GameTotals = gameTotals;
                ViewBag.PossibleHole1 = holestatusRepository.All;
				        ViewBag.PossibleHole2 = holestatusRepository.All;
				        ViewBag.PossibleHole3 = holestatusRepository.All;
				        ViewBag.PossibleHole4 = holestatusRepository.All;
				        ViewBag.PossibleHole5 = holestatusRepository.All;
				        ViewBag.PossibleHole6 = holestatusRepository.All;
				        ViewBag.PossibleHole7 = holestatusRepository.All;
				        ViewBag.PossibleHole8 = holestatusRepository.All;
				        ViewBag.PossibleHole9 = holestatusRepository.All;
				        ViewBag.PossibleHole10 = holestatusRepository.All;
				        ViewBag.PossibleHole11 = holestatusRepository.All;
				        ViewBag.PossibleHole12 = holestatusRepository.All;
				        ViewBag.PossibleHole13 = holestatusRepository.All;
				        ViewBag.PossibleHole14 = holestatusRepository.All;
				        ViewBag.PossibleHole15 = holestatusRepository.All;
				        ViewBag.PossibleHole16 = holestatusRepository.All;
				        ViewBag.PossibleHole17 = holestatusRepository.All;
				        ViewBag.PossibleHole18 = holestatusRepository.All;
				        return View();
			        }
        }
        
        //
        // GET: /TerraceView18/Edit/5
        //[Authorize(Roles = "Admin,User")]
        public ActionResult Edit(int id)
        {
            ViewBag.GameTotals = gameTotals;
            ViewBag.PossibleHole1 = holestatusRepository.All;
			      ViewBag.PossibleHole2 = holestatusRepository.All;
			      ViewBag.PossibleHole3 = holestatusRepository.All;
			      ViewBag.PossibleHole4 = holestatusRepository.All;
			      ViewBag.PossibleHole5 = holestatusRepository.All;
			      ViewBag.PossibleHole6 = holestatusRepository.All;
			      ViewBag.PossibleHole7 = holestatusRepository.All;
			      ViewBag.PossibleHole8 = holestatusRepository.All;
			      ViewBag.PossibleHole9 = holestatusRepository.All;
			      ViewBag.PossibleHole10 = holestatusRepository.All;
			      ViewBag.PossibleHole11 = holestatusRepository.All;
			      ViewBag.PossibleHole12 = holestatusRepository.All;
			      ViewBag.PossibleHole13 = holestatusRepository.All;
			      ViewBag.PossibleHole14 = holestatusRepository.All;
			      ViewBag.PossibleHole15 = holestatusRepository.All;
			      ViewBag.PossibleHole16 = holestatusRepository.All;
			      ViewBag.PossibleHole17 = holestatusRepository.All;
			      ViewBag.PossibleHole18 = holestatusRepository.All;
            return View(terraceview18Repository.Find(id));
        }

        //
        // POST: /TerraceView18/Edit/5
        //[Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult Edit(TerraceView18 terraceview18)
        {
            if (ModelState.IsValid)
            {
                var notPlayed = 0;
                var canWins = 0;
                var usaWins = 0;
                var ties = 0;

                switch (terraceview18.Hole1Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole2Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole3Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole4Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole5Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole6Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole7Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole8Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole9Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole10Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole11Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole12Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole13Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole14Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole15Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole16Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole17Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }
                switch (terraceview18.Hole18Id)
                {
                    case 1:
                        notPlayed++;
                        break;
                    case 3:
                        canWins++;
                        break;
                    case 4:
                        usaWins++;
                        break;
                    default:
                        ties++;
                        break;
                }


                // determine who is winning?

                var leadingBy = 0;
                if (canWins > usaWins)
                {
                    leadingBy = canWins - usaWins;
                    terraceview18.MatchStatus = String.Format("CAN +{0} (on {1})", leadingBy, 19 - notPlayed);
                }
                else if (usaWins > canWins)
                {
                    leadingBy = usaWins - canWins;
                    terraceview18.MatchStatus = String.Format("USA +{0} (on {1})", leadingBy, 19 - notPlayed);
                }
                else
                {
                    terraceview18.MatchStatus = String.Format("EVEN (on {0})", 19 - notPlayed);
                }

                terraceview18.UsaPoints = 0;
                terraceview18.CanPoints = 0;
                terraceview18.InProgress = true;

                if (notPlayed < leadingBy || notPlayed == 0) //the match is over
                {
                    terraceview18.InProgress = false;
                    if (canWins > usaWins)
                    {
                        terraceview18.CanPoints = 2m;
                        terraceview18.UsaPoints = 0;
                        terraceview18.MatchStatus = String.Format("CAN WINS {0}-{1}", canWins, usaWins);
                    }
                    else if (usaWins > canWins)
                    {
                        terraceview18.UsaPoints = 2m;
                        terraceview18.CanPoints = 0;
                        terraceview18.MatchStatus = String.Format("USA WINS {0}-{1}", usaWins, canWins);
                    }
                    else
                    {
                        terraceview18.UsaPoints = 1m;
                        terraceview18.CanPoints = 1m;
                        terraceview18.MatchStatus = String.Format("Final TIED {0}-{1}", usaWins, canWins);
                    }
                }
                terraceview18Repository.InsertOrUpdate(terraceview18);
                terraceview18Repository.Save();
                return RedirectToAction("Index");
            } 
            else {
                ViewBag.GameTotals = gameTotals;
                ViewBag.PossibleHole1 = holestatusRepository.All;
				        ViewBag.PossibleHole2 = holestatusRepository.All;
				        ViewBag.PossibleHole3 = holestatusRepository.All;
				        ViewBag.PossibleHole4 = holestatusRepository.All;
				        ViewBag.PossibleHole5 = holestatusRepository.All;
				        ViewBag.PossibleHole6 = holestatusRepository.All;
				        ViewBag.PossibleHole7 = holestatusRepository.All;
				        ViewBag.PossibleHole8 = holestatusRepository.All;
				        ViewBag.PossibleHole9 = holestatusRepository.All;
				        ViewBag.PossibleHole10 = holestatusRepository.All;
				        ViewBag.PossibleHole11 = holestatusRepository.All;
				        ViewBag.PossibleHole12 = holestatusRepository.All;
				        ViewBag.PossibleHole13 = holestatusRepository.All;
				        ViewBag.PossibleHole14 = holestatusRepository.All;
				        ViewBag.PossibleHole15 = holestatusRepository.All;
				        ViewBag.PossibleHole16 = holestatusRepository.All;
				        ViewBag.PossibleHole17 = holestatusRepository.All;
				        ViewBag.PossibleHole18 = holestatusRepository.All;
				        return View();
			        }
        }

        //
        // GET: /TerraceView18/Delete/5
        //[Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            ViewBag.GameTotals = gameTotals;
            return View(terraceview18Repository.Find(id));
        }

        //
        // POST: /TerraceView18/Delete/5
        //[Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ViewBag.GameTotals = gameTotals;
            terraceview18Repository.Delete(id);
            terraceview18Repository.Save();

            return RedirectToAction("Index");
        }
    }
}

