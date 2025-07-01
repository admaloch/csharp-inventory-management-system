using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using System;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class ModifyPart: Form
    {
        private Part selectedPart;
        public ModifyPart(Part part)
        {
            InitializeComponent();
            this.Load += ModifyPart_Load;
            selectedPart = part;
            LoadPartData();
        }

        private void LoadPartData()
        {
            idTxt.Text = selectedPart.PartID.ToString();
            nameTxt.Text = selectedPart.Name;
            inventoryTxt.Text = selectedPart.InStock.ToString();
            priceTxt.Text = selectedPart.Price.ToString();
            maxTxt.Text = selectedPart.Max.ToString();
            minTxt.Text = selectedPart.Min.ToString();

            if (selectedPart is Inhouse inhousePart)
            {
                inHouseBtn.Checked = true;
                originLbl.Text = "Machine ID";
                partOriginTxt.Text = inhousePart.MachineID.ToString();
            }
            else if (selectedPart is Outsourced outsourcedPart)
            {
                outsourceBtn.Checked = true;
                originLbl.Text = "  Company";
                partOriginTxt.Text = outsourcedPart.CompanyName;
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn);//initial validate -- will make necesary inputs red
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
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn); // Revalidate form if needed
        }

        private void SharedInputChanged(object sender, EventArgs e)
        {
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn);
            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inHouseBtn.Checked)
            {
                Inventory.UpdatePart(selectedPart.PartID, new Inhouse
                {
                    PartID = selectedPart.PartID,
                    Name = nameTxt.Text,
                    InStock = int.Parse(inventoryTxt.Text),
                    Price = decimal.Parse(priceTxt.Text),
                    Min = int.Parse(minTxt.Text),
                    Max = int.Parse(maxTxt.Text),
                    MachineID = int.Parse(partOriginTxt.Text) 
                });
            }
            else
            {
                Inventory.UpdatePart(selectedPart.PartID, new Outsourced
                {
                    PartID = selectedPart.PartID,
                    Name = nameTxt.Text,
                    InStock = int.Parse(inventoryTxt.Text),
                    Price = decimal.Parse(priceTxt.Text),
                    Min = int.Parse(minTxt.Text),
                    Max = int.Parse(maxTxt.Text),
                    CompanyName = partOriginTxt.Text 
                });
            }
            this.Close();
            MessageBox.Show("Part successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
