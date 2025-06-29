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
           FormUtils.DeleteRowHelper(dgvParts, "part");//helper func to export repeated logic
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            FormUtils.DeleteRowHelper(dgvProducts, "product");//helper func to export repeated logic
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
            FormUtils.LocateAndSelectRowHelper(dgvParts, searchPartsTxt.Text);//helper func to export repeated logic
        }

        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            FormUtils.LocateAndSelectRowHelper(dgvProducts, searchProductsTxt.Text);//helper func to export repeated logic
        }

        private void ExitMainFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
