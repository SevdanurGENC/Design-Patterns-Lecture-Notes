using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    public class Product3 : IProduct
    {
        public string siparisFormu()
        {
            return "Ankara'dan gelen urunler.";
        }
    }
}
