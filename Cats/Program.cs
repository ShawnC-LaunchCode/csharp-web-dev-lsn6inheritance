using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!

            Cat a = new Cat(42);

            Console.WriteLine(a.Hungry);


            HouseCat b = new HouseCat("bert", 19);

            Console.WriteLine(b.Noise());

        }
    }
}
