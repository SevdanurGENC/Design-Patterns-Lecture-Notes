using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryDesignPattern.Classes;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();

            IProduct product1 = c.FactoryMethod(ProductType.Product1);
            Console.WriteLine(product1.siparisFormu());

            Console.ReadKey();  
        }
    }
}
