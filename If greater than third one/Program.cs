using System;

namespace If_Greater_Than_Third_ONe
{
    /// <summary>
    /// Et array med 3 tal hvor den skal være true hvis tal 1 plus 2 eller tal 1 gange tal 2 er større end tal 3.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 1, 5, 5 };

            if (tal[0] + tal[1] > tal[2] || tal[0] * tal[1] > tal[2])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
