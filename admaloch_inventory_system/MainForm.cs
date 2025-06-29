using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;



namespace admaloch_inventory_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts; //populate dvgs with data
            dgvProducts.DataSource = Inventory.AllProducts;
        }

        private void AddPartBtn_Click(object sender, EventArgs e)
        {
            AddPart frm = new AddPart();
            frm.Show(); 
        }

       

        private void ModifyPartBtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.SelectedRows.Count > 0 && //check if an item is sleected
                !dgvParts.SelectedRows[0].IsNewRow)
            {
                int partId = Convert.ToInt32(dgvParts.CurrentRow.Cells["PartID"].Value);
                Part selectedPart = Inventory.LookupPart(partId);

                if (selectedPart != null)
                {
                    ModifyPart modifyForm = new ModifyPart(selectedPart);
                    modifyForm.Show();
                }
            }
            else
            {
                MessageBox.Show( "Please select a part to modify.","No Selection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.Show();
        }

        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0 && //check if an item is sleected
         !dgvProducts.SelectedRows[0].IsNewRow)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
                Product selectedProduct = Inventory.LookupProduct(productId);

                if (selectedProduct != null)
                {
                    ModifyProduct modifyForm = new ModifyProduct(selectedProduct);
                    modifyForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvParts.CurrentRow; //get the current row
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.Selected)
            {
                int partId = Convert.ToInt32(activeRow.Cells[0].Value);
                bool success = Inventory.DeletePart(partId);
                if (!success)
                { 
                    MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvProducts.CurrentRow; //get the current row
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.Selected)
            {
                int productId = Convert.ToInt32(activeRow.Cells[0].Value);
                bool success = Inventory.RemoveProduct(productId);
                if (!success)
                {
                    MessageBox.Show("Item failed to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection(); //prevent first row from being default active
        }

        private void productBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();//prevent first row from being default active
        }


        private void searchPartsBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchPartsTxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool matchFound = false;
            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[1].Value.ToString().ToLower().Contains(searchTerm))
                {
                    row.Selected = true;
                    dgvParts.CurrentCell = row.Cells[1]; 
                    matchFound = true;
                    break; 
                }
            }
            if (!matchFound)
            {
                MessageBox.Show("No matching part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchProductsTxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool matchFound = false;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells[1].Value != null &&
                    row.Cells[1].Value.ToString().ToLower().Contains(searchTerm))
                {
                    row.Selected = true;
                    dgvProducts.CurrentCell = row.Cells[1]; 
                    matchFound = true;
                    break; 
                }
            }
            if (!matchFound)
            {
                MessageBox.Show("No matching part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitMainFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
