using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random willekeurig = new Random();
            Console.Write("Welk getal denk je dat de computer gooide tussen 1 en 6: ");
            int gebruikergetal = int.Parse(Console.ReadLine());
            if (gebruikergetal == willekeurig.Next(1,7))
            {
                Console.WriteLine("proficiat");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }
    }
}
