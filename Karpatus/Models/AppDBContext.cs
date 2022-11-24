using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<EventTablModel> EventTabl { get; set; }
  
        public DbSet<JoinTablModel> JoinTabl { get; set; }
        public DbSet<PlaceTablModel> PlaceTabl { get; set; }


    }
}
