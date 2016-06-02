using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CanAmLegacy.Helpers;
using CanAmLegacy.Models;

namespace CanAmLegacy.Controllers
{
    public class NorthLinksBack9Controller : Controller
    {
        private CanAmCupContext context = new CanAmCupContext();
        private readonly GameTotal gameTotals = new GameTotal();
        //
        // GET: /NorthLinksBack9/

        public ViewResult Index()
        {
            ViewBag.GameTotals = gameTotals;
            return View(context.NorthLinksBack9.Include(northlinksback9 => northlinksback9.Hole1).Include(northlinksback9 => northlinksback9.Hole2).Include(northlinksback9 => northlinksback9.Hole3).Include(northlinksback9 => northlinksback9.Hole4).Include(northlinksback9 => northlinksback9.Hole5).Include(northlinksback9 => northlinksback9.Hole6).Include(northlinksback9 => northlinksback9.Hole7).Include(northlinksback9 => northlinksback9.Hole8).Include(northlinksback9 => northlinksback9.Hole9).ToList());
        }

        //
        // GET: /NorthLinksBack9/Details/5

        public ViewResult Details(int id)
        {
            ViewBag.GameTotals = gameTotals;
            NorthLinksBack9 northlinksback9 = context.NorthLinksBack9.Single(x => x.Id == id);
            return View(northlinksback9);
        }

        //
        // GET: /NorthLinksBack9/Create
        //[Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.GameTotals = gameTotals;
            ViewBag.PossibleHole1 = context.HoleStatus;
            ViewBag.PossibleHole2 = context.HoleStatus;
            ViewBag.PossibleHole3 = context.HoleStatus;
            ViewBag.PossibleHole4 = context.HoleStatus;
            ViewBag.PossibleHole5 = context.HoleStatus;
            ViewBag.PossibleHole6 = context.HoleStatus;
            ViewBag.PossibleHole7 = context.HoleStatus;
            ViewBag.PossibleHole8 = context.HoleStatus;
            ViewBag.PossibleHole9 = context.HoleStatus;
            return View();
        }

