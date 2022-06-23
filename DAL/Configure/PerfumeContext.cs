using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Configure
{
    public class PerfumeContext : DbContext
    {
        public DbSet<Perfume> Perfumes { get; set; }

        public PerfumeContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
