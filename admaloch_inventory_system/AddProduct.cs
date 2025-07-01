using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using admaloch_inventory_system.Enums;
using System;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class AddProduct : Form
    {            
        private Product newProduct;

        public AddProduct()
        {
            InitializeComponent();
            this.Load += AddPart_Load; //run some code on load
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            newProduct = new Product//instantiate a new product class
            {
                ProductID = Utils.CalcNextItemId(ItemType.Product)
            };

            dgvParts.DataSource = Inventory.AllParts; //connect data to dvg
            dgvAssociatedParts.DataSource = newProduct.AssociatedParts;


            //initial validate -- will make necesary inputs red
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);

            nameTxt.TextChanged += SharedInputChanged; //add inuts to shared listener for validation
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;

            idTxt.Text = Utils.CalcNextItemId(ItemType.Product).ToString(); //set value of id
        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            FormUtils.LocateAndSelectRowHelper(dgvParts, searchPartsTxt.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormUtils.AddAssociatedPartHelper(dgvParts, newProduct);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FormUtils.DeleteAssociatedPartsRowHelper(dgvAssociatedParts, newProduct);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool isValidated = ValidationUtils.ValidateProductForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            if (!isValidated)
            {
                ValidationUtils.ValidationErrMsg(inventoryTxt, minTxt, maxTxt);
                return;
            }
            // Update newProduct's properties from form inputs
            newProduct.Name = nameTxt.Text;
            newProduct.Price = decimal.Parse(priceTxt.Text);
            newProduct.InStock = int.Parse(inventoryTxt.Text);
            newProduct.Min = int.Parse(minTxt.Text);
            newProduct.Max = int.Parse(maxTxt.Text);
            Inventory.AddProduct(newProduct);
            this.Close();
            MessageBox.Show("Product successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
