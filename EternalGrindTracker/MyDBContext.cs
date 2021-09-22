using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EternalGrindTracker
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public DbSet<Material> Materials { get; set; } // My domain models
        public DbSet<Eternal> Eternals { get; set; }// My domain models
    }
}
