using System;

namespace Three_Increasing_Adjacent
{
    /// <summary>
    /// Den skal tjekke om 3 tal følger hinanden som stiger med 1 hver gang. Med et for loop tjekker den om det er sanndt.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Adjacent(new int[] { 5, 6, 4, 3, 4, 5 }));
        }

        public static bool Adjacent(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                // Hvis det tal der kommer før det nuværende + 1 er det samme som det nuværende, og det næste tal minus 1 er det samme
                // som det nuværende, så må de 3 tal være i - 1, i, i + 1.
                if (array[i-1] + 1 == array[i] && array[i+1] - 1 == array[i])
                {
                    return true;
                }
             
            }
            return false;
        }
    }
}
