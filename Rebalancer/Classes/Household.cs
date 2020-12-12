using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer
{
    public class Household
    {
        private string id;
        private string description;
        private List<Account> accounts;
        private Allocation allocation;
        private bool isLoaded;
        private double totalValue;
        private string feeSetting;
        private double feeRate;
        private double totalFees;
        private double totalWithdrawals;
        private int numberOfUpdatesPerYear;

        public Household()
        {
            this.accounts = new List<Account>();
            isLoaded = false;
        }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        
        public List<Account> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public Allocation Allocation
        {
            get { return this.allocation; }
            set { this.allocation = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public bool IsLoaded
        {
            get { return this.isLoaded; }
            set { this.isLoaded = value; }
        }

        public double TotalValue
        {
            get { return this.accounts.Sum(account => account.Get_Market_Value()); }
        }

        public string FeeSetting
        {
            get { return this.feeSetting; }
            set { this.feeSetting = value; }
        }

        public double TotalFees
        {
            get { return this.accounts.Sum(account => account.Fee); }
        }

        public double TotalWithdrawals
        {
            get { return this.accounts.Sum(account => account.Withdrawal); }
        }

        public double FeeRate
        {
            get { return this.feeRate; }
            set { this.feeRate = value; }
        }

        public int NumberOfUpdatesPerYear
        {
            get { return this.numberOfUpdatesPerYear; }
            set { this.numberOfUpdatesPerYear = value; }
        }
    }
}
