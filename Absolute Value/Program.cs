using System;

namespace Absolute_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finder den absolutte value af et tal.

            int tal1, sum;

            Console.Write("Skriv et tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            // Math.Abs laver et tal absolut
            sum = Math.Abs(tal1);

            Console.WriteLine(sum);
        }
    }
}
