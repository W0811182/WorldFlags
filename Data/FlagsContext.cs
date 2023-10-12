using Microsoft.EntityFrameworkCore;
using WorldFlags.Models;

namespace WorldFlags.Data
{
    public class FlagsContext : DbContext
    {
        public FlagsContext(DbContextOptions<FlagsContext> options)
              : base(options)
        {
        }

        public DbSet<Flag> Flag { get; set; }
    }
}
