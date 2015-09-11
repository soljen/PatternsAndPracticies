using System;

namespace Pt03FactoryMethod.Products
{
    class Tomato : AbstractProduct
    {
        public Tomato()
        {
            Console.WriteLine(this.GetHashCode().ToString());
        }
    }
}