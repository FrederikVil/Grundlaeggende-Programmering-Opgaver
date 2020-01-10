using System;

namespace Two_Seven_s_Next_To_Each_Other
{
    /// <summary>
    /// Check if the current number is 7, and if the next one is 7 aswell, return true.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSeven(new int[] { 5, 4, 3, 7, 7, 7, 4, 5, 4, 7, 7, 4 }));
        }

        public static int TwoSeven(int[] array)
        {
            int index = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                // If current is 7 and the one before.
                if (array[i] == 7 && array[i-1] == 7)
                {
                    index++;
                }
            }
            return index;
        }
    }
}
