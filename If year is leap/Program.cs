using System;

namespace If_year_is_leap
{
    /// <summary>
    /// Programmet regner skudår ud, ud fra et år som man sætter ind via bruger input.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Skriv et årstal: ");
            year = Convert.ToInt32(Console.ReadLine());

            // Hvis året kan deles med 4, er det et skudår, med mindre det går op i 100. Men hvis året går op i 100
            // og 400 på samme tid er det et skudår (år 300 er ikke et skudår da det går op i 100, men år 400 er).
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }





        }
    }
}
