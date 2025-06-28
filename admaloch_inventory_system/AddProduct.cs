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
            this.Load += AddPart_Load;
            dgvParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = Product.AssociatedParts;
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;//disable save btn unless form validated
            ValidateForm();//initial validate -- will make necesary inputs red

           
            // Hook shared listener for validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;

            //set value of id
            int nextProductId = Inventory.AllProducts.Any()
               ? Inventory.AllProducts.Max(p => p.ProductID) + 1
               : 0;
            idTxt.Text = nextProductId.ToString();

        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            bool allValid = true;

            // Name: non-empty
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                nameTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                nameTxt.BackColor = Color.White;
            }

            // Inventory: integer
            if (!int.TryParse(inventoryTxt.Text, out _))
            {
                inventoryTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                inventoryTxt.BackColor = Color.White;
            }

            // Price: decimal
            if (!decimal.TryParse(priceTxt.Text, out _))
            {
                priceTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                priceTxt.BackColor = Color.White;
            }

            // min/max validation
            bool minValid = int.TryParse(minTxt.Text, out int min);
            bool maxValid = int.TryParse(maxTxt.Text, out int max);

            // Min validation
            if (!minValid)
            {
                minTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                minTxt.BackColor = Color.White;
            }

            // Max validation
            if (!maxValid)
            {
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                maxTxt.BackColor = Color.White;
            }

            // extra logic: Min should not be greater than Max
            if (minValid && maxValid && min > max)
            {
                minTxt.BackColor = Color.LightCoral;
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }

            if(Product.AssociatedParts.Count == 0)
            {
                allValid = false;
            }



            saveBtn.Enabled = allValid;
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
                if (success)
                {
                    MessageBox.Show("Item successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ValidateForm();
                }
                else
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
    }
}
