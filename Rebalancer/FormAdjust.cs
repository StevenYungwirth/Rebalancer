using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebalancer
{
    public partial class FormAdjust : Form
    {
        public double ReturnFeeRate;
        public double ReturnFeeAmount;
        private readonly Household household;

        public FormAdjust(Household givenHousehold)
        {
            InitializeComponent();

            household = givenHousehold;
            
            // Get the fee rate
            txtRateAnnual.Text = household.FeeRate.ToString("P");
            ReturnFeeRate = household.FeeRate;

            // Set the fee rate per update
            txtRateUpdate.Text = (ReturnFeeRate / household.NumberOfUpdatesPerYear).ToString("P");

            // Get the fee amount
            txtFeeAmount.Text = household.TotalFees.ToString("C");
            ReturnFeeAmount = household.TotalFees;
        }

        private void rdoRate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRateAnnual.Checked)
            {
                // Only enable the annual rate text box
                txtRateAnnual.Enabled = true;
                txtRateUpdate.Enabled = false;
                txtFeeAmount.Enabled = false;

                // Select the annual rate text box
                txtRateAnnual.Select();
            }
        }

        private void rdoRateUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRateUpdate.Checked)
            {
                // Only enable the per update rate text box
                txtRateAnnual.Enabled = false;
                txtRateUpdate.Enabled = true;
                txtFeeAmount.Enabled = false;

                // Select the per update rate text box
                txtRateUpdate.Select();
            }
        }

        private void rdoAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAmount.Checked)
            {
                // Only enable the amount text box
                txtRateAnnual.Enabled = false;
                txtRateUpdate.Enabled = false;
                txtFeeAmount.Enabled = true;

                // Select the fee amount text box
                txtFeeAmount.Select();
            }
        }

        private void txtFeeRate_TextChanged(object sender, EventArgs e)
        {
            // If the fee rate changes, see if it is a double
            if (rdoRateAnnual.Checked && double.TryParse(txtRateAnnual.Text, out double feeRate))
            {
                // The new fee rate can be parsed. Change the fee amount to reflect what it actually is
                txtRateUpdate.Text = (feeRate / 100 / household.NumberOfUpdatesPerYear).ToString("P");
                txtFeeAmount.Text = (feeRate / 100 / household.NumberOfUpdatesPerYear * household.TotalValue).ToString("C");
            }
        }

        private void txtRateUpdate_TextChanged(object sender, EventArgs e)
        {
            // If the fee rate changes, see if it is a double
            if (rdoRateUpdate.Checked && double.TryParse(txtRateUpdate.Text, out double feeRate))
            {
                // The new fee rate can be parsed. Change the fee amount to reflect what it actually is
                txtRateAnnual.Text = (feeRate / 100 * household.NumberOfUpdatesPerYear).ToString("P");
                txtFeeAmount.Text = (feeRate / 100 * household.TotalValue).ToString("C");
            }
        }

        private void txtFeeAmount_TextChanged(object sender, EventArgs e)
        {
            // If the fee amount changes, see if it is a double
            if (rdoAmount.Checked && double.TryParse(txtFeeAmount.Text, out double feeAmount))
            {
                // The new fee amount can be parsed. Change the fee rate to reflect what it actually is
                txtRateAnnual.Text = (feeAmount / household.TotalValue).ToString("P");
                txtRateUpdate.Text = (feeAmount / household.TotalValue / household.NumberOfUpdatesPerYear).ToString("P");
            }
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            // Keep the formatting
            TextBox txtBox = (TextBox) sender;
            if (txtBox.Text.StartsWith("."))
            {
                txtBox.Text = txtBox.Text.Insert(0, "0");
            }
            if (double.TryParse(txtBox.Text, out double feeRate) && !txtBox.Text.EndsWith("%"))
            {
                txtBox.Text += @"%";
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            // Keep the formatting
            if (double.TryParse(txtFeeAmount.Text, out double feeAmount))
            {
                txtFeeAmount.Text = feeAmount.ToString("C");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Return the fee rate
            string stringSansSpecialCharacter = txtRateAnnual.Text.Replace("%", "");
            if (!double.TryParse(stringSansSpecialCharacter, out ReturnFeeRate))
            {
                // The fee rate couldn't be parsed
                MessageBox.Show(@"Invalid entry for the fee rate.");
                return;
            }

            // Return the fee amount
            stringSansSpecialCharacter = txtFeeAmount.Text.Replace("$", "");
            if (!double.TryParse(stringSansSpecialCharacter, out ReturnFeeAmount))
            {
                // The fee amount couldn't be parsed
                MessageBox.Show(@"Invalid entry for the fee amount.");
                return;
            }

            ReturnFeeRate /= 100;

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Don't change the return variables
            this.Close();
        }
    }
}