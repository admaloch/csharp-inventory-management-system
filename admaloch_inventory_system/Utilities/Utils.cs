using admaloch_inventory_system.Enums;
using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    internal class Utils
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
            if (row.Cells[1].Value != null &&
            row.Cells[1].Value.ToString().ToLower().Contains(searchTerm))
            {
                return true;
            }
            return false;
        }

        public static int CalcNextItemId(ItemType type) //helper to access next id
        {
            if (type == ItemType.Part)
            {
                return Inventory.AllParts.Any()
                        ? Inventory.AllParts.Max(p => p.PartID) + 1
                        : 0;
            }
            else
            {
                return Inventory.AllProducts.Any()
                    ? Inventory.AllProducts.Max(p => p.ProductID) + 1
                    : 0;
            }
        }

        public static int GrabDgvRowId(DataGridView dgv)//util for taking dgv and grabbing the id val.. always first column
        {
            return Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
        }
        public static bool IsRowSelected(DataGridView dgv)//util for determining if a dgv row is selected
        {
            if (dgv.SelectedRows.Count > 0 && !dgv.SelectedRows[0].IsNewRow)
            {
                return true;
            }
            return false;
        }
    }
}
