﻿using System;
using System.Net.NetworkInformation;

namespace Pt05Singlton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = SingltonObject.GetInstance();
            var instance2 = SingltonObject.GetInstance();

            Console.WriteLine(string.Format("instance 1 Hash Code : {0}", instance1.GetHashCode()));
            Console.WriteLine(string.Format("instance 2 Hash Code : {0}", instance2.GetHashCode()));

            var data = "Test data.";

            Console.WriteLine(string.Format("Temp data is '{0}'.", data));

            instance1.InstanceData = data;

            Console.WriteLine(string.Format("Referenced data is '{0}'.", instance2.InstanceData));

            Console.ReadLine();
        }
    }
}