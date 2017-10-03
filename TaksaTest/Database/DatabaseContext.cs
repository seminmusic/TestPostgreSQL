using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TaksaTest.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("TaksaTest")
        {
        }

        public virtual DbSet<Korisnik> Korisnici { get; set; }
        public virtual DbSet<Kartica> Kartice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
