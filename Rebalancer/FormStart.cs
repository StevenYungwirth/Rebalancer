using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebalancer
{
    public partial class FormStart : Form
    {
        public Household SelectedHousehold = new Household();
        private readonly List<Household> households = new List<Household>();
        private const string HouseholdPath = "household.csv";
        private const string SettingsPath = "settings.csv";
        private const string PositionPath = "position.csv";
        private const string SecurityPath = "security.csv";
        public FormHousehold HouseholdForm;

        public FormStart()
        {
            InitializeComponent();

            // TODO Run check to make sure all of the necessary csv files are available and able to be used
            if (!Are_All_Files_Present())
            {
                // At least one file is missing
                
            }

            // TODO Set radio buttons to a default of AUM, Quarterly, and the rotation that corresponds to the current month

            // Load all of the households
            Load_CSV(HouseholdPath, Load_Account_From_CSV_Row);
            Combine_Households();

            // Add the households as options to be selected from the combo box, based on the radio buttons selected
            foreach (Household household in this.households)
            {
                CBHouseholdList.Items.Add(household.Description);
            }
        }

        private bool Are_All_Files_Present()
        {
            if (File.Exists(HouseholdPath) && File.Exists(SettingsPath) && File.Exists(PositionPath) && File.Exists(SecurityPath))
            {
                return true;
            }

            return false;
        }

        private void Load_CSV(string path, Action<string[], List<string>> csvLoader)
        {
            StreamReader file = File.OpenText(path);
            List<string> headerValues = null;
            while (!file.EndOfStream)
            {
                // Get the next row
                string row = file.ReadLine();

                // Add the header line
                if (headerValues == null)
                {
                    headerValues = Get_CSV_Header_Values(row);
                }
                else
                {
                    // Hold the split data from the given row
                    string[] csvRow;

                    if (row.Contains('"'))
                    {
                        // If there's a quotation mark in the row, then there's a name with a comma in it (i.e. "Smith, Bob")
                        // Find the location of the quotation marks in the entire string
                        int firstQuote = row.IndexOf('"');
                        int lastQuote = row.IndexOf('"', firstQuote + 1);

                        // Get the value between the two quotation marks
                        string quotedString = row.Substring(firstQuote + 1, lastQuote - firstQuote - 1);

                        // Count the commas before the quotation mark
                        int commaCount = row.Remove(firstQuote).Split(',').Length - 1;

                        // Remove the comma
                        row = row.Remove(row.IndexOf(',', firstQuote), 1);

                        // Split the row
                        csvRow = row.Split(',');

                        // Put the comma back in where it belongs
                        csvRow[commaCount] = quotedString;
                    }
                    else
                    {
                        // The household doesn't have a quotation in the name. Split the row
                        csvRow = row.Split(',');
                    }

                    csvLoader(csvRow, headerValues);
                }
            }

            file.Close();
        }

        private List<String> Get_CSV_Header_Values(string headerRow)
        {
            // Given the header line of a csv file, get the header names to reference later
            return headerRow.Split(',').ToList();
        }

        private void Load_Account_From_CSV_Row(string[] csvCells, List<string> headerValues)
        {
            // Add the account to the list of households
            Household tempHousehold = new Household
            {
                ID = csvCells[headerValues.IndexOf("HouseholdId")],
                Description = csvCells[headerValues.IndexOf("HouseholdDescription")]
            };
            Account tempAccount = new Account
            {
                ID = csvCells[headerValues.IndexOf("AccountId")],
                Name = csvCells[headerValues.IndexOf("AccountName")],
                Number = csvCells[headerValues.IndexOf("AccountNumber")],
                Custodian = csvCells[headerValues.IndexOf("AccountCustodian")],
                Type = csvCells[headerValues.IndexOf("AccountType")],
                ShortGains = double.Parse(csvCells[headerValues.IndexOf("AccountYTDRealizedSTGL")]),
                LongGains = double.Parse(csvCells[headerValues.IndexOf("AccountYTDRealizedLTGL")])
            };
            tempHousehold.Accounts.Add(tempAccount);
            households.Add(tempHousehold);
        }

        private void Combine_Households()
        {
            // If there are multiple households with the same ID, then their accounts should be combined so there's only one household per ID
            for (int household = this.households.Count - 1; household > 0; household++)
            {
                if (households[household - 1].ID == households[household].ID)
                {
                    // The household has already been added, so this line is another account within it
                    households[household - 1].Accounts.Add(households[household].Accounts[0]);
                    households.RemoveAt(household);
                }
            }
        }

        private void Show_Quarterly(object sender, EventArgs e)
        {
            // Show the corresponding group box depending on which radio button was checked
            if (rdoQuarterly.Checked)
            {
                // Hide the rotation radio buttons that don't correspond to a quarterly rotation
                gbxQuarterly.Visible = true;
                gbxSemiAnnual.Visible = false;
                gbxAnnual.Visible = false;
            }
        }

        private void Show_SemiAnnual(object sender, EventArgs e)
        {
            if (rdoSemiAnnual.Checked)
            {
                // Hide the rotation radio buttons that don't correspond to a quarterly rotation
                gbxQuarterly.Visible = false;
                gbxSemiAnnual.Visible = true;
                gbxAnnual.Visible = false;
            }
        }

        private void Show_Annual(object sender, EventArgs e)
        {
            if (rdoAnnual.Checked || rdoAllFrequency.Checked)
            {
                // Hide the rotation radio buttons that don't correspond to a quarterly rotation
                gbxQuarterly.Visible = false;
                gbxSemiAnnual.Visible = false;
                gbxAnnual.Visible = true;
            }
        }

        private void Show_None(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
            {
                // Hide all of the rotation radio buttons
                gbxQuarterly.Visible = false;
                gbxSemiAnnual.Visible = false;
                gbxAnnual.Visible = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // See if a household is selected
            if (CBHouseholdList.SelectedIndex != -1)
            {
                // Get the selected household
                SelectedHousehold = households[CBHouseholdList.SelectedIndex];

                // Open the form showing the household's data
                HouseholdForm = new FormHousehold(SelectedHousehold);
                HouseholdForm.FormClosed += Household_Form_Closed;
                HouseholdForm.btnSelectNew.Click += Household_Form_Select_New;
                this.Hide();
                HouseholdForm.Show();
            }
        }

        private void Household_Form_Closed(object sender, EventArgs e)
        {
            // When the household form is closed, close this one as well
            this.Close();
        }

        private void Household_Form_Select_New(object sender, EventArgs e)
        {
            // Reopen this form in order to select a new household
            this.Show();
            HouseholdForm.Close();

            // TODO closing the household form here calls the household_form_closed method, closing startform
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        // TODO Filter the client list per the radio buttons
    }
}