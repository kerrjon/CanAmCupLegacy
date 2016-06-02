using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CanAmLegacy.Helpers;
using CanAmLegacy.Models;

namespace CanAmLegacy.Controllers
{   
    public class NorthLinksFront9Controller : Controller
    {
        private CanAmCupContext context = new CanAmCupContext();
        private readonly GameTotal gameTotals = new GameTotal();
        //
        // GET: /NorthLinksFront9/

        public ViewResult Index()
        {
            ViewBag.GameTotals = gameTotals;
            return View(context.NorthLinksFront9.Include(northlinksfront9 => northlinksfront9.Hole1).Include(northlinksfront9 => northlinksfront9.Hole2).Include(northlinksfront9 => northlinksfront9.Hole3).Include(northlinksfront9 => northlinksfront9.Hole4).Include(northlinksfront9 => northlinksfront9.Hole5).Include(northlinksfront9 => northlinksfront9.Hole6).Include(northlinksfront9 => northlinksfront9.Hole7).Include(northlinksfront9 => northlinksfront9.Hole8).Include(northlinksfront9 => northlinksfront9.Hole9).ToList());
        }

        //
        // GET: /NorthLinksFront9/Details/5

        public ViewResult Details(int id)
        {
            ViewBag.GameTotals = gameTotals;
            NorthLinksFront9 northlinksfront9 = context.NorthLinksFront9.Single(x => x.Id == id);
            return View(northlinksfront9);
        }

        //
        // GET: /NorthLinksFront9/Create
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
        // POST: /NorthLinksFront9/Create
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(NorthLinksFront9 northlinksfront9)
        {
            if (ModelState.IsValid)
            {
                context.NorthLinksFront9.Add(northlinksfront9);
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
            return View(northlinksfront9);
        }
        
        //
        // GET: /NorthLinksFront9/Edit/5
        //[Authorize(Roles = "Admin,User")]
        public ActionResult Edit(int id)
        {
            ViewBag.GameTotals = gameTotals;
            NorthLinksFront9 northlinksfront9 = context.NorthLinksFront9.Single(x => x.Id == id);
            ViewBag.PossibleHole1 = context.HoleStatus;
            ViewBag.PossibleHole2 = context.HoleStatus;
            ViewBag.PossibleHole3 = context.HoleStatus;
            ViewBag.PossibleHole4 = context.HoleStatus;
            ViewBag.PossibleHole5 = context.HoleStatus;
            ViewBag.PossibleHole6 = context.HoleStatus;
            ViewBag.PossibleHole7 = context.HoleStatus;
            ViewBag.PossibleHole8 = context.HoleStatus;
            ViewBag.PossibleHole9 = context.HoleStatus;
            return View(northlinksfront9);
        }

        //
        // POST: /NorthLinksFront9/Edit/5
        //[Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult Edit(NorthLinksFront9 northlinksfront9)
        {
            if (ModelState.IsValid)
            {
                var notPlayed = 0;
                var canWins = 0;
                var usaWins = 0;
                var ties = 0;

                switch (northlinksfront9.Hole1Id)
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
                switch (northlinksfront9.Hole2Id)
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
                switch (northlinksfront9.Hole3Id)
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
                switch (northlinksfront9.Hole4Id)
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
                switch (northlinksfront9.Hole5Id)
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
                switch (northlinksfront9.Hole6Id)
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
                switch (northlinksfront9.Hole7Id)
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
                switch (northlinksfront9.Hole8Id)
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
                switch (northlinksfront9.Hole9Id)
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
                    northlinksfront9.MatchStatus = String.Format("CAN +{0} (on {1})", leadingBy, 10 - notPlayed);
                }
                else if (usaWins > canWins)
                {
                    leadingBy = usaWins - canWins;
                    northlinksfront9.MatchStatus = String.Format("USA +{0} (on {1})", leadingBy, 10 - notPlayed);
                }
                else
                {
                    northlinksfront9.MatchStatus = String.Format("EVEN (on {0})",  10 - notPlayed);
                }

                northlinksfront9.UsaPoints = 0;
                northlinksfront9.CanPoints = 0;
                northlinksfront9.InProgress = true;

                if (notPlayed < leadingBy || notPlayed == 0) //the match is over
                {
                    northlinksfront9.InProgress = false;
                    if (canWins > usaWins)
                    {
                        northlinksfront9.CanPoints = 1m;
                        northlinksfront9.UsaPoints = 0;
                        northlinksfront9.MatchStatus = String.Format("CAN WINS {0}-{1}", canWins, usaWins);
                    }
                    else if (usaWins > canWins)
                    {
                        northlinksfront9.UsaPoints = 1m;
                        northlinksfront9.CanPoints = 0;
                        northlinksfront9.MatchStatus = String.Format("USA WINS {0}-{1}", usaWins, canWins);
                    }
                    else
                    {
                        northlinksfront9.UsaPoints = .5m;
                        northlinksfront9.CanPoints = .5m;
                        northlinksfront9.MatchStatus = String.Format("Final TIED {0}-{1}", usaWins, canWins);
                    }
                }

                context.Entry(northlinksfront9).State = EntityState.Modified;
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
                return View(northlinksfront9);
            }
        }

        //
        // GET: /NorthLinksFront9/Delete/5
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
            NorthLinksFront9 northlinksfront9 = context.NorthLinksFront9.Single(x => x.Id == id);
            return View(northlinksfront9);
        }

        //
        // POST: /NorthLinksFront9/Delete/5
        //[Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NorthLinksFront9 northlinksfront9 = context.NorthLinksFront9.Single(x => x.Id == id);
            context.NorthLinksFront9.Remove(northlinksfront9);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}