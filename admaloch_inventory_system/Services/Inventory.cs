using admaloch_inventory_system.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
            Inventory.AddPart(new Inhouse
            {
                PartID = 0,
                Name = "Wheel",
                InStock = 15,
                Price = 12.11m,
                Min = 5,
                Max = 25,
                MachineID = 100
            });

            Inventory.AddPart(new Outsourced
            {
                PartID = 1,
                Name = "Pedal",
                InStock = 11,
                Price = 8.22m,
                Min = 5,
                Max = 25,
                CompanyName = "Pedal Co."
            });

            Inventory.AddPart(new Outsourced
            {
                PartID = 2,
                Name = "Chain",
                InStock = 12,
                Price = 8.33m,
                Min = 5,
                Max = 25,
                CompanyName = "Chain Supply"
            });

            Inventory.AddPart(new Inhouse
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
            Inventory.AddProduct(new Product
            {
                ProductID = 0,
                Name = "Red Bicycle",
                InStock = 15,
                Price = 11.44m,
                Min = 1,
                Max = 25
            });

            Inventory.AddProduct(new Product
            {
                ProductID = 1,
                Name = "Yellow Bicycle",
                InStock = 19,
                Price = 9.66m,
                Min = 1,
                Max = 20
            });

            Inventory.AddProduct(new Product
            {
                ProductID = 2,
                Name = "Blue Bicycle",
                InStock = 5,
                Price = 12.77m,
                Min = 1,
                Max = 25
            });
        }

        //for adding/updating/locating/deleting products
        public static void AddProduct(Product product)
        {
            AllProducts.Add(product);
        }

        public static Product LookupProduct(int productId)
        {
            var product = AllProducts.FirstOrDefault(p => p.ProductID == productId);
            return product;
        }

        public static bool RemoveProduct(int  productId)
        {
            var productToRemove = Inventory.LookupProduct(productId);
            if (productToRemove != null) 
            {
                return AllProducts.Remove(productToRemove);
            }
            else
            {
                MessageBox.Show("Product not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static void UpdateProduct(int productId, Product product)
        {
            // Find index of the product to update
            int index = AllProducts.ToList().FindIndex(p => p.ProductID == productId);

            if (index >= 0)
            {
                // Replace the old product with the updated product at the found index
                AllProducts[index] = product;
            }
            else
            {
                MessageBox.Show("Product not found to update.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        //for adding/updating/locating/deleting parts
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static Part LookupPart(int partId)
        {
            var part = AllParts.FirstOrDefault(p => p.PartID == partId);
            return part;
        }

        public static bool DeletePart(int partId)
        {
            var partToRemove = LookupPart(partId);
            if (partToRemove != null)
            {
                return AllParts.Remove(partToRemove);
            }
            else
            {
                MessageBox.Show("Part not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void UpdatePart(int partId, Part updatedPart)
        {
            int index = AllParts.ToList().FindIndex(p => p.PartID == partId);

            if (index >= 0)
            {
                AllParts[index] = updatedPart;
            }
            else
            {
                MessageBox.Show(
                    "Part not found to update.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
