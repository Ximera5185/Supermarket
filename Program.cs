using System;

namespace supermarket
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Supermarket supermarket = new Supermarket();

            supermarket.Work();

            Console.ReadKey();
        }
    }
}