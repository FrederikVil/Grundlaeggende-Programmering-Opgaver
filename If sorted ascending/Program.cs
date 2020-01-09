using System;

namespace If_sorted_ascending
{
    /// <summary>
    /// Programmet tjekker et array med et for loop, for at se om tallene er sorteret fra lavest til størst.
    /// </summary>
    class Program
    {
        public static void Main(String[] args)
        {
            int[] array = { 3, 5, 6, 7, 4};
            Console.WriteLine(IsSorted(array));
        }
        public static bool IsSorted(int[] a)
        {
            // For loopet kører igennem alle indexene i arrayet, og hvis den støder på et tal der er højere
            // end det næste index, returner den false.
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    return false; 
                }
            }
            return true; 
        }

    }
    
}
