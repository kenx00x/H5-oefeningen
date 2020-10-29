using System;

namespace Orakeltje_van_Delphi__part_deux
{
    class Program
    {
        static void Main(string[] args)
        {
            Random willekeurig = new Random();
            Console.Write("Ben je een man of vrouw (geef \"m\" of \"v\" in): ");
            string geslacht = Console.ReadLine();
            Console.Write("Hoe oud ben je: ");
            int leeftijd = int.Parse(Console.ReadLine());
            if (geslacht == "m")
            {
                Console.WriteLine($"Je gaat nog {willekeurig.Next(5, 121 - leeftijd)} jaar leven");
            }
            else
            {
                Console.WriteLine($"Je gaat nog {willekeurig.Next(5, 151 - leeftijd)} jaar leven");
            }
        }
    }
}
