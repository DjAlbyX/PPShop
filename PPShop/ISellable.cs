using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPShop
{
    internal interface ISellable
    {
        public double NetPrice();
        public double NetSale();
    }
}
