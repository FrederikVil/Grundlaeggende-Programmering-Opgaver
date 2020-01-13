using System;

namespace Sieve_Of_Eratosthenes
{

    /// <summary>
    /// Programmet viser primtal. Bruger input angiver hvor højt den skal tælle op til.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Skriv et tal som primtal skal køres op til: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Så længe i er mindre eller lige med det tal brugeren har angivet kører loopet. 
            // Programmet starter fra 2, da 2 er det eneste lige tal der er et primtal.
            for (int i = 2; i <= num; i++)
            {
                // isPrime er true, med mindre loopet neden under beviser noget andet.
                bool isPrime = true;
                // Den prøver at dividere det nuværende tal (i) med alle tal der er lavere (j), for at se om de går op i hinanden. 
                // For eksempel med 5. 5/2 = true 5/3 = true 5/4 true. Derfor er 5 et primtal. 4/2 er dog = 0/false, og er derfor ikke et primtal.
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) 
                {
                    Console.WriteLine("Prime: " + i);
                }
            }

        }
    }
}
