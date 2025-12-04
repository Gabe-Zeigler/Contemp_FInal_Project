using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contemp_FInal_Project.Tables;

namespace Contemp_FInal_Project.Data
{
    public class Contemp_Final_Project_Context : DbContext
    {
        public Contemp_Final_Project_Context (DbContextOptions<Contemp_Final_Project_Context> options)
            : base(options)
        {
        }

        public DbSet<Contemp_FInal_Project.Tables.VideoGamesTable> VideoGamesTable { get; set; } = default!;
    }
}
