using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer.Classes
{
    public class Account
    {
        public Account()
        {
            Securities = new List<Security>();
        }

        public string ID { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Custodian { get; set; }

        public double ShortGains { get; set; }

        public double LongGains { get; set; }

        public double Withdrawal { get; set; }

        public double Fee { get; set; }

        public List<Security> Securities { get; set; }

        public bool Taxable
        {
            get
            {
                if (Type.Contains("IRA"))
                {
                    return true;
                }

                return false;
            }
        }

        public double Get_Market_Value()
        {
            // Return the sum of every security's market value
            return Securities.Sum(security => security.Get_Market_Value());
        }

        public static List<Security> Parse_Securities_From_CSV(List<string[]> csvData, Account account)
        {
            // Get the column headers from the csv data
            List<string> headerValues = CSVMethods.Get_Header_Values(csvData);

            // Load the information for positions in an account
            for (int csvRow = 1; csvRow < csvData.Count; csvRow++)
            {
                if (csvData[csvRow].Contains(account.ID))
                {
                    account.Securities.Add(Get_Position_From_CSV_Row(csvData[csvRow], headerValues));
                }
            }

            return account.Securities;
        }

        public static Security Get_Position_From_CSV_Row(string[] csvRow, List<string> headerValues)
        {
            // The account ID matches one of the household's accounts. Add the security to the account
            Security security = new Security();
            security.ID = csvRow[headerValues.IndexOf("AssetId")];
            security.Ticker = csvRow[headerValues.IndexOf("SecSymbol")];
            security.Quantity = double.Parse(csvRow[headerValues.IndexOf("Quantity")]);

            return security;
        }

        // TODO load the trade lots for every security in the account
        //public void Load_Lots()
        //{
        //    // Load the securities for a given account

        //    string lotPath = "Realized_Gains.csv";
        //    StreamReader positionReader = File.OpenText(lotPath);
        //    List<string> headerValues = null;

        //    while (!positionReader.EndOfStream)
        //    {
        //        string positionString = positionReader.ReadLine();

        //        if (headerValues == null)
        //        {
        //            headerValues = Get_Header_Values(positionString);
        //        }
        //        else
        //        {
        //            //foreach (Account account in household.Accounts)
        //            //{
        //            //    if (positionString.Contains(account.ID))
        //            //    {
        //            //        // The line has a security for the account. Split the line
        //            //        string[] positionLine = positionString.Split(',');

        //            //        // Add the security to the account's list of securities
        //            //        Security tempSecurity = new Security();
        //            //        tempSecurity.ID = positionLine[headerValues.IndexOf("AssetId")];
        //            //        tempSecurity.Ticker = positionLine[headerValues.IndexOf("SecSymbol")];
        //            //        tempSecurity.Type = positionLine[headerValues.IndexOf("SecurityType")];
        //            //        tempSecurity.Value = double.Parse(positionLine[headerValues.IndexOf("MarketValue")]);

        //            //    }
        //            //}


        //        }
        //    }
        //}
    }
}
