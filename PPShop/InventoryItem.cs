using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShop
{
    internal class InventoryItem : ISellable
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }


        public double NetPrice()
        {
            return 1.2;
        }

        public double NetSale()
        {
            return Price * 0.8;
        }

        public InventoryItem(double price, string name, int amount, string color, string size)
        {
            Price = price;
            Name = name;
            Amount = amount;
            Color = color;
            Size = size;
        }
    }
}
