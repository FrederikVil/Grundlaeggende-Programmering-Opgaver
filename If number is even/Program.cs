﻿using System;

namespace If_Number_Is_Even
{
    static void Main(string[] args)
    {
        int tal;

        Console.Write("Skriv et tal: ");
        tal = Convert.ToInt32(Console.ReadLine());

        // Modulus er brugt til at finde ud af om tallet går op i 2 (altså om det er lige).
        if (tal % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Uneven");
        }
    }
}
}
