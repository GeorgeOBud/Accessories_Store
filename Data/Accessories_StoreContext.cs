using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Accessories_Store.Models;

namespace Accessories_Store.Data
{
    public class Accessories_StoreContext : DbContext
    {
        public Accessories_StoreContext (DbContextOptions<Accessories_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Accessories_Store.Models.Product> Product { get; set; } = default!;

        public DbSet<Accessories_Store.Models.Vendor>? Vendor { get; set; }
    }
}
