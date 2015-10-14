using System;

namespace Pt06Adapter.Internal
{
    public class InternalObject1 : IUseObject
    {
        public void SaySomething()
        {
            Console.WriteLine("I'm InternalObject1.");
        }
    }
}