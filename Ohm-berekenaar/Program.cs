using System;

namespace Ohm_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je berekenen?");
            Console.WriteLine("1) spanning");
            Console.WriteLine("2) weerstand ");
            Console.WriteLine("3) stroomsterkte");
            Console.WriteLine();
            int antwoord = int.Parse(Console.ReadLine());

            double spanning;
            double weerstand;
            double stroomsterkte;

            if (antwoord==1)
            {
                Console.Write("Geef de weerstand: ");
                weerstand = double.Parse(Console.ReadLine());
                Console.Write("Geef de stroomsterkt: ");
                stroomsterkte = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"de spanning is {weerstand*stroomsterkte}");
            }
            else if (antwoord==2)
            {
                Console.Write("Geef de spanning: ");
                spanning = double.Parse(Console.ReadLine());
                Console.Write("Geef de stroomsterkte: ");
                stroomsterkte = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"de weerstand is {spanning/stroomsterkte}");
            }
            else if (antwoord==3)
            {
                Console.Write("Geef de spanning: ");
                spanning = double.Parse(Console.ReadLine());
                Console.Write("Geef de weerstand: ");
                weerstand = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"de stroomsterkte is {spanning/weerstand}");
            }
        }
    }
}
