using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            this.Load += AddPart_Load; //run some code on load
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts; //connect data to dvg
            dgvAssociatedParts.DataSource = Product.AssociatedParts;

            saveBtn.Enabled = false; //disable save btn unless form validated

            ValidateForm(); //initial validate -- will make necesary inputs red

            nameTxt.TextChanged += SharedInputChanged; //add inuts to shared listener for validation
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;

            idTxt.Text = GenNextProductId().ToString(); //set value of id
        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        

        private void ProductSearchBtn_Click(object sender, EventArgs e)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvParts.CurrentRow; 
            if(activeRow != null)
            {
                int partId = Convert.ToInt32(activeRow.Cells[0].Value);
                Part currentListItem = Inventory.LookupPart(partId);
                if (currentListItem is Inhouse inhouseItem)
                {
                    Product.AddAssociatedPart(inhouseItem);
                } else if (currentListItem is Outsourced outsourcedItem)
                {
                    Product.AddAssociatedPart(outsourcedItem);
                }
                ValidateForm();
                return;
            }
            MessageBox.Show("No matching part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
       {
            DataGridViewRow activeRow = dgvAssociatedParts.CurrentRow; //get the current row
            if (dgvAssociatedParts.CurrentRow != null && dgvAssociatedParts.CurrentRow.Selected)
            {
                int itemId = Convert.ToInt32(activeRow.Cells[0].Value);
                bool success = Product.RemoveAssociatedPart(itemId);
                ValidateForm();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Inventory.AddProduct(new Product
            {
                ProductID = GenNextProductId(),
                Name = nameTxt.Text,
                Price = decimal.Parse(priceTxt.Text),
                InStock = int.Parse(inventoryTxt.Text),
                Min = int.Parse(minTxt.Text),
                Max = int.Parse(maxTxt.Text),
            });
            this.Close();
            MessageBox.Show("Product successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GenNextProductId()
        {
            return  Inventory.AllProducts.Any()
               ? Inventory.AllProducts.Max(p => p.ProductID) + 1
               : 0;
        }

        private void ValidateForm()
        {
            bool sharedValid = FormValidationService.ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            bool hasAssociatedParts = Product.AssociatedParts.Count > 0;

            saveBtn.Enabled = sharedValid && hasAssociatedParts;
        }
    }
}
