using System.Data.Entity;

namespace CanAmLegacy.Models
{
    public class CanAmCupContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<CanAmCup.Models.CanAmCupContext>());

        public DbSet<HoleStatus> HoleStatus { get; set; }

        public DbSet<TerraceView18> TerraceView18 { get; set; }

        public DbSet<NorthLinksFront9> NorthLinksFront9 { get; set; }

        public DbSet<NorthLinksBack9> NorthLinksBack9 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole1).WithMany().HasForeignKey(m => m.Hole1Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole2).WithMany().HasForeignKey(m => m.Hole2Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole3).WithMany().HasForeignKey(m => m.Hole3Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole4).WithMany().HasForeignKey(m => m.Hole4Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole5).WithMany().HasForeignKey(m => m.Hole5Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole6).WithMany().HasForeignKey(m => m.Hole6Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole7).WithMany().HasForeignKey(m => m.Hole7Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole8).WithMany().HasForeignKey(m => m.Hole8Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksBack9>().HasRequired(m => m.Hole9).WithMany().HasForeignKey(m => m.Hole9Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole1).WithMany().HasForeignKey(m => m.Hole1Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole2).WithMany().HasForeignKey(m => m.Hole2Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole3).WithMany().HasForeignKey(m => m.Hole3Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole4).WithMany().HasForeignKey(m => m.Hole4Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole5).WithMany().HasForeignKey(m => m.Hole5Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole6).WithMany().HasForeignKey(m => m.Hole6Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole7).WithMany().HasForeignKey(m => m.Hole7Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole8).WithMany().HasForeignKey(m => m.Hole8Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<NorthLinksFront9>().HasRequired(m => m.Hole9).WithMany().HasForeignKey(m => m.Hole9Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole1).WithMany().HasForeignKey(m => m.Hole1Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole2).WithMany().HasForeignKey(m => m.Hole2Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole3).WithMany().HasForeignKey(m => m.Hole3Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole4).WithMany().HasForeignKey(m => m.Hole4Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole5).WithMany().HasForeignKey(m => m.Hole5Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole6).WithMany().HasForeignKey(m => m.Hole6Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole7).WithMany().HasForeignKey(m => m.Hole7Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole8).WithMany().HasForeignKey(m => m.Hole8Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole9).WithMany().HasForeignKey(m => m.Hole9Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole10).WithMany().HasForeignKey(m => m.Hole10Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole11).WithMany().HasForeignKey(m => m.Hole11Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole12).WithMany().HasForeignKey(m => m.Hole12Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole13).WithMany().HasForeignKey(m => m.Hole13Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole14).WithMany().HasForeignKey(m => m.Hole14Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole15).WithMany().HasForeignKey(m => m.Hole15Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole16).WithMany().HasForeignKey(m => m.Hole16Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole17).WithMany().HasForeignKey(m => m.Hole17Id).WillCascadeOnDelete(false);
            modelBuilder.Entity<TerraceView18>().HasRequired(m => m.Hole18).WithMany().HasForeignKey(m => m.Hole18Id).WillCascadeOnDelete(false);
        }
    }
}