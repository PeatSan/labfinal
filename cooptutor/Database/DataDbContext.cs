using Microsoft.EntityFrameworkCore;
using cooptutor.Models;

namespace cooptutor.Database
{
     public class DataDbContext:DbContext
    {
        // Constructure Method
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

        // Table emp
        public DbSet<employees> employees { get; set; }
        //Table ptosition
        public DbSet<position> positions { get; set; }
    }
}
