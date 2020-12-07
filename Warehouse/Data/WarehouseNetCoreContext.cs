using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WarehouseNetCore.Models;

namespace WarehouseNetCore.Data
{
    public class WarehouseNetCoreContext : DbContext
    {
        public WarehouseNetCoreContext (DbContextOptions<WarehouseNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<WarehouseNetCore.Models.Item> Item { get; set; }
    }
}
