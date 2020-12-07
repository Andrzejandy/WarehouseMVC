using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseNetCore.Models
{
    public class Warehouse
    {
        public string Name { get; set; }
        public List<Item> Goods { get; set; }
    }
}
