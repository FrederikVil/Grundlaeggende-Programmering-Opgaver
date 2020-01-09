using System;

namespace If_consists_of_uppercase_letters
{
    /// <summary>
    /// Man skriver et ord på 3 bogstaver, og så tjekker programmet om alle bogstaver er store.
    /// </summary>
    class Program
    {
        static void Main()
        {
            string str;

            Console.Write("Skriv et ord på 3 bogstaver: ");
            str = Convert.ToString(Console.ReadLine());

            // ToUpper() Tjekker om variablen er i fuld CAPS.
            if (str.ToUpper() == str)
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
