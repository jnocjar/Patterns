using System;
using Golf;
using Golf.GolfGear;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            GolfBag bag = new GolfBag("TestBag");

            Console.WriteLine(bag.ToString());
        }
    }
}
