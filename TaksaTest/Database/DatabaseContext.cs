using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaksaTest.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("TaksaTest")
        {
        }

        public virtual DbSet<Pretplatnik_EP> Pretplatnici_EP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffedug).HasPrecision(7, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffetuz).HasPrecision(7, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffenal).HasPrecision(7, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffeizv).HasPrecision(7, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffetrop).HasPrecision(5, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffetrnl).HasPrecision(5, 2);
            modelBuilder.Entity<Pretplatnik_EP>().Property(p => p.ffetriz).HasPrecision(5, 2);
        }
    }
}
