using System;

namespace Positive_Negative_Or_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal;
            int control = 0;

            Console.Write("Skriv et tal: ");
            tal = Convert.ToDouble(Console.ReadLine());

            if (tal > control)
            {
                Console.WriteLine("Positive");
            }
            else if (tal == control)
            {
                Console.WriteLine("The number is 0");
            }
            else if (tal < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
