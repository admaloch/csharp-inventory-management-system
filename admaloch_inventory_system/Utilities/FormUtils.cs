using admaloch_inventory_system.Enums;
using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using System;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    public static class FormUtils
    {
        public static bool LocateAndSelectRowHelper(DataGridView dgv, string searchInput)
        {
            string searchTerm = searchInput.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (Utils.SelectSearchedRow(dgv, searchTerm, 1))//search name field
            {
                return true;
            }

            if (Utils.SelectSearchedRow(dgv, searchTerm, 0))//search id if name doesn't find anything
            {
                return true;
            }

            MessageBox.Show("No matching item found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public static bool DeleteProductAndPartRowHelper(DataGridView dgv, ItemType type )
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
                    default:
                        break;
                }
                MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public static bool DeleteAssociatedPartsRowHelper(DataGridView dgv, Product product )
        {
            if (Utils.IsRowSelected(dgv))
            {
                int itemId = Utils.GrabDgvRowId(dgv);
                bool success = product.RemoveAssociatedPart(itemId);
                if (!success)
                {
                    MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void AddAssociatedPartHelper(DataGridView dgv, Product product)
        {
            if (dgv.CurrentRow != null)
            {
                int partId = Utils.GrabDgvRowId(dgv);
                Part currentListItem = Inventory.LookupPart(partId);

                if (currentListItem is Inhouse inhouseItem)
                    product.AddAssociatedPart(inhouseItem);
                else if (currentListItem is Outsourced outsourcedItem)
                    product.AddAssociatedPart(outsourcedItem);
                else
                    MessageBox.Show("Invalid part type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No matching part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

    }
}

