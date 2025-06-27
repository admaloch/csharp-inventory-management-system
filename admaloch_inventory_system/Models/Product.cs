using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admaloch_inventory_system.Models
{
    public class Product
    {
        private static int _nextId = 0; // static counter for auto-incrementing

        public int ProductID { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            ProductID = _nextId++;
        }
    }

}
