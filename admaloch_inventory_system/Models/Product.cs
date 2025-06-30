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

        public BindingList<Part> AssociatedParts { get; } = new BindingList<Part>();

        // Instance methods now
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public Part LookupAssociatedPart(int partId)
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partId);
        }

        public bool RemoveAssociatedPart(int partId)
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
