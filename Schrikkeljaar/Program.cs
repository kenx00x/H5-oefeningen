using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef jaar: ");
            int jaar = int.Parse(Console.ReadLine());
            if (jaar%4==0)
            {
                Console.WriteLine($"{jaar} is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar");
            }
        }
    }
}
