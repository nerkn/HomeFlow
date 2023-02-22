using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeFlow.Models;

namespace HomeFlow.Data
{
    public class HomeFlowContext : DbContext
    {
        public HomeFlowContext (DbContextOptions<HomeFlowContext> options)
            : base(options)
        {
        }

        public DbSet<HomeFlow.Models.Villa> Villa { get; set; } = default!;
    }
}
