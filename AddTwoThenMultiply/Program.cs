using System;

namespace AddTwoThenMultiply
{
    class AddTwoThenMultiply
    {
        static void Main(string[] args)
        {

            // 3 tal skal gives via bruger input, og så skal de 2 første plusses og til sidst ganges med det sidste tal.

            int tal1, tal2, tal3;

            Console.WriteLine("Skriv 2 tal der skal lægges sammen, og til sidst ganges med et tredje tal");

            Console.Write("Skriv første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv tredje tal: ");
            tal3 = Convert.ToInt32(Console.ReadLine());


            // De 3 givet tal lægges sammen
            Console.WriteLine($"De 3 tal lagt sammen er: {(tal1 + tal2) * tal3}");
        }
    }
}
