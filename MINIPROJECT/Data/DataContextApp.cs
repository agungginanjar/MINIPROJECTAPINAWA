using Microsoft.EntityFrameworkCore;

namespace MINIPROJECT.Data
{
    public class DataContextApp : DbContext
    {
        public DataContextApp(DbContextOptions<DataContextApp> options) : base(options) { }

        public DbSet<App> APP { get; set; }
    }
}
