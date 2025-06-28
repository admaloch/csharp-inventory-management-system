using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public static void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public static Part LookupAssociatedPart(int partId)
        {
            var part = AssociatedParts.FirstOrDefault(p => p.PartID == partId);
            return part;
        }

        public static bool RemoveAssociatedPart(int partId)
        {
            var partToRemove = LookupAssociatedPart(partId);
            if (partToRemove != null)
            {
                return AssociatedParts.Remove(partToRemove);
            }
            else
            {
                MessageBox.Show("Part not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }

}
