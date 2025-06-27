using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace admaloch_inventory_system
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            addPartSaveBtn.Enabled = false;

            // Hook shared listener for validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;
            machineIdTxt.TextChanged += SharedInputChanged;
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

            // Max: integer
            if (!int.TryParse(maxTxt.Text, out _))
            {
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                maxTxt.BackColor = Color.White;
            }

            // Min: integer
            if (!int.TryParse(minTxt.Text, out _))
            {
                minTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                minTxt.BackColor = Color.White;
            }

            // MachineID: integer (you can skip this check if Outsourced is selected)
            if (!int.TryParse(machineIdTxt.Text, out _))
            {
                machineIdTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                machineIdTxt.BackColor = Color.White;
            }

            addPartSaveBtn.Enabled = allValid;
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            // Save logic here
        }
    }
}
