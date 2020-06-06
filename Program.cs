using System;
using Nocjar.Golf;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            GolfBag bag1 = new GolfBag("Bag1");
            GolfBag bag2 = new GolfBag("Bag2");

            Console.WriteLine(bag1.ToString());
            Console.WriteLine(bag2.ToString());
        }
    }
}
