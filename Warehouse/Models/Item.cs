using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseNetCore.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
    }
}
