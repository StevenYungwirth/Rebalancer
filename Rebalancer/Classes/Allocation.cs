using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalancer.Classes
{
    public class Allocation
    {
        private readonly string name;
        private readonly double equity;
        private readonly double largeValue;
        private readonly double largeBlend;
        private readonly double largeGrowth;
        private readonly double midValue;
        private readonly double midBlend;
        private readonly double midGrowth;
        private readonly double smallValue;
        private readonly double smallBlend;
        private readonly double smallGrowth;
        private readonly double international;
        private readonly double specialty;
        private readonly double other;

        public Allocation(string allocationName)
        {
            this.name = allocationName;
            string equityString = "";
            if (this.name.Contains("FPIS"))
            {
                // Parse the equity target
                for (int letter = 0; letter < this.name.Length; letter++)
                {
                    // The allocation will be in the form "FPIS xx%". Loop through each letter to get the numbers
                    if (int.TryParse(this.name[letter].ToString(), out int equityPortion))
                    {
                        equityString += equityPortion.ToString();
                    }
                }

                this.equity = double.Parse(equityString) / 100;

                this.largeBlend = 0;
                this.midValue = 0.18;
                this.midBlend = 0;
                this.midGrowth = 0;
                this.smallBlend = 0;
                this.smallGrowth = 0;
                this.international = 0.26;

                if (allocationName.Contains("No Spec"))
                {
                    this.largeValue = 0.2;
                    this.largeGrowth = 0.18;
                    this.smallValue = 0.18;
                    this.specialty = 0;
                }
                else
                {
                    this.largeValue = 0.18;
                    this.largeGrowth = 0.16;
                    this.smallValue = 0.16;
                    this.specialty = 0.06;
                }
            }
            else
            {
                // Allocation is of the form "xx% LV/Intl/LG/MV/SV/Spec"
                // Parse the equity target
                bool percentFound = false;
                for (int letter = 0; letter < this.name.Length; letter++)
                {
                    if (!percentFound && int.TryParse(this.name[letter].ToString(), out int equityPortion))
                    {
                        equityString += equityPortion.ToString();
                    }
                    else if (this.name[letter] == '%')
                    {
                        percentFound = true;
                        this.equity = int.Parse(equityString);
                    }
                    else if (int.TryParse(this.name[letter].ToString(), out equityPortion))
                    {
                        this.largeValue = Get_Sector(this.name, ref letter);
                        this.international = Get_Sector(this.name, ref letter);
                        this.largeGrowth = Get_Sector(this.name, ref letter);
                        this.midValue = Get_Sector(this.name, ref letter);
                        this.smallValue = Get_Sector(this.name, ref letter);
                        this.specialty = Get_Sector(this.name, ref letter);
                    }
                }
            }
        }

        private double Get_Sector(string allocationName, ref int startIndex)
        {
            string sectorString = "";
            for (int letter = startIndex; letter < allocationName.Length; letter++)
            {
                if (allocationName[letter] == '/')
                {
                    startIndex = letter + 1;
                    return double.Parse(sectorString) / 100;
                }
                else if (int.TryParse(allocationName[letter].ToString(), out int equityPortion))
                {
                    sectorString += equityPortion.ToString();
                }
            }
            
            return double.Parse(sectorString) / 100;
        }

        public string Name
        {
            get { return this.name; }
        }

        public double Equity
        {
            get { return this.equity; }
        }

        public double LargeValue
        {
            get { return this.largeValue; }
        }

        public double LargeBlend
        {
            get { return this.largeBlend; }
        }

        public double LargeGrowth
        {
            get { return this.largeGrowth; }
        }

        public double MidValue
        {
            get { return this.midValue; }
        }

        public double MidBlend
        {
            get { return this.midBlend; }
        }

        public double MidGrowth
        {
            get { return this.midGrowth; }
        }

        public double SmallValue
        {
            get { return this.smallValue; }
        }

        public double SmallBlend
        {
            get { return this.smallBlend; }
        }

        public double SmallGrowth
        {
            get { return this.smallGrowth; }
        }

        public double International
        {
            get { return this.international; }
        }

        public double Specialty
        {
            get { return this.specialty; }
        }

        public double Other
        {
            get { return this.other; }
        }
    }
}
