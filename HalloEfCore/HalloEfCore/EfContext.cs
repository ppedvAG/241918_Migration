using Microsoft.EntityFrameworkCore;

namespace HalloEfCore
{
    internal class EfContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString = "Server=(localdb)\\mssqllocaldb;Database=Cars;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
