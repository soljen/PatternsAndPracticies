using System;
using Pt02Builder.Chefs;

namespace Pt02Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractChef ukrainianChef = new UkrainianChef();
            AbstractChef chinaChef = new ChineChef();

            var master = new MasterChef(ukrainianChef, chinaChef);

            master.ManageKitchen();

            var ukrResult = ukrainianChef.GetResult();
            var chnResult = chinaChef.GetResult();

            Console.WriteLine(ukrResult);
            Console.WriteLine(chnResult);

            Console.ReadLine();
        }
    }
}