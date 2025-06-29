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
    }
}

