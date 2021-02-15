using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalancer.Classes
{
    public class Security
    {
        public Security()
        {
            TradeLots = new List<TradeLot>();
        }

        public string Ticker { get; set; }

        public string Name { get; set; }

        public string AssetClass { get; set; }

        public string Subclass { get; set; }

        public string Type { get; set; }

        public double CurrentPrice { get; set; }

        public double Quantity { get; set; }

        public string ID { get; set; }

        public List<TradeLot> TradeLots { get; set; }

        // TODO once trade lots are imported for each account
        //get
        //{
        //    double quantity = 0;
        //    foreach (TradeLot lot in this.tradeLots)
        //    {
        //        quantity += lot.Quantity;
        //    }

        //    return quantity;
        //}

        public double Get_Market_Value()
        {
            return Quantity * CurrentPrice;
        }

        private Dictionary<string, Security> Load_SecurityDict(string[] securityRow, List<string> headerValues)
        {
            //// Load the information for specific securities
            //foreach (string ticker in MasterTickerList)
            //{
            //    if (securityRow.Contains(ticker))
            //    {
            //        // The account ID matches one of the tickers in the list. Add the security to the dictionary
            //        Security tempSecurity = new Security()
            //        {
            //            AssetClass = securityRow[headerValues.IndexOf("AssetClass")],
            //            Subclass = securityRow[headerValues.IndexOf("SubClass")],
            //            Type = securityRow[headerValues.IndexOf("SecurityType")],
            //            Name = securityRow[headerValues.IndexOf("ProductName")],
            //            CurrentPrice = double.Parse(securityRow[headerValues.IndexOf("NavPrice")])
            //        };

            //        if (!SecurityDict.ContainsKey(ticker))
            //        {
            //            SecurityDict.Add(ticker, tempSecurity);
            //        }
            //    }
            //}

            return null;
        }
    }
}
