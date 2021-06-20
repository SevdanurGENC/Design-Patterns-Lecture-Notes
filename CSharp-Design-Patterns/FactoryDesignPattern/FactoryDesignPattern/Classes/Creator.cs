using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    public class Creator
    {
        public IProduct FactoryMethod(ProductType productType)
        {
            IProduct product = null;

            switch (productType)
            {
                case ProductType.Product1:
                    product = new Product1();
                    break;
                case ProductType.Product2:
                    product = new Product2();
                    break;
                case ProductType.Product3:
                    product = new Product3();
                    break;
            }

            return product;
        }
    }
}
