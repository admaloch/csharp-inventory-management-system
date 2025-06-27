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
            if (dgvParts.CurrentRow == null || dgvParts.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select something to delete.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                dgvParts.Rows.Remove(dgvParts.CurrentRow);
            }

        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow activeRow = dgvParts.CurrentRow; //get the current row
            if (dgvParts.CurrentRow == null || dgvParts.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select something to delete.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                dgvParts.Rows.Remove(dgvParts.CurrentRow);
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
