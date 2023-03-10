using Microsoft.EntityFrameworkCore;

namespace SolidAPI.Entities
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=solid;User ID=sa;Password=123456");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Buyer> Buyers { get; set; }
    }
}
