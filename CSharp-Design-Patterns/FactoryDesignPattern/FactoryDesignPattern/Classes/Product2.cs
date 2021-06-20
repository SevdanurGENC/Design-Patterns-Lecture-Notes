using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    public class Product2 : IProduct
    {
        public string siparisFormu()
        {
            return "Izmir'den gelen urunler.";
        }
    }
}
