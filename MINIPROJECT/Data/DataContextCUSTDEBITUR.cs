using Microsoft.EntityFrameworkCore;

namespace MINIPROJECT.Data
{
    public class DataContextCUSTDEBITUR : DbContext
    {
        public DataContextCUSTDEBITUR(DbContextOptions<DataContextCUSTDEBITUR> options) : base(options) { }

        public DbSet<CUSTDEBITUR> CUSTDEBITUR { get; set; }
    }
}
