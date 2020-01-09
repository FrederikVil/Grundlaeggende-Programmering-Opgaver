using System;

namespace Elementary_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 tal bliver plusset, minusset, ganget og divideret. Man kan ikke dividere med 0.

            double tal1, tal2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}+{tal2} = {tal1 + tal2}");
            Console.WriteLine($"{tal1}-{tal2} = {tal1 - tal2}");
            Console.WriteLine($"{tal1}*{tal2} = {tal1 * tal2}");

            // Hvis enten tal 1 eller tal2 er præcis 0 skal den gøre det.
            if (tal1 == 0 || tal2 == 0)
            {
                Console.WriteLine("Du kan ikke dividere med 0");
            }
            else
            {
                Console.WriteLine($"{tal1}/{tal2} = {tal1 / tal2}");
            }

        }
    }
}
