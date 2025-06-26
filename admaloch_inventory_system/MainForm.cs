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
            dataGridView1.Rows.Add(0, "Wheel", 15, 12.11, 5, 25); //populate data for parts grid
            dataGridView1.Rows.Add(1, "Pedal", 11, 8.22, 5, 25);
            dataGridView1.Rows.Add(2, "Chain", 12, 8.33, 5, 25);
            dataGridView1.Rows.Add(3, "Seat", 8, 4.55, 2, 15);

            dataGridView2.Rows.Add(0, "Red Bicycle", 15, 11.44, 1, 25); //populate data for products grid
            dataGridView2.Rows.Add(1, "Yellow Bicycle", 19, 9.66, 1, 20);
            dataGridView2.Rows.Add(2, "Blue Bicycle", 5, 12.77, 1, 25);

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
    }
}
