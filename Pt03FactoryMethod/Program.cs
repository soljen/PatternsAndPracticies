using System;
using Pt03FactoryMethod.Farms;
using Pt03FactoryMethod.Products;

namespace Pt03FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstructFarm farmTomato = new TomatoFarm();
            AbstructFarm farmCherry = new CherryFarm();

            AbstractProduct productTomato = farmTomato.GrowProduct();
            AbstractProduct productCherry = farmCherry.GrowProduct();



            Console.ReadKey();
        }
    }
}