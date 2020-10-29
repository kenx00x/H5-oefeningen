using System;

namespace Kleurcode_weerstand_naar_ohm__met_enum
{
    class Program
    {
        enum kleurcodes
        { 
            zwart,
            bruin,
            rood,
            oranje,
            geel,
            groen,
            blauw,
            violet,
            grijs,
            wit
        }
        static void Main(string[] args)
        {
            Console.Write("Geef ring1: ");
            kleurcodes ring1;
            Enum.TryParse(Console.ReadLine(), out ring1);
            int ring1waarde = 0;
            switch (ring1)
            {
                case kleurcodes.zwart:
                    ring1waarde = 0;
                    break;
                case kleurcodes.bruin:
                    ring1waarde = 10;
                    break;
                case kleurcodes.rood:
                    ring1waarde = 20;
                    break;
                case kleurcodes.oranje:
                    ring1waarde = 30;
                    break;
                case kleurcodes.geel:
                    ring1waarde = 40;
                    break;
                case kleurcodes.groen:
                    ring1waarde = 50;
                    break;
                case kleurcodes.blauw:
                    ring1waarde = 60;
                    break;
                case kleurcodes.violet:
                    ring1waarde = 70;
                    break;
                case kleurcodes.grijs:
                    ring1waarde = 80;
                    break;
                case kleurcodes.wit:
                    ring1waarde = 90;
                    break;
            }
            Console.Write("Geef ring2: ");
            kleurcodes ring2;
            Enum.TryParse(Console.ReadLine(), out ring2);
            int ring2waarde = 0;
            switch (ring2)
            {
                case kleurcodes.zwart:
                    ring2waarde = 0;
                    break;
                case kleurcodes.bruin:
                    ring2waarde = 1;
                    break;
                case kleurcodes.rood:
                    ring2waarde = 2;
                    break;
                case kleurcodes.oranje:
                    ring2waarde = 3;
                    break;
                case kleurcodes.geel:
                    ring2waarde = 4;
                    break;
                case kleurcodes.groen:
                    ring2waarde = 5;
                    break;
                case kleurcodes.blauw:
                    ring2waarde = 6;
                    break;
                case kleurcodes.violet:
                    ring2waarde = 7;
                    break;
                case kleurcodes.grijs:
                    ring2waarde = 8;
                    break;
                case kleurcodes.wit:
                    ring2waarde = 9;
                    break;
            }
            Console.Write("Geef ring3: ");
            kleurcodes ring3;
            Enum.TryParse(Console.ReadLine(), out ring3);
            int ring3waarde = 0;
            switch (ring3)
            {
                case kleurcodes.zwart:
                    ring3waarde = 1;
                    break;
                case kleurcodes.bruin:
                    ring3waarde = 10;
                    break;
                case kleurcodes.rood:
                    ring3waarde = 100;
                    break;
                case kleurcodes.oranje:
                    ring3waarde = 1000;
                    break;
                case kleurcodes.geel:
                    ring3waarde = 10000;
                    break;
                case kleurcodes.groen:
                    ring3waarde = 100000;
                    break;
                case kleurcodes.blauw:
                    ring3waarde = 1000000;
                    break;
                case kleurcodes.violet:
                    ring3waarde = 10000000;
                    break;
            }
            Console.WriteLine($"Deze weerstand heeft een waarde van {(ring1waarde + ring2waarde) * ring3waarde}");

        }
    }
}
