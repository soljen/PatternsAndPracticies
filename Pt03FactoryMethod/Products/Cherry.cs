using System;

namespace Pt03FactoryMethod.Products
{
    class Cherry : AbstractProduct
    {
        public Cherry()
        {
            Console.WriteLine(this.GetHashCode().ToString());
        }
    }
}