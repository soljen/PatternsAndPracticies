using System;

namespace Pt06Adapter.External
{
    public class ExternalObject1 : IExternalInterface
    {
        public void BlaBlaSomething()
        {
            Console.WriteLine("I'm ExternalObject1.");
        }
    }
}