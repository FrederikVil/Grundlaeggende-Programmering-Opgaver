using System;

namespace Swap_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2 tal skal swappes ved hjælp af en temp variable

            int tal1, tal2, temp;

            Console.Write("Skriv første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());
            
            // Talb1 bliver smidt ind i temp. tal2 bliver smidt ind i tal1. Og så bliver temp smidt ind i tal 2.
            // Nu er tal2 lige med det tal1 var i starten, og tal 1 bliver til det tal2 var i starten.
            temp = tal1;
            tal1 = tal2;
            tal2 = temp;

            Console.WriteLine(tal1);
            Console.WriteLine(tal2);

        }
    }
}
