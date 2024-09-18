using Microsoft.EntityFrameworkCore;

namespace Expance_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }

   
}
