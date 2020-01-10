using System;

namespace The_Biggest_Number
{

    /// <summary>
    /// Programmet kører et for loop der tjekker om det næste tal i arrayet er sttørrere end det der står i index variablen.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, 5, 10, 50, 2, 6, 18, 16 };
            int index = 0;

            foreach (int number in array)
            {
                // Index er 0 fra starten, og så kører den ellers bare alle tal igennem og tjekker om det næste tal er størrere.
                if (index < number)
                {
                    index = number;
                }
            }
            Console.WriteLine(index);   
        }
    }
}
