using System.Collections.Generic;
using System.Data.Entity;
using CanAmLegacy.Models;

namespace CanAmLegacy.SeedData
{
    public class CanAmSeedData : DropCreateDatabaseIfModelChanges<CanAmCupContext>
    {
        protected override void Seed(CanAmCupContext context)
        {
            var status = new List<HoleStatus>
                             {
                                 new HoleStatus {Status = "Not Played", Id = 1},
                                 new HoleStatus {Status = "Tie", Id = 2},
                                 new HoleStatus {Status = "CAN", Id = 3},
                                 new HoleStatus {Status = "USA", Id = 4},
                             };
            status.ForEach(d => context.HoleStatus.Add(d));
        }
    }
}