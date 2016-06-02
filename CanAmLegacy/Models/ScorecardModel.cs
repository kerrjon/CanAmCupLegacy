using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CanAmLegacy.Models
{
    public class NorthLinksFront9 : DbContext
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter player names")]
        public string CanPlayerName { get; set; }
        [Required(ErrorMessage = "Enter player names")]
        public string UsaPlayerName { get; set; }
        public decimal CanPoints { get; set; }
        public decimal UsaPoints { get; set; }
        public string MatchStatus { get; set; }
        public bool InProgress { get; set; }
        public int Hole1Id { get; set; }
        [ForeignKey("Hole1Id")] public HoleStatus Hole1 { get; set; }
        public int Hole2Id { get; set; }
        [ForeignKey("Hole2Id")] public HoleStatus Hole2 { get; set; }
        public int Hole3Id { get; set; }
        [ForeignKey("Hole3Id")] public HoleStatus Hole3 { get; set; }
        public int Hole4Id { get; set; }
        [ForeignKey("Hole4Id")] public HoleStatus Hole4 { get; set; }
        public int Hole5Id { get; set; }
        [ForeignKey("Hole5Id")] public HoleStatus Hole5 { get; set; }
        public int Hole6Id { get; set; }
        [ForeignKey("Hole6Id")] public HoleStatus Hole6 { get; set; }
        public int Hole7Id { get; set; }
        [ForeignKey("Hole7Id")] public HoleStatus Hole7 { get; set; }
        public int Hole8Id { get; set; }
        [ForeignKey("Hole8Id")] public HoleStatus Hole8 { get; set; }
        public int Hole9Id { get; set; }
        [ForeignKey("Hole9Id")] public HoleStatus Hole9 { get; set; }
        public IEnumerator<object> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    public class NorthLinksBack9 : DbContext
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter player names")]
        public string CanPlayerName { get; set; }
        [Required(ErrorMessage = "Enter player names")]
        public string UsaPlayerName { get; set; }
        public decimal CanPoints { get; set; }
        public decimal UsaPoints { get; set; }
        public string MatchStatus { get; set; }
        public bool InProgress { get; set; }
        public int Hole1Id { get; set; }
        [ForeignKey("Hole1Id")] public HoleStatus Hole1 { get; set; }
        public int Hole2Id { get; set; }
        [ForeignKey("Hole2Id")] public HoleStatus Hole2 { get; set; }
        public int Hole3Id { get; set; }
        [ForeignKey("Hole3Id")] public HoleStatus Hole3 { get; set; }
        public int Hole4Id { get; set; }
        [ForeignKey("Hole4Id")] public HoleStatus Hole4 { get; set; }
        public int Hole5Id { get; set; }
        [ForeignKey("Hole5Id")] public HoleStatus Hole5 { get; set; }
        public int Hole6Id { get; set; }
        [ForeignKey("Hole6Id")] public HoleStatus Hole6 { get; set; }
        public int Hole7Id { get; set; }
        [ForeignKey("Hole7Id")] public HoleStatus Hole7 { get; set; }
        public int Hole8Id { get; set; }
        [ForeignKey("Hole8Id")] public HoleStatus Hole8 { get; set; }
        public int Hole9Id { get; set; }
        [ForeignKey("Hole9Id")] public HoleStatus Hole9 { get; set; }
    }

    public class TerraceView18 : DbContext
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Enter player name")]
        public string CanPlayerName { get; set; }
        [Required(ErrorMessage = "Enter player name")]
        public string UsaPlayerName { get; set; }
        public decimal CanPoints { get; set; }
        public decimal UsaPoints { get; set; }
        public string MatchStatus { get; set; }
        public bool InProgress { get; set; }
        public int Hole1Id { get; set; }
        [ForeignKey("Hole1Id")] public HoleStatus Hole1 { get; set; }
        public int Hole2Id { get; set; }
        [ForeignKey("Hole2Id")] public HoleStatus Hole2 { get; set; }
        public int Hole3Id { get; set; }
        [ForeignKey("Hole3Id")] public HoleStatus Hole3 { get; set; }
        public int Hole4Id { get; set; }
        [ForeignKey("Hole4Id")] public HoleStatus Hole4 { get; set; }
        public int Hole5Id { get; set; }
        [ForeignKey("Hole5Id")] public HoleStatus Hole5 { get; set; }
        public int Hole6Id { get; set; }
        [ForeignKey("Hole6Id")] public HoleStatus Hole6 { get; set; }
        public int Hole7Id { get; set; }
        [ForeignKey("Hole7Id")] public HoleStatus Hole7 { get; set; }
        public int Hole8Id { get; set; }
        [ForeignKey("Hole8Id")] public HoleStatus Hole8 { get; set; }
        public int Hole9Id { get; set; }
        [ForeignKey("Hole9Id")] public HoleStatus Hole9 { get; set; }
        public int Hole10Id { get; set; }
        [ForeignKey("Hole10Id")] public HoleStatus Hole10 { get; set; }
        public int Hole11Id { get; set; }
        [ForeignKey("Hole11Id")] public HoleStatus Hole11 { get; set; }
        public int Hole12Id { get; set; }
        [ForeignKey("Hole12Id")] public HoleStatus Hole12 { get; set; }
        public int Hole13Id { get; set; }
        [ForeignKey("Hole13Id")] public HoleStatus Hole13 { get; set; }
        public int Hole14Id { get; set; }
        [ForeignKey("Hole14Id")] public HoleStatus Hole14 { get; set; }
        public int Hole15Id { get; set; }
        [ForeignKey("Hole15Id")] public HoleStatus Hole15 { get; set; }
        public int Hole16Id { get; set; }
        [ForeignKey("Hole16Id")] public HoleStatus Hole16 { get; set; }
        public int Hole17Id { get; set; }
        [ForeignKey("Hole17Id")] public HoleStatus Hole17 { get; set; }
        public int Hole18Id { get; set; }
        [ForeignKey("Hole18Id")] public HoleStatus Hole18 { get; set; }
    }

    public class HoleStatus : DbContext
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}