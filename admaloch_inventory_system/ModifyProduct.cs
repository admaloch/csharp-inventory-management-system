using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class ModifyProduct : Form
    {
        private Product selectedProduct;

        public ModifyProduct(Product product)
        {
            selectedProduct = product;
            InitializeComponent();
            this.Load += AddPart_Load;
            dgvParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = Product.AssociatedParts;
            LoadProductData();
        }

        private void LoadProductData()
        {
            //load the current item data from the main form
            idTxt.Text = selectedProduct.ProductID.ToString();
            nameTxt.Text = selectedProduct.Name;
            inventoryTxt.Text = selectedProduct.InStock.ToString();
            priceTxt.Text = selectedProduct.Price.ToString();
            maxTxt.Text = selectedProduct.Max.ToString();
            minTxt.Text = selectedProduct.Min.ToString();

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

        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            FormUtils.LocateAndSelectRowHelper(dgvParts, searchPartsTxt.Text);//helper func to export repeated logic

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                int partId = Convert.ToInt32(dgvParts.CurrentRow.Cells[0].Value);
                Part currentListItem = Inventory.LookupPart(partId);
                if (currentListItem is Inhouse inhouseItem)
                {
                    Product.AddAssociatedPart(inhouseItem);
                }
                else if (currentListItem is Outsourced outsourcedItem)
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
            Inventory.UpdateProduct(selectedProduct.ProductID, new Product
            {
                ProductID = selectedProduct.ProductID,
                Name = nameTxt.Text,
                Price = decimal.Parse(priceTxt.Text),
                InStock = int.Parse(inventoryTxt.Text),
                Min = int.Parse(minTxt.Text),
                Max = int.Parse(maxTxt.Text),
            });
            this.Close();
            MessageBox.Show("Product successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateForm()
        {
            bool sharedValid = FormValidationService.ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            bool hasAssociatedParts = Product.AssociatedParts.Count > 0;

            saveBtn.Enabled = sharedValid && hasAssociatedParts;
        }
    }
}