        //
        // POST: /NorthLinksBack9/Create
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(NorthLinksBack9 northlinksback9)
        {
            if (ModelState.IsValid)
            {
                context.NorthLinksBack9.Add(northlinksback9);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameTotals = gameTotals;
            ViewBag.PossibleHole1 = context.HoleStatus;
            ViewBag.PossibleHole2 = context.HoleStatus;
            ViewBag.PossibleHole3 = context.HoleStatus;
            ViewBag.PossibleHole4 = context.HoleStatus;
            ViewBag.PossibleHole5 = context.HoleStatus;
            ViewBag.PossibleHole6 = context.HoleStatus;
            ViewBag.PossibleHole7 = context.HoleStatus;
            ViewBag.PossibleHole8 = context.HoleStatus;
            ViewBag.PossibleHole9 = context.HoleStatus;
            return View(northlinksback9);
        }

        //
        // GET: /NorthLinksBack9/Edit/5
        //[Authorize(Roles = "Admin,User")]
        public ActionResult Edit(int id)
        {
            ViewBag.GameTotals = gameTotals;
            NorthLinksBack9 northlinksback9 = context.NorthLinksBack9.Single(x => x.Id == id);
            ViewBag.PossibleHole1 = context.HoleStatus;
            ViewBag.PossibleHole2 = context.HoleStatus;
            ViewBag.PossibleHole3 = context.HoleStatus;
            ViewBag.PossibleHole4 = context.HoleStatus;
            ViewBag.PossibleHole5 = context.HoleStatus;
            ViewBag.PossibleHole6 = context.HoleStatus;
            ViewBag.PossibleHole7 = context.HoleStatus;
            ViewBag.PossibleHole8 = context.HoleStatus;
            ViewBag.PossibleHole9 = context.HoleStatus;
            return View(northlinksback9);
        }

        //
        // POST: /NorthLinksBack9/Edit/5
        //[Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult Edit(NorthLinksBack9 northlinksback9)
        {
            if (ModelState.IsValid)
            {
                var notPlayed = 0;
                var canWins = 0;
                var usaWins = 0;
                var ties = 0;

                switch (northlinksback9.Hole1Id)
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
                switch (northlinksback9.Hole2Id)
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
                switch (northlinksback9.Hole3Id)
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
                switch (northlinksback9.Hole4Id)
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
                switch (northlinksback9.Hole5Id)
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
                switch (northlinksback9.Hole6Id)
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
                switch (northlinksback9.Hole7Id)
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
                switch (northlinksback9.Hole8Id)
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
                switch (northlinksback9.Hole9Id)
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
                    northlinksback9.MatchStatus = String.Format("CAN +{0} (on {1})", leadingBy, 10 - notPlayed);
                }
                else if (usaWins > canWins)
                {
                    leadingBy = usaWins - canWins;
                    northlinksback9.MatchStatus = String.Format("USA +{0} (on {1})", leadingBy, 10 - notPlayed);
                }
                else
                {
                    northlinksback9.MatchStatus = String.Format("EVEN (on {0})", 10 - notPlayed);
                }

                northlinksback9.UsaPoints = 0;
                northlinksback9.CanPoints = 0;
                northlinksback9.InProgress = true;

                if (notPlayed < leadingBy || notPlayed == 0) //the match is over
                {
                    northlinksback9.InProgress = false;
                    if (canWins > usaWins)
                    {
                        northlinksback9.CanPoints = 1m;
                        northlinksback9.UsaPoints = 0;
                        northlinksback9.MatchStatus = String.Format("CAN WINS {0}-{1}", canWins, usaWins);
                    }
                    else if (usaWins > canWins)
                    {
                        northlinksback9.UsaPoints = 1m;
                        northlinksback9.CanPoints = 0;
                        northlinksback9.MatchStatus = String.Format("USA WINS {0}-{1}", usaWins, canWins);
                    }
                    else
                    {
                        northlinksback9.UsaPoints = .5m;
                        northlinksback9.CanPoints = .5m;
                        northlinksback9.MatchStatus = String.Format("Final TIED {0}-{1}", usaWins, canWins);
                    }
                }

                context.Entry(northlinksback9).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.GameTotals = gameTotals;
                ViewBag.PossibleHole1 = context.HoleStatus;
                ViewBag.PossibleHole2 = context.HoleStatus;
                ViewBag.PossibleHole3 = context.HoleStatus;
                ViewBag.PossibleHole4 = context.HoleStatus;
                ViewBag.PossibleHole5 = context.HoleStatus;
                ViewBag.PossibleHole6 = context.HoleStatus;
                ViewBag.PossibleHole7 = context.HoleStatus;
                ViewBag.PossibleHole8 = context.HoleStatus;
                ViewBag.PossibleHole9 = context.HoleStatus;
                return View(northlinksback9);
            }
        }

        //
        // GET: /NorthLinksBack9/Delete/5
        //[Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            ViewBag.GameTotals = gameTotals;
            ViewBag.PossibleHole1 = context.HoleStatus;
            ViewBag.PossibleHole2 = context.HoleStatus;
            ViewBag.PossibleHole3 = context.HoleStatus;
            ViewBag.PossibleHole4 = context.HoleStatus;
            ViewBag.PossibleHole5 = context.HoleStatus;
            ViewBag.PossibleHole6 = context.HoleStatus;
            ViewBag.PossibleHole7 = context.HoleStatus;
            ViewBag.PossibleHole8 = context.HoleStatus;
            ViewBag.PossibleHole9 = context.HoleStatus;
            NorthLinksBack9 northlinksback9 = context.NorthLinksBack9.Single(x => x.Id == id);
            return View(northlinksback9);
        }

        //
        // POST: /NorthLinksBack9/Delete/5
        //[Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NorthLinksBack9 northlinksback9 = context.NorthLinksBack9.Single(x => x.Id == id);
            context.NorthLinksBack9.Remove(northlinksback9);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}