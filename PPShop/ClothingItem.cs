using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShop
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Fabric { get; set; }
        public string ClothingBrand { get; set; }

        public double NetPrice()
        {
            return Price * 0.85;
        }

        public double NetSale()
        {
            return NetPrice() * 0.7;
        }

        public ClothingItem(double price, string name, int amount, string color, string size,
            string fabric, string clothingBrand) : base(price, name, amount, color, size)
        {
            {
                Fabric = fabric;
                ClothingBrand = clothingBrand;
            }
        }
    }
}
