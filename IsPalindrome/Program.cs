using System;

namespace IsPalindrome
{
    /// <summary>
    /// Tjekker om det ord der er givet via user input er et palindrom.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome());
        }

        public static bool Palindrome()
        {
            string ord = UserInput();
            // Den tjekker halvdelen af ordet
            for (int i = 0; i < ord.Length / 2; i++)
            {
                if (ord[i] != ord[ord.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static string UserInput()
        {
            // Tager user input
            Console.Write("Skriv et ord: ");
            return Console.ReadLine();
        }
    }
}
