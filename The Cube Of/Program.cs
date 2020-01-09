using System;

namespace The_Cube_Of
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the cube of a number.
            int tal1;

            Console.Write("Write number: ");
            tal1 = Convert.ToInt32(Console.ReadLine());

            // To find the cube of a number you have to multiply it by 3.
            Console.WriteLine($"The cube of {tal1} is = {tal1*tal1*tal1}");
        }
    }
}
