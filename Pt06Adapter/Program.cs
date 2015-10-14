using System;
using Pt06Adapter.External;
using Pt06Adapter.Internal;

namespace Pt06Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ou_int_1 = new ObjectUser(new InternalObject1());
            ou_int_1.Use();
            var ou_int_2 = new ObjectUser(new InternalObject2());
            ou_int_2.Use();

            var ou_ext_1  = new ObjectUser(new AdapterExternalToInternal(new ExternalObject1()));
            ou_ext_1.Use();


            Console.ReadLine();
        }
    }
}