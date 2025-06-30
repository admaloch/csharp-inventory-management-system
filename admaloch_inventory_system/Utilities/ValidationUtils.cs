using admaloch_inventory_system.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    internal class ValidationUtils
    {
        public static void ValidateProductForm(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt, Button saveBtn, Product product)
        {
            bool sharedValid = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            bool hasAssociatedParts = product.AssociatedParts.Count > 0;
            saveBtn.Enabled = sharedValid && hasAssociatedParts;
        }
        public static void ValidatePartForm(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt, TextBox partOriginTxt, RadioButton inHouseBtn, Button saveBtn)
        {
            bool sharedValid = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            bool partSpecificValid = ValidatePartSpecific(partOriginTxt, inHouseBtn);
            saveBtn.Enabled = sharedValid && partSpecificValid;
        }
        public static bool ValidateSharedInputs(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt)
        {
            bool allValid = true;

            // Name: non-empty
            allValid &= SetValidationState(!string.IsNullOrWhiteSpace(nameTxt.Text), nameTxt);

            // Inventory: integer
            allValid &= SetValidationState(int.TryParse(inventoryTxt.Text, out _), inventoryTxt);

            // Price: decimal
            allValid &= SetValidationState(decimal.TryParse(priceTxt.Text, out _), priceTxt);

            // Min and Max: integers and Min <= Max
            bool minValid = int.TryParse(minTxt.Text, out int min);
            bool maxValid = int.TryParse(maxTxt.Text, out int max);

            allValid &= SetValidationState(minValid, minTxt);
            allValid &= SetValidationState(maxValid, maxTxt);

            if (minValid && maxValid && min > max)
            {
                minTxt.BackColor = Color.LightCoral;
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }

            return allValid;
        }

        public static bool ValidatePartSpecific(TextBox partOriginTxt, RadioButton inHouseBtn)
        {
            bool valid;
            if (inHouseBtn.Checked)
            {
                valid = int.TryParse(partOriginTxt.Text.Trim(), out _);
            }
            else
            {
                string text = partOriginTxt.Text.Trim();
                valid = !string.IsNullOrWhiteSpace(text) && !int.TryParse(text, out _);
            }

            SetValidationState(valid, partOriginTxt);
            return valid;
        }

        public static bool ValidateProductSpecific(BindingSource associatedPartsSource)
        {
            return associatedPartsSource.Count > 0;
        }

        private static bool SetValidationState(bool condition, TextBox control)
        {
            control.BackColor = condition ? Color.White : Color.LightCoral;
            return condition;
        }

    }
}
