using System;

namespace Multiplication_Table
{
    /// <summary>
    /// Programmet kører igennem 2 loops. Et loop der viser rækkerne lodret, og et loop der viser rækkerne vandret. 10x10.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            // Hver gang den sætter et tal ind ganger den row og col med hinanden sådan at en 10 tabel opstår.
            for (int row = 1; row <= tal; row++)
            {
                for (int col = 1; col <= tal; col++)
                {
                    Console.Write($"{row * col} ");

                }
                Console.WriteLine();
            }
        }
    }
}
