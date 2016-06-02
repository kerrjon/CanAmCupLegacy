using System;
using System.Linq;
using CanAmLegacy.Models;

namespace CanAmLegacy.Helpers
{
    public class GameTotal
    {
        private CanAmCupContext context = new CanAmCupContext();
        public decimal CanTotal { get; set; }
        public decimal UsaTotal { get; set; }
        public int GamesInProgress { get; set; }

        public GameTotal()
        {
            CanTotal = Math.Round(GetCanadaTotal(), 1);
            UsaTotal = Math.Round(GetUsaTotal(), 1);
            GamesInProgress = GetGamesInProgress();
        }
        
        private decimal GetCanadaTotal()
        {
            var northLinksFront9Can = context.NorthLinksFront9.Sum(x => (decimal?)x.CanPoints) ?? 0;
            var northLinksBack9Can = context.NorthLinksBack9.Sum(x => (decimal?)x.CanPoints) ?? 0;
            var terraceView18Can = context.TerraceView18.Sum(x => (decimal?)x.CanPoints) ?? 0;
            return northLinksFront9Can + northLinksBack9Can + terraceView18Can;
        }

        private decimal GetUsaTotal()
        {
            var northLinksFront9Usa = context.NorthLinksFront9.Sum(x => (decimal?)x.UsaPoints) ?? 0;
            var northLinksBack9Usa = context.NorthLinksBack9.Sum(x => (decimal?)x.UsaPoints) ?? 0;
            var terraceView18Usa = context.TerraceView18.Sum(x => (decimal?)x.UsaPoints) ?? 0;
            return northLinksFront9Usa + northLinksBack9Usa + terraceView18Usa;
        }

        private int GetGamesInProgress()
        {
            int gamesInProgress = context.NorthLinksBack9.Count(x => x.InProgress) +
                                  context.NorthLinksFront9.Count(x => x.InProgress) +
                                  context.TerraceView18.Count(x => x.InProgress);

            return gamesInProgress;
        }
    }
}