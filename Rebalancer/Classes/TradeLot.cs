using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalancer.Classes
{
    public class TradeLot
    {
        private DateTime acquired;
        private double quantity;
        private double price;

        public DateTime Acquired
        {
            get { return this.acquired; }
            set { this.acquired = value; }
        }

        public double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
