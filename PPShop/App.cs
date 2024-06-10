using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPShop
{
    internal class App
    {
        public void Run() 
        {
            List<InventoryItem> Items = new()
            {
                new ClothingItem(200, "Sick shirt", 4, "Red", "Medium", "Cotton", "Adidas"),
                new ElectronicItem(500, "Iphone 14", 5, "Silver", "Pro", "2Years", 3.7)
            };

            FindItem(Items);
        }

        public void FindItem(List<InventoryItem> Items) 
        {
            foreach (var item in Items) 
            {
                Console.WriteLine(@$"
Name: {item.Name}
Price: {item.Price} 
Color: {item.Color}
Size: {item.Size}
Amount: {item.Amount}");

                if (item is ClothingItem clothingItem)
                {
                    Console.WriteLine(@$"Fabric: {clothingItem.Fabric}
Material: {clothingItem.Fabric}
Price after tax: {clothingItem.NetPrice()}
Price after sale: {clothingItem.NetSale()}");
                }
                else if(item is ElectronicItem elItem)
                {
                    Console.Write(@$"Insuranse Information: {elItem.InsuranceInfo}
Voltage: {elItem.Voltage}
Price after tax: {elItem.NetPrice()}
Price after sale: {elItem.NetSale()}
");
                }
            }

        }
    }
}

