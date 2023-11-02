using Microsoft.EntityFrameworkCore;

namespace MINIPROJECT.Data
{
    public class DataContextScuser : DbContext
    {
        public DataContextScuser(DbContextOptions<DataContextScuser> options) : base(options) { }

        public DbSet<SCUSER> SCUSER { get; set; }
    }
}
