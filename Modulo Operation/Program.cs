using System;

namespace Modulo_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 tal skal modulusses med hinanden.

            int tal1, tal2, tal3;
            
            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tredje tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{tal1}%{tal2}%{tal3} = {tal1%tal2%tal3}");

        }
    }
}
