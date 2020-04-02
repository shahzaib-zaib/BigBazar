using BigBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazar.Database
{
    public class BDContext : DbContext, IDisposable
    {
        public BDContext() : base("BigBazarConnection")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
