using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer
{
    public partial class FormHousehold : Form
    {
        public Dictionary<string, Security> SecurityDict = new Dictionary<string, Security>();
        public Household SelectedHousehold = new Household();
        private readonly List<Household> households = new List<Household>();
        private readonly List<string> tickerList = new List<string>();
        private Account selectedAccount = new Account();
        private string selectedSubclass = "";
        private readonly string[] subClasses =
            {
                "Cash & Equivalents", "Fixed Income",
                "US Large Cap Value", "US Large Cap Blend", "US Large Cap Growth",
                "US Mid Cap Value", "US Mid Cap Blend", "US Mid Cap Growth",
                "US Small Cap Value", "US Small Cap Blend", "US Small Cap Growth",
                "International Equities", "Specialty/Sector", "Other"
            };

        public FormHousehold(Household household)
        {
            InitializeComponent();
            this.SelectedHousehold = household;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load in the selected household
            Load_Household();

            // Setup the list views for the accounts and securities to be loaded into
            Initialize_ListViews();
        }

        #region CSV Loaders

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

        private void Load_Positions_From_CSV_Row(string[] positionRow, List<string> headerValues)
        {
            // Load the information for positions in an account
            foreach (Account account in SelectedHousehold.Accounts)
            {
                if (positionRow.Contains(account.ID))
                {
                    // The account ID matches one of the household's accounts. Add the security to the account
                    Security tempSecurity = new Security(SecurityDict);
                    tempSecurity.ID = positionRow[headerValues.IndexOf("AssetId")];
                    tempSecurity.Ticker = positionRow[headerValues.IndexOf("SecSymbol")];
                    tempSecurity.Quantity = double.Parse(positionRow[headerValues.IndexOf("Quantity")]);
                    account.Securities.Add(tempSecurity);
                }
            }
        }

        private void Load_Securities_From_CSV_Row(string[] securityRow, List<string> headerValues)
        {
            // Load the information for specific securities
            foreach (string ticker in tickerList)
            {
                if (securityRow.Contains(ticker))
                {
                    // The account ID matches one of the tickers in the list. Add the security to the dictionary
                    Security tempSecurity = new Security(SecurityDict)
                    {
                        AssetClass = securityRow[headerValues.IndexOf("AssetClass")],
                        Subclass = securityRow[headerValues.IndexOf("SubClass")],
                        Type = securityRow[headerValues.IndexOf("SecurityType")],
                        Name = securityRow[headerValues.IndexOf("ProductName")],
                        CurrentPrice = double.Parse(securityRow[headerValues.IndexOf("NavPrice")])
                    };

                    if (!SecurityDict.ContainsKey(ticker))
                    {
                        SecurityDict.Add(ticker, tempSecurity);
                    }
                }
            }
        }

        private void Load_Settings_From_CSV_Row(string[] settingsRow, List<string> headerValues)
        {
            if (settingsRow.Contains(SelectedHousehold.Description))
            {
                SelectedHousehold.FeeSetting = settingsRow[headerValues.IndexOf("Management Fee Setting")];
                SelectedHousehold.Allocation =
                    new Allocation(settingsRow[headerValues.IndexOf("Target Asset Allocation")]);
            }
        }

        #endregion

        #region Setup Form

        private void Initialize_ListViews()
        {
            // Initialize the security list view
            lvwSecurities.View = View.Details;
            lvwSecurities.Columns.Add("securityName", "Security Name", 210);
            lvwSecurities.Columns.Add("ticker", "Ticker", 60);
            lvwSecurities.Columns.Add("assetClass", "Asset Class", 115);
            lvwSecurities.Columns.Add("value", "Value", 110);

            // Initialize the accounts list view
            lvwAccounts.View = View.List;
            lvwAccounts.Columns.Add("accountName", "Account Name", -2);

            // Initialize the subclass list view
            lvwAssetClasses.View = View.List;
        }

        #endregion

        #region Load Household

        private void Load_Household()
        {
            // Set the household that was selected
            //SelectedHousehold = households[CBHouseholdList.SelectedIndex];

            // Load each accounts' securities
            Load_Household_Securities();

            // Fill the controls
            Fill_Accounts_ListView();
            Fill_Top_Row();
            Fill_Current_Table();
            Fill_Target_Table();
            Fill_Action_Table();

            // Load the household's allocation and fee structure
            const string settingsPath = "settings.csv";
            Load_CSV(settingsPath, Load_Settings_From_CSV_Row);

            // Set the values for the tooltip for equity target, fee rate, and fee amount
            Set_Tooltip(0, SelectedHousehold.Allocation.Equity, SelectedHousehold.FeeRate, SelectedHousehold.TotalFees);

            // Enable the rest of the buttons besides Load Household
            Enable_Buttons();
        }

        private void Load_Household_Securities()
        {
            if (!SelectedHousehold.IsLoaded)
            {
                // The securities have not already been loaded for this household
                const string positionPath = "position.csv";
                Load_CSV(positionPath, Load_Positions_From_CSV_Row);

                // Get a list of every security in the accounts, but only one instance of each
                foreach (Account account in SelectedHousehold.Accounts)
                {
                    foreach (Security security in account.Securities)
                    {
                        if (!tickerList.Contains(security.Ticker))
                        {
                            tickerList.Add(security.Ticker);
                        }
                    }
                }

                const string securityPath = "security.csv";
                Load_CSV(securityPath, Load_Securities_From_CSV_Row);

                SelectedHousehold.IsLoaded = true;
            }
        }

        private void Fill_Accounts_ListView()
        {
            // Add the household's accounts to the list view
            foreach (Account account in SelectedHousehold.Accounts)
            {
                lvwAccounts.Items.Add(new ListViewItem(account.Name));
                foreach (Security security in account.Securities)
                {
                    // Load the missing information from the dictionary to each security
                    security.Name = SecurityDict[security.Ticker].Name;
                    security.AssetClass = SecurityDict[security.Ticker].AssetClass;
                    security.Subclass = SecurityDict[security.Ticker].Subclass;
                    security.CurrentPrice = SecurityDict[security.Ticker].CurrentPrice;
                    security.Type = SecurityDict[security.Ticker].Type;
                }
            }

            lvwAccounts.Items.Add("(show all accounts)");
        }

        private void Fill_Top_Row()
        {
            // Total household value
            lblHouseholdValueLabel.Text = this.SelectedHousehold.TotalValue.ToString("C");

            // Allocation
            // TODO Provide settings file in order to get allocation
            //lblAllocationLabel.Text = SelectedHousehold.Allocation.Name;
            lblAllocationLabel.Text = "FPIS 60%";
            this.SelectedHousehold.Allocation = new Allocation("FPIS 60%");
        }

        private void Fill_Current_Table()
        {
            Dictionary<string, double> assetClassMarketValue = new Dictionary<string, double>();

            foreach (string subClass in subClasses)
            {
                assetClassMarketValue.Add(subClass, 0);
            }

            foreach (Account account in SelectedHousehold.Accounts)
            {
                foreach (Security security in account.Securities)
                {
                    bool isFound = false;
                    foreach (string subClass in subClasses)
                    {
                        if (security.Subclass == subClass)
                        {
                            assetClassMarketValue[security.Subclass] += security.Get_Market_Value();
                            isFound = true;
                        }
                    }

                    if (!isFound)
                    {
                        assetClassMarketValue["Other"] += security.Get_Market_Value();
                    }
                }
            }

            // Enter in each asset class to the labels
            lblCurrentLV.Text = assetClassMarketValue["US Large Cap Value"].ToString("C");
            lblCurrentLB.Text = assetClassMarketValue["US Large Cap Blend"].ToString("C");
            lblCurrentLG.Text = assetClassMarketValue["US Large Cap Growth"].ToString("C");
            lblCurrentMV.Text = assetClassMarketValue["US Mid Cap Value"].ToString("C");
            lblCurrentMB.Text = assetClassMarketValue["US Mid Cap Blend"].ToString("C");
            lblCurrentMG.Text = assetClassMarketValue["US Mid Cap Growth"].ToString("C");
            lblCurrentSV.Text = assetClassMarketValue["US Small Cap Value"].ToString("C");
            lblCurrentSB.Text = assetClassMarketValue["US Small Cap Blend"].ToString("C");
            lblCurrentSG.Text = assetClassMarketValue["US Small Cap Growth"].ToString("C");
            lblCurrentIntl.Text = assetClassMarketValue["International Equities"].ToString("C");
            lblCurrentSpecialty.Text = assetClassMarketValue["Specialty/Sector"].ToString("C");
            lblCurrentSectorOther.Text = assetClassMarketValue["Other"].ToString("C");

            double totalEquity = assetClassMarketValue["US Large Cap Value"] +
                                 assetClassMarketValue["US Large Cap Blend"] +
                                 assetClassMarketValue["US Large Cap Growth"] +
                                 assetClassMarketValue["US Mid Cap Value"] +
                                 assetClassMarketValue["US Mid Cap Blend"] +
                                 assetClassMarketValue["US Mid Cap Growth"] +
                                 assetClassMarketValue["US Small Cap Value"] +
                                 assetClassMarketValue["US Small Cap Blend"] +
                                 assetClassMarketValue["US Small Cap Growth"] +
                                 assetClassMarketValue["International Equities"] +
                                 assetClassMarketValue["Specialty/Sector"];
            lblCurrentEquity.Text = totalEquity.ToString("C");
            lblCurrentFixed.Text = assetClassMarketValue["Fixed Income"].ToString("C");
            lblCurrentCash.Text = assetClassMarketValue["Cash & Equivalents"].ToString("C");
            lblCurrentTotalOther.Text = assetClassMarketValue["Other"].ToString("C");
        }

        private void Fill_Target_Table()
        {
            Fill_Target_Asset_Classes();
            Fill_Target_SubClasses();
        }

        private void Fill_Target_Asset_Classes()
        {
            double targetOther = Get_Target_Amount(this.SelectedHousehold.Allocation.Other);
            double targetCash = this.SelectedHousehold.TotalFees + this.SelectedHousehold.TotalWithdrawals;
            double targetFixed = Get_Target_Amount(1 - this.SelectedHousehold.Allocation.Equity) - targetCash;
            double targetEquity = Get_Target_Amount(this.SelectedHousehold.Allocation.Equity);

            lblTargetEquity.Text = targetEquity.ToString("C");
            lblTargetFixed.Text = targetFixed.ToString("C");
            lblTargetTotalOther.Text = targetOther.ToString("C");
            lblTargetCash.Text = targetCash.ToString(("C"));
        }

        private void Fill_Target_SubClasses()
        {
            // When the spinners' values change, the associated label will automatically be changed
            nudLV.Value = (decimal)this.SelectedHousehold.Allocation.LargeValue * 100;
            nudLB.Value = (decimal)this.SelectedHousehold.Allocation.LargeBlend * 100;
            nudLG.Value = (decimal)this.SelectedHousehold.Allocation.LargeGrowth * 100;
            nudMV.Value = (decimal)this.SelectedHousehold.Allocation.MidValue * 100;
            nudMB.Value = (decimal)this.SelectedHousehold.Allocation.MidBlend * 100;
            nudMG.Value = (decimal)this.SelectedHousehold.Allocation.MidGrowth * 100;
            nudSV.Value = (decimal)this.SelectedHousehold.Allocation.SmallValue * 100;
            nudSB.Value = (decimal)this.SelectedHousehold.Allocation.SmallBlend * 100;
            nudSG.Value = (decimal)this.SelectedHousehold.Allocation.SmallGrowth * 100;
            nudIntl.Value = (decimal)this.SelectedHousehold.Allocation.International * 100;
            nudSpecialty.Value = (decimal)this.SelectedHousehold.Allocation.Specialty * 100;
            nudSectorOther.Value = (decimal)this.SelectedHousehold.Allocation.Other * 100;
        }

        private double Get_Target_Amount(double equityPercent)
        {
            // Given the percentage of total equities a sector is, return how much it should have at target
            return this.SelectedHousehold.TotalValue * equityPercent;
        }

        private void Fill_Action_Table()
        {
            // Get the target minus current for each asset class
            lblActionEquity.Text = Compare_Dollar_Labels(lblTargetEquity.Text, lblCurrentEquity.Text);
            lblActionFixed.Text = Compare_Dollar_Labels(lblTargetFixed.Text, lblCurrentFixed.Text);
            lblActionCash.Text = Compare_Dollar_Labels(lblTargetCash.Text, lblCurrentCash.Text);
            lblActionTotalOther.Text = Compare_Dollar_Labels(lblTargetTotalOther.Text, lblCurrentTotalOther.Text);

            // Update the text colors
            lblActionEquity.ForeColor = Label_Dollars_To_Double(lblActionEquity.Text) >= 0 ? Color.Black : Color.Red;
            lblActionFixed.ForeColor = Label_Dollars_To_Double(lblActionFixed.Text) >= 0 ? Color.Black : Color.Red;
            lblActionCash.ForeColor = Label_Dollars_To_Double(lblActionCash.Text) >= 0 ? Color.Black : Color.Red;
            lblActionTotalOther.ForeColor = Label_Dollars_To_Double(lblActionTotalOther.Text) >= 0 ? Color.Black : Color.Red;
        }

        private string Compare_Dollar_Labels(string targetLabel, string currentLabel)
        {
            // Convert the given strings to doubles
            double targetEquity = Label_Dollars_To_Double(targetLabel);
            double currentEquity = Label_Dollars_To_Double(currentLabel);

            if (targetEquity == -1 || currentEquity == -1)
            {
                // At least one of the labels couldn't be converted to a double
                return "error";
            }

            return (targetEquity - currentEquity).ToString("C");
        }

        private double Label_Dollars_To_Double(string labelText)
        {
            // Convert a string with a dollar amount into a double
            // Remove the dollar sign
            labelText = labelText.Remove(0, 1);

            // Try returning the value
            if (double.TryParse(labelText, out double result))
            {
                return result;
            }

            // The label couldn't be converted to a double
            return -1;
        }

        private void Set_Tooltip(double moneyInOut, double equityTarget, double feeRate, double feeAmount)
        {
            ttpDefaults.SetToolTip(btnAdjustFee, $"Equity Target:\t {equityTarget:P0}\n" +
                                                      $"Fee (Rate):\t {feeRate:P}\n" +
                                                      $"Fee (Amount):\t {feeAmount:C2}\n" +
                                                      $"Money In/Out:\t {moneyInOut:C2}");
        }

        private void Enable_Buttons()
        {
            btnAdjustFee.Enabled = true;
            btnResetDefaults.Enabled = true;
        }

        #endregion

        #region Spinner Value Changed

        private void Spinner_Change(object sender, EventArgs e)
        {
            // When a spinner's value is changed, update the text shown
            // Get the spinner that changed
            NumericUpDown changedSpinner = (NumericUpDown)sender;

            // Update the number of decimal places needed
            Update_Decimal_Places(changedSpinner);

            // Update the related target label
            Update_Target_Label(changedSpinner);

            // Update the related action label
            Update_Action_Label(changedSpinner);

            // Update the sum of every sector
            Update_Sector_Sum();
        }

        private void Update_Decimal_Places(NumericUpDown spinner)
        {
            if ((spinner.Value * 10) % 10 == 0)
            {
                spinner.DecimalPlaces = 0;
            }
            else if ((spinner.Value * 100) % 10 == 0)
            {
                spinner.DecimalPlaces = 1;
            }
            else if ((spinner.Value * 1000) % 10 == 0)
            {
                spinner.DecimalPlaces = 2;
            }
            else
            {
                // Truncate everything past two decimal spots
                spinner.Value = Math.Truncate(spinner.Value * 100) / 100;
            }
        }

        private void Update_Target_Label(NumericUpDown spinner)
        {
            // Get the label associated with the given spinner
            string targetLabelName = $"lblTarget{spinner.Name.Substring(3)}";
            Label targetLabel = (Label)gbxSectorTarget.Controls.Find(targetLabelName, true)[0];

            // Change the label's text value
            targetLabel.Text = Get_Target_Amount((double)spinner.Value / 100).ToString("C");
        }

        private void Update_Action_Label(NumericUpDown spinner)
        {
            // Get the labels associated with the given spinner
            string currentLabelName = $"lblCurrent{spinner.Name.Substring(3)}";
            Label currentLabel = (Label)gbxSectorCurrent.Controls.Find(currentLabelName, true)[0];
            string targetLabelName = $"lblTarget{spinner.Name.Substring(3)}";
            Label targetLabel = (Label)gbxSectorTarget.Controls.Find(targetLabelName, true)[0];
            string actionLabelName = $"lblAction{spinner.Name.Substring(3)}";
            Label actionLabel = (Label)gbxSectorAction.Controls.Find(actionLabelName, true)[0];

            // Change the action label's text value
            actionLabel.Text = Compare_Dollar_Labels(targetLabel.Text, currentLabel.Text);
            actionLabel.ForeColor = Label_Dollars_To_Double(actionLabel.Text) >= 0 ? Color.Black : Color.Red;
        }

        private void Update_Sector_Sum()
        {
            decimal sectorTotal = nudLV.Value + nudLB.Value + nudLG.Value + nudMV.Value + nudMB.Value + nudMG.Value
                                  + nudSV.Value + nudSB.Value + nudSG.Value + nudIntl.Value + nudSpecialty.Value +
                                  nudSectorOther.Value;
            lblSectorTotal.Text = sectorTotal + @"%";

            lblSectorTotal.ForeColor = sectorTotal == 100 ? Color.Black : Color.Red;
        }

        #endregion

        #region Show Account in List View

        private void lvwAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwAccounts.SelectedItems.Count > 0)
            {
                // An account was selected in the list view. Show its subclasses and securities
                Show_Account_In_LVW();
            }
        }

        private void Show_Account_In_LVW()
        {
            Account householdAccount = Get_Selected_Account();
            if (householdAccount == null || householdAccount.Name == selectedAccount.Name)
            {
                // The account couldn't be found in the household, or the same account was selected
                return;
            }

            // A different account was selected than the last one.
            selectedAccount = householdAccount;

            // Clear the securities already in the list view
            lvwSecurities.Items.Clear();
            lvwAssetClasses.Items.Clear();

            // Show all of the securities and subclasses for the selected account
            Add_Securities_To_LVW(selectedAccount);
            Add_Subclasses_To_LVW(selectedAccount);

            // Resize the columns in the list views
            Resize_Columns();
        }

        private Account Get_Selected_Account()
        {
            // Find the account selected in the list view
            ListView.SelectedListViewItemCollection accounts = this.lvwAccounts.SelectedItems;
            foreach (ListViewItem lvwAccount in accounts)
            {
                // See if the "show all accounts" option was selected
                const string showAll = "(show all accounts)";
                if (lvwAccount.Text == showAll)
                {
                    // Return a temporary account with every security from every account
                    Account tempAccount = new Account();
                    SelectedHousehold.Accounts.ForEach(account => account.Securities.ForEach(tempAccount.Securities.Add));
                    tempAccount.Name = "All";
                    return tempAccount;
                }

                // Find and return the account that was selected
                foreach (Account account in SelectedHousehold.Accounts)
                {
                    if (lvwAccount.Text == account.Name)
                    {
                        return account;
                    }
                }
            }

            return null;
        }

        private void Add_Subclasses_To_LVW(Account account)
        {
            foreach (string subclass in this.subClasses)
            {
                // See if the list view contains the given subclass
                if (!lvwAssetClasses.Items.Contains(new ListViewItem(new[] { subclass })))
                {
                    // The list view doesn't contain the subclass already
                    // Add this subclass to the list view if the account contains a security with a matching subclass
                    bool isAdded = false;
                    int securityCount = 0;
                    while (!isAdded && securityCount < account.Securities.Count)
                    {
                        if (account.Securities[securityCount].Subclass == subclass)
                        {
                            // The subclass is in the account. Add it to the list view
                            lvwAssetClasses.Items.Add(subclass);
                            isAdded = true;
                        }

                        securityCount++;
                    }
                }
            }

            // Add the show all option if not already there
            string showAll = "(show all subclasses)";
            if (!lvwAssetClasses.Items.Contains(new ListViewItem(new[] { showAll })))
            {
                lvwAssetClasses.Items.Add(showAll);
            }
        }

        private void Add_Securities_To_LVW(Account account)
        {
            // For the given account, add its securities to the list view, alphabetically by subclass first, and then by security name
            // Create a list for securities to be added alphabetically to, and add the first security
            List<Security> sortedList = new List<Security> {account.Securities[0]};

            // Loop through and add every other security in the account
            for (int accountSecurity = 1; accountSecurity < account.Securities.Count; accountSecurity++)
            {
                Security security = account.Securities[accountSecurity];
                bool isInserted = false;
                int index = 0;
                while (!isInserted && index < sortedList.Count)
                {
                    // Get the strings that will be compared
                    string securitySubclass = security.Subclass.ToUpper();
                    string listSubclass = sortedList[index].Subclass.ToUpper();
                    string securityName = security.Name.ToUpper();
                    string listSecurityName = sortedList[index].Name.ToUpper();

                    // For the securities already on the list, compare the subclass to the given security
                    if (string.Compare(securitySubclass, listSubclass, StringComparison.Ordinal) < 0)
                    {
                        // If the security's subclass comes alphabetically before the list item's subclass,
                        // then the security's subclass isn't present in the list view. Add the security
                        sortedList.Insert(index, security);
                        isInserted = true;
                    }
                    else if (string.Compare(securitySubclass, listSubclass, StringComparison.Ordinal) == 0
                             && string.Compare(securityName, listSecurityName, StringComparison.Ordinal) < 0)
                    {
                        // The security's subclass is on the list view,
                        // and its name comes alphabetically before the security already there. Add the security
                        sortedList.Insert(index, security);
                        isInserted = true;
                    }
                    else
                    {
                        // Either the security's subclass comes last alphabetically for all the securities in the list view,
                        // or the security has a matching subclass as one in the list view, but comes later alphabetically
                    }

                    index++;
                }

                // If the security hasn't been added, then its subclass comes last alphabetically. Add it to the list
                if (!isInserted)
                {
                    sortedList.Add(security);
                }
            }

            // Once there's a list with all the securities in order, add each one to the list view
            foreach (Security security in sortedList)
            {
                ListViewItem sec = new ListViewItem(new[]
                {
                    security.Name,
                    security.Ticker,
                    security.Subclass,
                    security.Get_Market_Value().ToString("C")
                });
                lvwSecurities.Items.Add(sec);
            }
        }

        private void Resize_Columns()
        {
            lvwSecurities.Columns["securityName"].Width = -2;
            lvwSecurities.Columns["ticker"].Width = -2;
            lvwSecurities.Columns["assetClass"].Width = -2;
            lvwSecurities.Columns["value"].TextAlign = HorizontalAlignment.Right;
            lvwSecurities.Columns["value"].Width = -2;
        }

        #endregion

        #region Show Subclass in List View

        private void lvwAssetClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwAssetClasses.SelectedItems.Count > 0)
            {
                // A subclass was selected. Show only its securities
                Show_Selected_Subclass();
            }
        }

        private void Show_Selected_Subclass()
        {
            // Get the subclass that was selected on the list view
            string subclass = Get_Selected_Subclass();

            if (subclass == string.Empty || subclass == selectedSubclass)
            {
                // The same subclass was selected, or there was an error getting the subclass. Do nothing
                return;
            }
            
            // Clear the securities already in the list view
            lvwSecurities.Items.Clear();

            // Add securities of the selected asset class to a temporary account
            Account tempAccount = new Account();

            foreach (Security security in selectedAccount.Securities)
            {
                if (subclass == "All")
                {
                    // Show every asset class for the selected account
                    tempAccount.Securities.Add(security);
                    selectedSubclass = "";
                }
                else if (subclass == security.Subclass)
                {
                    // This security's subclass matches the selected subclass
                    tempAccount.Securities.Add(security);
                    selectedSubclass = subclass;
                }
                else
                {
                    // This security's subclass doesn't match the selected subclass. Go to the next one
                }
            }

            // Add everything in the temporary account to the list view
            Add_Securities_To_LVW(tempAccount);
        }

        private string Get_Selected_Subclass()
        {
            ListView.SelectedListViewItemCollection lvwSelectedSubclasses = this.lvwAssetClasses.SelectedItems;
            foreach (ListViewItem subclass in lvwSelectedSubclasses)
            {
                // Return the first subclass selected, since multiple items can't be selected in the list view
                const string showAll = "(show all subclasses)";
                return subclass.Text == showAll ? "All" : subclass.Text;
            }

            return string.Empty;
        }

        #endregion

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            // Reset labels and spinners back to the default values
            Fill_Target_Table();
            Fill_Action_Table();
        }

        private void btnAdjustFee_Click(object sender, EventArgs e)
        {
            //TODO Delete this line when the actual number of updates per year is brought in
            SelectedHousehold.NumberOfUpdatesPerYear = 4;

            // Call another form where the fee rate or amount can be changed
            FormAdjust frmAdjust = new FormAdjust(SelectedHousehold);
            frmAdjust.ShowDialog();

            if (frmAdjust.DialogResult == DialogResult.OK)
            {
                // Get the new values from the form
                lblFeeRateLabel.Text = frmAdjust.ReturnFeeRate.ToString("P");
                lblFeeAmountLabel.Text = frmAdjust.ReturnFeeAmount.ToString("C");

                // Close the form
                frmAdjust.Close();
            }
            
            // TODO Do something with the new values
        }

        private void lvwSecurities_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // TODO Sort the list view by the column clicked
        }

        private void btnRecs_Click(object sender, EventArgs e)
        {

        }

        // TODO Get funds' returns
        // TODO Load clients' allocations
        // TODO New form for adjusting defaults
        // TODO Add a way to import new data
        // TODO Determine the sales to be made
        // TODO Add popup when clicking on a fund showing its information
        // TODO Indicate which fund is the better choice to buy/sell when looking at subclass
        // TODO Add radio buttons or another list view to toggle between asset classes/subclasses
        // TODO Add the percent sign to the spinners
        // TODO? Put clients/securities into database?
        // TODO Generate csv files for importing trades and for generating report/letter
        // TODO Clean up all of the class properties
        // TODO Fix FormAdjust's fee rate/fee amount change methods to fit the format of the inputted fee rate
        // TODO Take tooltip off adjust fee button
    }
}