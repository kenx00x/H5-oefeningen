using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel schoenen wil je kopen: ");
            int schoenen = int.Parse(Console.ReadLine());
            if (schoenen >= 10)
            {
                Console.WriteLine($"{schoenen} schoenen kosten {9*20+(schoenen-9)*10} euro");
            }
            else
            {
                Console.WriteLine($"{schoenen} schoenen kosten {schoenen * 20} euro");
            }
        }
    }
}
