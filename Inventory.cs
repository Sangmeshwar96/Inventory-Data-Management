

using System;
using System.Collections.Generic;

namespace Data_Inventory_Management
{

    public class Inventory
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
    }

    public class Root
    {
        public List<Inventory> inventories { get; set; }
    }
}