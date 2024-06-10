using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShop
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
       public string InsuranceInfo  { get; set; }
       public double Voltage { get; set; }

        public double NetPrice()
        {
            return Price * 0.75;
        }

        public double NetSale() 
        {
            return NetPrice() * 0.8;
        }

        public ElectronicItem(double price, string name, int amount, string color, 
            string size, string insuranceInfo, double voltage) : base(price, name, amount, color, size)
        {
            InsuranceInfo = insuranceInfo;
            Voltage = voltage;
        }
    }
}
