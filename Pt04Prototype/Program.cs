using System;
using Pt04Prototype.Products;

namespace Pt04Prototype
{
    static class Program
    {
        static void Main(string[] args)
        {
            AbstructProduct alien = new Alien(1);
            AbstructProduct alienClone = alien.Clone();

            Console.WriteLine(alien.GetHashCode());
            Console.WriteLine(alienClone.GetHashCode());

            AbstructProduct robot = new Robot(1);
            AbstructProduct robotClone = robot.Clone();

            Console.WriteLine(robot.GetHashCode());
            Console.WriteLine(robotClone.GetHashCode());

            Console.ReadLine();
        }
    }
}