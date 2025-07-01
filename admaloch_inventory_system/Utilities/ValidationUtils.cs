using admaloch_inventory_system.Models;
using System.Drawing;
using System.Windows.Forms;

namespace admaloch_inventory_system.Utilities
{
    internal class ValidationUtils
    {
        public static bool ValidateProductForm(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt)
        {
            bool sharedValid = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            return sharedValid ? true : false;
        }
        public static bool ValidatePartForm(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt, TextBox partOriginTxt, RadioButton inHouseBtn)
        {
            bool sharedValid = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            bool partSpecificValid = ValidatePartSpecific(partOriginTxt, inHouseBtn);
            return sharedValid && partSpecificValid ? true : false;
        }
        public static void ValidationErrMsg(TextBox inventoryTxt, TextBox minTxt, TextBox maxTxt)
        {
            string msg;
            bool minVal = int.TryParse(minTxt.Text, out int min);
            bool maxVal = int.TryParse(maxTxt.Text, out int max);
            bool inventoryVal = int.TryParse(inventoryTxt.Text, out int inventory);

            if (minVal && maxVal && min > max)
            {
                msg = "Min can't be greater than max";
            }
            else if (minVal && maxVal && inventoryVal && (inventory > max || inventory < min))
            {
                msg = "Inventory is outside of the min/max range";
            }
            else 
            {
                msg = "All inputs must have valid values to submit";
            }
         
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool ValidateSharedInputs(TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt)
        {
            bool allValid = true;

            // Name: non-empty
            allValid &= SetValidationState(!string.IsNullOrWhiteSpace(nameTxt.Text), nameTxt);

            // Price: decimal
            allValid &= SetValidationState(decimal.TryParse(priceTxt.Text, out _), priceTxt);

            // Inventory: integer
            //allValid &= SetValidationState(int.TryParse(inventoryTxt.Text, out int inventory), inventoryTxt);

            // Min and Max: integers and Min <= Max
            bool minValid = int.TryParse(minTxt.Text, out int min);
            bool maxValid = int.TryParse(maxTxt.Text, out int max);
            bool inventoryValid = int.TryParse(inventoryTxt.Text, out int inventory);

            allValid &= SetValidationState(minValid, minTxt);
            allValid &= SetValidationState(maxValid, maxTxt);
            allValid &= SetValidationState(inventoryValid, inventoryTxt);


            if (minValid && maxValid && min > max)
            {
                minTxt.BackColor = Color.LightCoral;
                maxTxt.BackColor = Color.LightCoral;
                allValid = false;
            }

            if (minValid && maxValid && inventoryValid && inventory > max || inventory < min)
            {
                inventoryTxt.BackColor = Color.LightCoral;
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

        private static bool SetValidationState(bool condition, TextBox control)
        {
            control.BackColor = condition ? Color.White : Color.LightCoral;
            return condition;
        }

    }
}
