using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using System;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class ModifyProduct : Form
    {
        private Product selectedProduct;

        public ModifyProduct(Product product)
        {
			InitializeComponent();
			selectedProduct = product;
            dgvParts.DataSource = Inventory.AllParts; //set data source for DGVs
            dgvAssociatedParts.DataSource = selectedProduct.AssociatedParts;
            LoadProductData();
			this.Load += AddPart_Load;
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
			//initial validate -- will make necesary inputs red
			ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);

            // Hook shared listener for input validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;
        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            FormUtils.LocateAndSelectRowHelper(dgvParts, searchPartsTxt.Text);//helper func to export repeated logic
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormUtils.AddAssociatedPartHelper(dgvParts, selectedProduct);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FormUtils.DeleteAssociatedPartsRowHelper(dgvAssociatedParts, selectedProduct);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var updatedProduct = new Product
            {
                ProductID = selectedProduct.ProductID,
                Name = nameTxt.Text,
                Price = decimal.Parse(priceTxt.Text),
                InStock = int.Parse(inventoryTxt.Text),
                Min = int.Parse(minTxt.Text),
                Max = int.Parse(maxTxt.Text),
            };

            // Transfer associated parts
            foreach (Part part in selectedProduct.AssociatedParts)
            {
                updatedProduct.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(selectedProduct.ProductID, updatedProduct);
            this.Close();
            MessageBox.Show("Product successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
