using System;

namespace Is_result_the_same
{
    class Program
    {
        static void Main()
        {
            // Hvis resultatet af begge regnestykker er det samme, skal den pritne true.

            double tal1, tal2;
            double resultat1, resultat2;

            Console.Write("Første tal: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Andet tal: ");
            tal2 = Convert.ToInt32(Console.ReadLine());

            // Resultatet af de 2 regnestykker puttes ind i variabler, så de kan bruges til at finde ud af om svaret er ens.
            resultat1 = tal1 + tal2;
            resultat2 = tal1 * tal2;

            Console.WriteLine($"{tal1}+{tal2} = {resultat1}");
            Console.WriteLine($"{tal1}*{tal2} = {resultat2}");

            if (resultat1 == resultat2)
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
