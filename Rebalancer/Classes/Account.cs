using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer
{
    public class Account
    {
        private string id;
        private string number;
        private string name;
        private string type;
        private string custodian;
        private double shortGains;
        private double longGains;
        private double withdrawal;
        private double fee;
        private List<Security> securities;

        public Account()
        {
            securities = new List<Security>();
        }

        public void Load_Lots()
        {
            // Load the securities for a given account

            string lotPath = "Realized_Gains.csv";
            StreamReader positionReader = File.OpenText(lotPath);
            List<string> headerValues = null;

            while (!positionReader.EndOfStream)
            {
                string positionString = positionReader.ReadLine();

                if (headerValues == null)
                {
                    headerValues = Get_Header_Values(positionString);
                }
                else
                {
                    //foreach (Account account in household.Accounts)
                    //{
                    //    if (positionString.Contains(account.ID))
                    //    {
                    //        // The line has a security for the account. Split the line
                    //        string[] positionLine = positionString.Split(',');

                    //        // Add the security to the account's list of securities
                    //        Security tempSecurity = new Security();
                    //        tempSecurity.ID = positionLine[headerValues.IndexOf("AssetId")];
                    //        tempSecurity.Ticker = positionLine[headerValues.IndexOf("SecSymbol")];
                    //        tempSecurity.Type = positionLine[headerValues.IndexOf("SecurityType")];
                    //        tempSecurity.Value = double.Parse(positionLine[headerValues.IndexOf("MarketValue")]);

                    //    }
                    //}


                }
            }
        }

        private List<String> Get_Header_Values(string headerRow)
        {
            // This is the header line; add the values to reference later
            List<string> headerValues = new List<string>();

            // Split the row
            string[] csvCells = headerRow.Split(',');

            foreach (string cell in csvCells)
            {
                headerValues.Add(cell);
            }

            return headerValues;
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Custodian
        {
            get { return this.custodian; }
            set { this.custodian = value; }
        }

        public double ShortGains
        {
            get { return this.shortGains; }
            set { this.shortGains = value; }
        }

        public double LongGains
        {
            get { return this.longGains; }
            set { this.longGains = value; }
        }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }

        public double Fee
        {
            get { return this.fee; }
            set { this.fee = value; }
        }

        public List<Security> Securities
        {
            get { return this.securities; }
            set { this.securities = value; }
        }

        public bool Taxable
        {
            get
            {
                if (this.type.Contains("IRA"))
                {
                    return true;
                }

                return false;
            }
        }

        public double Get_Market_Value()
        {
            double value = 0;
            foreach (Security security in this.securities)
            {
                value += security.Get_Market_Value();
            }

            return value;
        }
    }
}
