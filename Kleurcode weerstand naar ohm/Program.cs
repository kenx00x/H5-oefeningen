using System;

namespace Kleurcode_weerstand_naar_ohm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef ring1: ");
            string ring1 = Console.ReadLine();
            int ring1waarde =0;
            switch (ring1)
            {
                case "zwarte":
                    ring1waarde = 0;
                    break;
                case "bruin":
                    ring1waarde = 10;
                    break;
                case "rood":
                    ring1waarde = 20;
                    break;
                case "oranje":
                    ring1waarde = 30;
                    break;
                case "geel":
                    ring1waarde = 40;
                    break;
                case "groen":
                    ring1waarde = 50;
                    break;
                case "blauw":
                    ring1waarde = 60;
                    break;
                case "violet":
                    ring1waarde = 70;
                    break;
                case "grijs":
                    ring1waarde = 80;
                    break;
                case "wit":
                    ring1waarde = 90;
                    break;
            }
            Console.Write("Geef ring2: ");
            string ring2 = Console.ReadLine();
            int ring2waarde = 0;
            switch (ring2)
            {
                case "zwarte":
                    ring2waarde = 0;
                    break;
                case "bruin":
                    ring2waarde = 1;
                    break;
                case "rood":
                    ring2waarde = 2;
                    break;
                case "oranje":
                    ring2waarde = 3;
                    break;
                case "geel":
                    ring2waarde = 4;
                    break;
                case "groen":
                    ring2waarde = 5;
                    break;
                case "blauw":
                    ring2waarde = 6;
                    break;
                case "violet":
                    ring2waarde = 7;
                    break;
                case "grijs":
                    ring2waarde = 8;
                    break;
                case "wit":
                    ring2waarde = 9;
                    break;
            }
            Console.Write("Geef ring3: ");
            string ring3 = Console.ReadLine();
            int ring3waarde = 0;
            switch (ring3)
            {
                case "zwarte":
                    ring3waarde = 1;
                    break;
                case "bruin":
                    ring3waarde = 10;
                    break;
                case "rood":
                    ring3waarde = 100;
                    break;
                case "oranje":
                    ring3waarde = 1000;
                    break;
                case "geel":
                    ring3waarde = 10000;
                    break;
                case "groen":
                    ring3waarde = 100000;
                    break;
                case "blauw":
                    ring3waarde = 1000000;
                    break;
                case "violet":
                    ring3waarde = 10000000;
                    break;
            }
            Console.WriteLine($"Deze weerstand heeft een waarde van {(ring1waarde+ring2waarde)*ring3waarde}");
        }
    }
}
