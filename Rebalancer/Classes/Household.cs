using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer.Classes
{
    public class Household
    {
        private double totalValue;
        private double totalFees;
        private double totalWithdrawals;
        private int numberOfUpdatesPerYear;
        public static List<string[]> positionCSVData;

        public Household()
        {
            this.Accounts = new List<Account>();
            IsLoaded = false;
        }

        public string ID { get; set; }

        public List<Account> Accounts { get; set; }

        public Allocation Allocation { get; set; }

        public string Description { get; set; }

        public bool IsLoaded { get; set; }

        public double TotalValue
        {
            get { return this.Accounts.Sum(account => account.Get_Market_Value()); }
        }

        public string FeeSetting { get; set; }

        public double TotalFees
        {
            get { return this.Accounts.Sum(account => account.Fee); }
        }

        public double TotalWithdrawals
        {
            get { return this.Accounts.Sum(account => account.Withdrawal); }
        }

        public double FeeRate { get; set; }

        public int NumberOfUpdatesPerYear
        {
            get
            {
                if (this.UpdateFrequency == "Quarterly")
                {
                    return 4;
                }
                if (this.UpdateFrequency == "Semi-Annual")
                {
                    return 2;
                }
                if (this.UpdateFrequency == "Annual")
                {
                    return 1;
                }
                return 0;
            }
        }

        public string ClientType { get; set; }

        public string UpdateFrequency { get; set; }

        public string Rotation { get; set; }

        public static List<Household> Load_List_From_CSV(string path)
        {
            // Get the data from the csv file
            List<string[]> csvData = CSVMethods.Get_CSV_Data(path);

            // Get the household list from the csv data
            List<Household> householdList = Parse_Households_From_CSV_Data(csvData);

            // Combine households with the same ID
            Combine_Households(householdList);

            // Return the household list
            return householdList;
        }

        private static List<Household> Parse_Households_From_CSV_Data(List<string[]> csvData)
        {
            // Get the column headers from the csv data
            List<string> headerValues = CSVMethods.Get_Header_Values(csvData);

            // Instantiate the household list to return
            List<Household> householdList = new List<Household>();

            // Parse the account data from each row, starting from index 1, since 0 is the header line
            for (int csvRow = 1; csvRow < csvData.Count; csvRow++)
            {
                householdList.Add(Get_Account_From_Row(csvData[csvRow], headerValues));
            }

            // Return the list
            return householdList;
        }

        private static Household Get_Account_From_Row(string[] csvRow, List<string> headerValues)
        {
            // Instantiate the household to return
            Household household = new Household
            {
                ID = csvRow[headerValues.IndexOf("HouseholdId")],
                Description = csvRow[headerValues.IndexOf("HouseholdDescription")]
            };
            Account tempAccount = new Account
            {
                ID = csvRow[headerValues.IndexOf("AccountId")],
                Name = csvRow[headerValues.IndexOf("AccountName")],
                Number = csvRow[headerValues.IndexOf("AccountNumber")],
                Custodian = csvRow[headerValues.IndexOf("AccountCustodian")],
                Type = csvRow[headerValues.IndexOf("AccountType")],
                ShortGains = double.Parse(csvRow[headerValues.IndexOf("AccountYTDRealizedSTGL")]),
                LongGains = double.Parse(csvRow[headerValues.IndexOf("AccountYTDRealizedLTGL")])
            };
            household.Accounts.Add(tempAccount);

            return household;
        }

        private static void Combine_Households(List<Household> householdList)
        {
            // If there are multiple households with the same ID, then their accounts should be combined so there's only one household per ID
            for (int household = householdList.Count - 1; household > 0; household--)
            {
                if (householdList[household - 1].ID == householdList[household].ID)
                {
                    // The household has already been added, so this line is another account within it
                    householdList[household - 1].Accounts.Add(householdList[household].Accounts[0]);
                    householdList.RemoveAt(household);
                }
            }
        }

        public void Load_Securities()
        {
            if (IsLoaded)
            {
                // The household's securities are already loaded, don't do anything
                return;
            }

            // The securities have not already been loaded for this household
            const string positionPath = FormStart.PositionPath;
            positionCSVData = CSVMethods.Get_CSV_Data(positionPath);

            // Get a list of every security in the accounts, but only one instance of each
            foreach (Account account in Accounts)
            {
                // Get the account's securities from the CSV data
                Account.Parse_Securities_From_CSV(positionCSVData, account);

                foreach (Security security in account.Securities)
                {
                    // See if the security is on the master list already
                    if (!FormHousehold.MasterTickerList.Contains(security.Ticker))
                    {
                        // The security's not on the master list, add it
                        FormHousehold.MasterTickerList.Add(security.Ticker);
                    }
                }
            }

            // The household's securities have been loaded
            IsLoaded = true;
        }
    }
}