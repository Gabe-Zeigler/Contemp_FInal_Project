using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contemp_FInal_Project.Models;

namespace Contemp_FInal_Project.Data
{
    public class Contemp_FInal_ProjectContext : DbContext
    {
        public Contemp_FInal_ProjectContext (DbContextOptions<Contemp_FInal_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Contemp_FInal_Project.Models.Food> Food { get; set; } = default!;
    }
}
