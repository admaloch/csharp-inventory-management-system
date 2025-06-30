using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Enums;

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    public static class FormUtils
    {


        public static bool LocateAndSelectRowHelper(DataGridView dgv, string searchInput, int columnIndex = 1)
        {
            string searchTerm = searchInput.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Utils.LocateSearchTerm(row, searchTerm))
                {
                    row.Selected = true;
                    dgv.CurrentCell = row.Cells[columnIndex];
                    return true;
                }
            }

            MessageBox.Show("No matching item found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public static bool DeleteRowHelper(DataGridView dgv, ItemType type )
        {
            if (Utils.IsRowSelected(dgv)) //check if a row is currently selected
            {
                int itemId = Utils.GrabDgvRowId(dgv);//grab row id val

                switch (type)//determine method depending on ItemType
                {
                    case ItemType.Part:
                        return Inventory.DeletePart(itemId);
                    case ItemType.Product:
                        return Inventory.RemoveProduct(itemId);
                    case ItemType.Associated:
                        return Product.RemoveAssociatedPart(itemId);
                    default:
                        break;
                }
                MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public static bool ModifyBtnClickHelper(DataGridView dgv, ItemType type)//click dgv row and open mod form
        {
            if (Utils.IsRowSelected(dgv))//check if dgv row is currently selected
            {
                int itemId = Utils.GrabDgvRowId(dgv);// grab row id val

                switch(type)
                {
                    case ItemType.Part:
                        Part selectedPart = Inventory.LookupPart(itemId);
                        if (selectedPart != null)
                        {
                            ModifyPart modifyPartForm = new ModifyPart(selectedPart);
                            modifyPartForm.Show();
                            return true;
                        }
                        break;
                    case ItemType.Product:
                        Product selectedProduct = Inventory.LookupProduct(itemId);
                        if (selectedProduct != null)
                        {
                            ModifyProduct modifyProductForm = new ModifyProduct(selectedProduct);
                            modifyProductForm.Show();
                            return true;
                        }
                        break;
                } 
                MessageBox.Show($"Unable to modify {type}", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show($"Please select a {type} to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void AddProductBtn()
        {

        }
        
    }
}

