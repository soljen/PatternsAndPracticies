using System;

namespace Pt01AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new FordClient(new FordFactory());
            client.BuildCar();

            Console.ReadLine();
        }
    }
}
