using admaloch_inventory_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace admaloch_inventory_system.Services
{
    public static class Inventory
    {
        public static BindingList<Product> AllProducts { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        // Static constructor to initialize sample data
        static Inventory()
        {
            // Parts
            AllParts.Add(new Inhouse
            {
                PartID = 0,
                Name = "Wheel",
                InStock = 15,
                Price = 12.11m,
                Min = 5,
                Max = 25,
                MachineID = 100
            });

            AllParts.Add(new Outsourced
            {
                PartID = 1,
                Name = "Pedal",
                InStock = 11,
                Price = 8.22m,
                Min = 5,
                Max = 25,
                CompanyName = "Pedal Co."
            });

            AllParts.Add(new Outsourced
            {
                PartID = 2,
                Name = "Chain",
                InStock = 12,
                Price = 8.33m,
                Min = 5,
                Max = 25,
                CompanyName = "Chain Supply"
            });

            AllParts.Add(new Inhouse
            {
                PartID = 3,
                Name = "Seat",
                InStock = 8,
                Price = 4.55m,
                Min = 2,
                Max = 15,
                MachineID = 101
            });

            // Products
            Inventory.addProduct(0, "Red Bicycle", 15, 11.44m, 1, 25);
            Inventory.addProduct(1, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Inventory.addProduct(2, "Blue Bicycle", 5, 12.77m, 1, 25);
        }

       public static void addProduct(int id, string name, int stock, decimal price, int min, int max)
        {
            Product product = new Product
            {
                ProductID = id,
                Name = name,
                InStock = stock,
                Price = price,
                Min = min,
                Max = max
            };

            AllProducts.Add(product);
        }
        public static void addPart( int id, string name, int stock, decimal price, int min, int max, int machineID = null, string companyName = null)
        {
            if(machineID != null)
            {
 Inhouse part = new Inhouse
            {
                ProductID = id,
                Name = name,
                InStock = stock,
                Price = price,
                Min = min,
                Max = max,
                MachineID = 101
            };

            AllParts.Add(part);
            }
           

          
        }

    }
}
