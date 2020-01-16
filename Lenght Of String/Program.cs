using System;

namespace Lenght_Of_String
{
    /// <summary>
    /// Programmet tager bruger input, og looper igennem alle kkarakktererne i stringen. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 0;

            Console.Write("Skriv en sætning: ");
            str = Convert.ToString(Console.ReadLine());

            // Hver gang den looper igennem, lægger den 1 til count.
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
