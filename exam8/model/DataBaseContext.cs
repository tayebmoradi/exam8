using Microsoft.EntityFrameworkCore;

namespace exam8.model
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Coustomer> Cookies { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
