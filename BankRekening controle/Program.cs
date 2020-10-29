using System;

namespace BankRekening_controle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de eerste 3 cijfers van je bankrekeningnummer:");
            string eerste = Console.ReadLine();

            Console.Write("Geef de volgende 7 cijfers van je bankrekeningnummer:");
            string tweede = Console.ReadLine();

            Console.Write("Geef de laatste 2 cijfers van je bankrekeningnummer:");
            int laatste = int.Parse(Console.ReadLine());

            long eersteTien = long.Parse($"{eerste}{tweede}");
            int rest = Convert.ToInt32(eersteTien % 97);

            if (rest == laatste)
            {
                Console.WriteLine("Het bankrekeningnummer is geldig!");
            }
            else
            {
                Console.WriteLine("Het bankrekeningnummer is niet geldig.");
            }
        }
    }
}
