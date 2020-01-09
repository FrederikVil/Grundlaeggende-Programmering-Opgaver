using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Temepraturen bliver angivet i celsius, og så bliver den omregnet til fahrenheit.

            int tal;

            Console.Write("Celsius: ");
            tal = Convert.ToInt32(Console.ReadLine());   

            if (tal < -271.15)
            {
                Console.WriteLine("A temperature below -271.15°C (absolute zero) does not exist!");
            }
            else
            {
                Console.WriteLine($"Fahrenheit = {tal * 18 / 10 + 32}");
            }
        }
    }
}
