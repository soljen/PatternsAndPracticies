using System;

namespace Pt06Adapter.Internal
{
    public class InternalObject2 : IUseObject
    {
        public void SaySomething()
        {
            Console.WriteLine("I'm InternalObject2.");
        }
    }
}