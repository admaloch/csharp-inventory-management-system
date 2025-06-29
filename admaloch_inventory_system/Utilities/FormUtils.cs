using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    public static class FormUtils
    {
        public static bool IsTextBoxEmpty(TextBox txt, string message = "Please enter a value.")
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Focus();
                return true;
            }

            return false;
        }

        public static bool LocateSearchTerm(DataGridViewRow row, string searchTerm)
        {
            if(row.Cells[1].Value != null &&
            row.Cells[1].Value.ToString().ToLower().Contains(searchTerm))
            {
                return true;
            }
            return false;
        }

        public static bool LocateAndSelectRowHelper(DataGridView dgv, string searchInput, int columnIndex = 1)
        {
            string searchTerm = searchInput.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string loweredTerm = searchTerm.Trim().ToLower();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (LocateSearchTerm(row, searchTerm))
                {
                    row.Selected = true;
                    dgv.CurrentCell = row.Cells[columnIndex];
                    return true;
                }
            }

            MessageBox.Show("No matching item found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public static bool DeleteRowHelper(DataGridView dgv, string type_ )
        {
            // needs to be updated for associated products.. associatred products may need first column to have different name like associatedId

            DataGridViewRow activeRow = dgv.CurrentRow; //get the current row
            if (dgv.CurrentRow != null && dgv.CurrentRow.Selected)
            {
                int itemId = Convert.ToInt32(activeRow.Cells[0].Value);//grab id val

                if (type_ == "part")
                {
                   return Inventory.DeletePart(itemId);
                }
                else if (type_ == "product")
                {
                    return Inventory.RemoveProduct(itemId);
                }
                else if (type_ == "associated")
                {
                    return Product.RemoveAssociatedPart(itemId);
                }
                MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}

