using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorldFlags.Models;

namespace WorldFlags.Data
{
    public class WorldFlagsContext : DbContext
    {
        public WorldFlagsContext (DbContextOptions<WorldFlagsContext> options)
            : base(options)
        {
        }

        public DbSet<WorldFlags.Models.Flag> Flag { get; set; }
    }
}
