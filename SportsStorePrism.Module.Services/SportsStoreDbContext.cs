using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsstorePrism.Infrastucture.Entities;

namespace SportsStorePrism.Module.Services
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext() : base("SportsStoreConnection") { }

        public DbSet<Product> Products { get; set; }
    }
}
