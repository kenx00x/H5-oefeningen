using System;

namespace BMI_met_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());
            Console.Write("Geef je lengte in meter: ");
            double lengte = double.Parse(Console.ReadLine());
            double BMI = Math.Round((gewicht / (lengte * lengte)), 2);
            if (BMI<18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Je BMI is {BMI}");
                Console.WriteLine($"ondergewicht");
            }
            else if(BMI < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Je BMI is {BMI}");
                Console.WriteLine($"normaal gewicht");
            }
            else if (BMI < 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Je BMI is {BMI}");
                Console.WriteLine($"overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.");
            }
            else if (BMI < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Je BMI is {BMI}");
                Console.WriteLine($"Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Je BMI is {BMI}");
                Console.WriteLine($"ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
            }
            Console.ReadLine();
        }
    }
}
