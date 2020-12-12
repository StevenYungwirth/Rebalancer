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
        private string ticker;
        private string name;
        private string assetClass;
        private string subclass;
        private string type;
        private double currentPrice;
        private double quantity;
        private string id;
        private List<TradeLot> tradeLots;
        private Dictionary<string, Security> securityDict;

        public Security(Dictionary<string, Security> dictionary)
        {
            this.tradeLots = new List<TradeLot>();
            securityDict = dictionary;
        }

        public string Ticker
        {
            get { return this.ticker; }
            set { this.ticker = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string AssetClass
        {
            get { return this.assetClass; }
            set { this.assetClass = value; }
        }

        public string Subclass
        {
            get { return this.subclass; }
            set { this.subclass = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double CurrentPrice
        {
            get { return this.currentPrice; }
            set { this.currentPrice = value; }
        }

        public double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
            //get
            //{
            //    double quantity = 0;
            //    foreach (TradeLot lot in this.tradeLots)
            //    {
            //        quantity += lot.Quantity;
            //    }

            //    return quantity;
            //}
        }

        public double Get_Market_Value()
        {
            return this.quantity * this.currentPrice;
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public List<TradeLot> TradeLots
        {
            get { return this.tradeLots; }
            set { this.tradeLots = value; }
        }
    }
}
