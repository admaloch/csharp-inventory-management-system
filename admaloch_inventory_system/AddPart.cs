using admaloch_inventory_system.Enums;
using admaloch_inventory_system.Models;
using admaloch_inventory_system.Services;
using admaloch_inventory_system.Utilities;
using System;
using System.Windows.Forms;

namespace admaloch_inventory_system
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            this.Load += AddPart_Load;//run some code on load
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            saveBtn.Enabled = false;//disable save btn unless form validated
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn, saveBtn);

            // Attach shared listener to radio buttons
            inHouseBtn.CheckedChanged += RadioChanged;
            outsourceBtn.CheckedChanged += RadioChanged;

            //add inuts to shared listener for validation
            nameTxt.TextChanged += SharedInputChanged;
            inventoryTxt.TextChanged += SharedInputChanged;
            priceTxt.TextChanged += SharedInputChanged;
            maxTxt.TextChanged += SharedInputChanged;
            minTxt.TextChanged += SharedInputChanged;
            partOriginTxt.TextChanged += SharedInputChanged;

            //set value of id
            idTxt.Text = Utils.CalcNextItemId(ItemType.Part).ToString();
        }

        private void RadioChanged(object sender, EventArgs e)//inhouse vs outsource handler
        {
            if (inHouseBtn.Checked)
            {
                originLbl.Text = "Machine ID";
            }
            else if (outsourceBtn.Checked)
            {
                originLbl.Text = "Company";
            }
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn, saveBtn);
        }


        private void SharedInputChanged(object sender, EventArgs e)//connect inputs into shared listener
        {
            ValidationUtils.ValidatePartForm(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt, partOriginTxt, inHouseBtn, saveBtn);
        }

        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            if (inHouseBtn.Checked)
            {
                Inventory.AddPart(new Inhouse
                {
                    PartID = Utils.CalcNextItemId(ItemType.Part),
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
                Inventory.AddPart(new Outsourced
                {
                    PartID = Utils.CalcNextItemId(ItemType.Part),
                    Name = nameTxt.Text,
                    InStock = int.Parse(inventoryTxt.Text),
                    Price = decimal.Parse(priceTxt.Text),
                    Min = int.Parse(minTxt.Text),
                    Max = int.Parse(maxTxt.Text),
                    CompanyName = partOriginTxt.Text 
                });
            }
            this.Close();
            MessageBox.Show("Part successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
