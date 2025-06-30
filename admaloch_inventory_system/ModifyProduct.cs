using admaloch_inventory_system.Enums;
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
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, saveBtn);//initial validate -- will make necesary inputs red

            // Hook shared listener for validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;
        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, saveBtn);
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
                ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, saveBtn);
                return;
            }
            MessageBox.Show("No matching part found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FormUtils.DeleteRowHelper(dgvAssociatedParts, ItemType.Associated);//helper func to export repeated logic
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, saveBtn);
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
    }
}
