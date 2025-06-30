using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using admaloch_inventory_system.Enums;

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
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.Show();
        }

        private void ModifyPartBtn_Click(object sender, EventArgs e)
        {
            FormUtils.ModifyBtnClickHelper(dgvParts, ItemType.Part);
        }

        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            FormUtils.ModifyBtnClickHelper(dgvProducts, ItemType.Product);
        }

        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
           FormUtils.DeleteRowHelper(dgvParts, ItemType.Part);//helper func to export repeated logic
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            FormUtils.DeleteRowHelper(dgvProducts, ItemType.Product);//helper func to export repeated logic
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
