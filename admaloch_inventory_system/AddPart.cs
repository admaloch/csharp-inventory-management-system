using admaloch_inventory_system.Services;
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
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            addPartSaveBtn.Enabled = false;//disable save btn unless form validated
            ValidateForm();//initial validate -- will make necesary inputs red
            companyNameLbl.Visible = false;// hide company name label beacuse in-house is default
            
            // Attach shared listener to radio buttons
            inHouseBtn.CheckedChanged += RadioChanged;
            outsourceBtn.CheckedChanged += RadioChanged;

            // Hook shared listener for validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;
            partOriginTxt.TextChanged += SharedInputChanged;

            //set value of id
            int nextPartId = Inventory.AllParts.Any()
               ? Inventory.AllParts.Max(p => p.PartID) + 1
               : 0;
            idTxt.Text = nextPartId.ToString();

        }

        private void RadioChanged(object sender, EventArgs e)
        {
            if (inHouseBtn.Checked)
            {
                companyNameLbl.Visible = false;
                machineLbl.Visible = true;

            }
            else if (outsourceBtn.Checked)
            {
                companyNameLbl.Visible = true;
                machineLbl.Visible = false;
            }

            ValidateForm(); // Revalidate form if needed
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

            // MachineID or Company Name: integer (you can skip this check if Outsourced is selected)
            if (inHouseBtn.Checked)
            {
                // Expecting an integer
                if (!int.TryParse(partOriginTxt.Text.Trim(), out _))
                {
                    partOriginTxt.BackColor = Color.LightCoral;
                    allValid = false;
                }
                else
                {
                    partOriginTxt.BackColor = Color.White;
                }
            }
            else
            {
                // Expecting a non-empty, non-numeric string
                if (string.IsNullOrWhiteSpace(partOriginTxt.Text.Trim()) || int.TryParse(partOriginTxt.Text.Trim(), out _))
                {
                    partOriginTxt.BackColor = Color.LightCoral;
                    allValid = false;
                }
                else
                {
                    partOriginTxt.BackColor = Color.White;
                }
            }



            addPartSaveBtn.Enabled = allValid;
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            // Save logic here
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
