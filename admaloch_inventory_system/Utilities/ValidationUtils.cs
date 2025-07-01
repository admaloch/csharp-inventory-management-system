using admaloch_inventory_system.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace admaloch_inventory_system.Utilities
{
    internal class ValidationUtils
    {
        public static (bool isValid, string errorMessage) ValidateProductForm(
            TextBox nameTxt,
            TextBox inventoryTxt,
            TextBox priceTxt,
            TextBox minTxt,
            TextBox maxTxt)
        {
            var (sharedValid, sharedMsg) = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            return (sharedValid, sharedMsg);
        }

        public static (bool isValid, string errorMessage) ValidatePartForm(
            TextBox nameTxt,
            TextBox inventoryTxt,
            TextBox priceTxt,
            TextBox minTxt,
            TextBox maxTxt,
            TextBox partOriginTxt,
            RadioButton inHouseBtn)
        {
            var (sharedValid, sharedMsg) = ValidateSharedInputs(nameTxt, inventoryTxt, priceTxt, minTxt, maxTxt);
            var (partValid, partMsg) = ValidatePartSpecific(partOriginTxt, inHouseBtn);

            bool allValid = sharedValid && partValid;
            string combinedMessage = string.Join("\n", new[] { sharedMsg, partMsg }.Where(msg => !string.IsNullOrWhiteSpace(msg)));

            return (allValid, combinedMessage);
        }

        public static (bool isValid, string errorMessage) ValidateSharedInputs(
            TextBox nameTxt, TextBox inventoryTxt, TextBox priceTxt, TextBox minTxt, TextBox maxTxt)
        {
            bool allValid = true;
            var errors = new List<string>();

            // Name
            if (!SetValidationState(!string.IsNullOrWhiteSpace(nameTxt.Text), nameTxt))
            {
                errors.Add("Name is required.");
                allValid = false;
            }

            // Price
            if (!SetValidationState(decimal.TryParse(priceTxt.Text, out _), priceTxt))
            {
                errors.Add("Price must be a valid number.");
                allValid = false;
            }

            // Min, Max, Inventory
            bool minValid = int.TryParse(minTxt.Text, out int min);
            bool maxValid = int.TryParse(maxTxt.Text, out int max);
            bool inventoryValid = int.TryParse(inventoryTxt.Text, out int inventory);

            if (!SetValidationState(minValid, minTxt))
            {
                errors.Add("Min must be a valid number.");
                allValid = false;
            }

            if (!SetValidationState(maxValid, maxTxt))
            {
                errors.Add("Max must be a valid number.");
                allValid = false;
            }

            if (!SetValidationState(inventoryValid, inventoryTxt))
            {
                errors.Add("Inventory must be a valid number.");
                allValid = false;
            }

            // Logical validation
            if (minValid && maxValid && min > max)
            {
                minTxt.BackColor = maxTxt.BackColor = Color.LightCoral;
                errors.Add("Min cannot be greater than Max.");
                allValid = false;
            }

            if (minValid && maxValid && inventoryValid && (inventory < min || inventory > max))
            {
                inventoryTxt.BackColor = Color.LightCoral;
                errors.Add("Inventory must be between Min and Max.");
                allValid = false;
            }

            return (allValid, string.Join("\n", errors));
        }

        public static (bool isValid, string errorMessage) ValidatePartSpecific(TextBox partOriginTxt, RadioButton inHouseBtn)
        {
            bool isValid;
            string errorMessage = string.Empty;
            string input = partOriginTxt.Text.Trim();

            if (inHouseBtn.Checked)
            {
                isValid = int.TryParse(input, out _);
                if (!isValid)
                {
                    errorMessage = "Machine ID must be a valid number.";
                }
            }
            else
            {
                isValid = !string.IsNullOrWhiteSpace(input) && !int.TryParse(input, out _);
                if (!isValid)
                {
                    errorMessage = "Company Name can't be a number.";
                }
            }

            SetValidationState(isValid, partOriginTxt);
            return (isValid, errorMessage);
        }



        private static bool SetValidationState(bool condition, TextBox control)
        {
            control.BackColor = condition ? Color.White : Color.LightCoral;
            return condition;
        }

    }
}
