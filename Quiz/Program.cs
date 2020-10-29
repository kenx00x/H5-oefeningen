using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Hoe oud is koningin Elizabeth II?");
            Console.WriteLine("a) 89");
            Console.WriteLine("b) 94");
            Console.WriteLine("c) 87");
            Console.WriteLine("d) 91");
            Console.WriteLine();
            string antwoord = Console.ReadLine();
            int score = 0;
            switch (antwoord)
            {
                case "a":
                    score = -1;
                    break;
                case "b":
                    score = 2;
                    break;
                case "c":
                    score = -1; 
                    break;
                case "d":
                    score = -1;
                    break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je score is {score}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welk jaar is het?");
            Console.WriteLine("a) 2020");
            Console.WriteLine("b) 2019");
            Console.WriteLine("c) 2021");
            Console.WriteLine("d) 1987");
            Console.WriteLine();
            antwoord = Console.ReadLine();
            switch (antwoord)
            {
                case "a":
                    score = score + 2;
                    break;
                case "b":
                    score--;
                    break;
                case "c":
                    score--;
                    break;
                case "d":
                    score--;
                    break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je score is {score}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hoe heet de school waar wij naar toe gaan?");
            Console.WriteLine("a) KDG");
            Console.WriteLine("b) HoGent");
            Console.WriteLine("c) AP");
            Console.WriteLine("d) Univeriteit Antwerpen");
            Console.WriteLine();
            antwoord = Console.ReadLine();
            switch (antwoord)
            {
                case "a":
                    score--;
                    break;
                case "b":
                    score--;
                    break;
                case "c":
                    score = score + 2;
                    break;
                case "d":
                    score--;
                    break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je score is {score}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
