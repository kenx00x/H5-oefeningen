using System;

namespace Enum_seizoenen
{
    class Program
    {
        enum seizoenen 
        {
            winter, lente, zomer, herfst
        }
        static void Main(string[] args)
        {
            Console.Write("Geef maand nummer: ");
            int maandNummer = int.Parse(Console.ReadLine());
            string seizoen="";
            switch (maandNummer)
            {
                case 1:
                    seizoen = Convert.ToString(seizoenen.winter);
                    break;
                case 2:
                    seizoen = Convert.ToString(seizoenen.winter);
                    break;
                case 3:
                    seizoen = Convert.ToString(seizoenen.winter);
                    break;
                case 4:
                    seizoen = Convert.ToString(seizoenen.lente);
                    break;
                case 5:
                    seizoen = Convert.ToString(seizoenen.lente);
                    break;
                case 6:
                    seizoen = Convert.ToString(seizoenen.lente);
                    break;
                case 7:
                    seizoen = Convert.ToString(seizoenen.zomer);
                    break;
                case 8:
                    seizoen = Convert.ToString(seizoenen.zomer);
                    break;
                case 9:
                    seizoen = Convert.ToString(seizoenen.zomer);
                    break;
                case 10:
                    seizoen = Convert.ToString(seizoenen.herfst);
                    break;
                case 11:
                    seizoen = Convert.ToString(seizoenen.herfst);
                    break;
                case 12:
                    seizoen = Convert.ToString(seizoenen.herfst);
                    break;
            }
            if (seizoen=="winter"||seizoen=="herfst")
            {
                Console.WriteLine("koud seizoen");
            }
            else
            {
                Console.WriteLine("warm seizoen");
            }
        }
    }
}
