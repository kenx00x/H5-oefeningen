using System;

namespace GuntherD_Stemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antwoord altijd met ja of nee");
            Console.WriteLine();
            Console.Write("Werk je veel? ");
            string antwoord = Console.ReadLine();
            Console.Clear();
            if (antwoord=="ja")
            {
                Console.Write("Koop je soms bruin brood? ");
                antwoord = Console.ReadLine();
                Console.Clear();
                if (antwoord=="ja")
                {
                    Console.Write("Ben je een seut? ");
                    antwoord = Console.ReadLine();
                    Console.Clear();
                    if (antwoord=="ja")
                    {
                        Console.WriteLine("CD&V");
                    }
                    else if (antwoord=="nee")
                    {
                        Console.Write("Heb je vrienden? ");
                        antwoord = Console.ReadLine();
                        Console.Clear();
                        if (antwoord=="nee")
                        {
                            Console.WriteLine("NVA");
                        }
                        else if (antwoord=="ja")
                        {
                            Console.Write("Staat jouw wagen, huis, ... op naam van je ouders? ");
                            antwoord = Console.ReadLine();
                            Console.Clear();
                            if (antwoord=="ja")
                            {
                                Console.WriteLine("open VLD");
                            }
                            else if (antwoord=="nee")
                            {
                                Console.WriteLine("Blanco");
                            }
                        }
                    }
                }
                else if (antwoord=="nee")
                {
                    Console.WriteLine("Vlaams belang");
                }
            }
            else if (antwoord=="nee")
            {
                Console.Write("Eet je vaak Quinoa? ");
                antwoord = Console.ReadLine();
                Console.Clear();
                if (antwoord=="ja")
                {
                    Console.WriteLine("Groen");
                }
                else if (antwoord=="nee")
                {
                    Console.Write("Krijg je vaak de schuld van alles?? ");
                    antwoord = Console.ReadLine();
                    Console.Clear();
                    if (antwoord=="ja")
                    {
                        Console.WriteLine("sp.a");
                    }
                    else if (antwoord=="nee")
                    {
                        Console.Write("Geloof je nog in Sinterklaas? ");
                        antwoord = Console.ReadLine();
                        Console.Clear();
                        if (antwoord=="ja")
                        {
                            Console.WriteLine("PVDA");
                        }
                        else if (antwoord=="nee")
                        {
                            Console.WriteLine("Blanco");
                        }
                    }
                }
            }
        }
    }
}
