using admaloch_inventory_system.Models;
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
            this.Load += AddPart_Load;
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;//disable save btn unless form validated
            ValidateForm();//initial validate -- will make necesary inputs red
            
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
                originLbl.Text = "Machine ID";
            }
            else if (outsourceBtn.Checked)
            {
                originLbl.Text = "Company";
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

            // min/max validation
            bool minValid = int.TryParse(minTxt.Text, out int min);
            bool maxValid = int.TryParse(maxTxt.Text, out int max);

            // Min validation
            if (!minValid)
            {
                minTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                minTxt.BackColor = Color.White;
            }

            // Max validation
            if (!maxValid)
            {
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }
            else
            {
                maxTxt.BackColor = Color.White;
            }

            // extra logic: Min should not be greater than Max
            if (minValid && maxValid && min > max)
            {
                minTxt.BackColor = Color.LightCoral;
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }


            // MachineID or Company Name
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



            saveBtn.Enabled = allValid;
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            if (inHouseBtn.Checked)
            {
                Inventory.AddPart(new Inhouse
                {
                    Name = nameTxt.Text,
                    InStock = int.Parse(inventoryTxt.Text),
                    Price = decimal.Parse(priceTxt.Text),
                    Min = int.Parse(minTxt.Text),
                    Max = int.Parse(maxTxt.Text),
                    MachineID = int.Parse(partOriginTxt.Text) // Assuming this input is used for MachineID when In-House
                });
            }
            else
            {
                Inventory.AddPart(new Outsourced
                {
                    Name = nameTxt.Text,
                    InStock = int.Parse(inventoryTxt.Text),
                    Price = decimal.Parse(priceTxt.Text),
                    Min = int.Parse(minTxt.Text),
                    Max = int.Parse(maxTxt.Text),
                    CompanyName = partOriginTxt.Text // Same input box used for CompanyName when Outsourced
                });
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
