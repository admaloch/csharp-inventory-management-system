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
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.AllProducts;

        }

        private void AddPartBtn_Click(object sender, EventArgs e)
        {
            AddPart frm = new AddPart(); 
            frm.Show(); 
        }

        private void ModifyPartBtn_Click(object sender, EventArgs e)
        {
            ModifyPart frm = new ModifyPart();
            frm.Show();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct frm = new AddProduct();
            frm.Show();
        }

        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            ModifyProduct frm = new ModifyProduct();
            frm.Show();
        }

        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvParts.CurrentRow; //get the current row
            int partId = Convert.ToInt32(activeRow.Cells[0].Value);
            if (dgvParts.CurrentRow != null && dgvParts.CurrentRow.Selected)
            {
                Inventory.DeletePart(partId);
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvProducts.CurrentRow; //get the current row
            int productId = Convert.ToInt32(activeRow.Cells[0].Value);
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.Selected)
            {
                Inventory.RemoveProduct(productId);
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void productBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();

        }
    }
}
