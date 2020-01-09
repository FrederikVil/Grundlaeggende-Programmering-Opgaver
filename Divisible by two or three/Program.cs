using System;

namespace Divisible_by_two_or_three
{

    /// <summary>
    /// Programmet tager 2 tal fra user input, og tjekker om de kan divideres med 2 eller 3 så de går i nul (modulus).
    /// Derefter ganges de 2 tal hvis det passer, ellers bliver de plusset.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            // Her bruges modulus til at finde ud af om de går op i 2 eller 3.
            if (tal1 % 2 == 0 && tal2 % 2 == 0 || tal1 % 3 == 0 && tal2 % 3 == 0)
            {
                Console.WriteLine($"{tal1}*{tal2} = {tal1 * tal2}");
            }
            else
            {
                Console.WriteLine($"{tal1}+{tal2} = {tal1 + tal2}");
            }
        }
    }
}
