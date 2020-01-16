using System;

namespace Lommeregner
{
    /// <summary>
    /// Programmet er en simpel lommeregner. Først vælger man hvilken regnemetode man vil bruge. Derefter skriver man 2 tal man vil regne med.
    /// Regnestykker bliver regnet ud i metoder, og bliver hentet i en switch.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {          
            double resultat = 0;
 
            Console.WriteLine("Vælg hvilken regneoperation der skal bruges");
            Console.WriteLine("Tryk 1 for Addition");
            Console.WriteLine("Tryk 2 for Subtrakion");
            Console.WriteLine("Tryk 3 for Multiplikation");
            Console.WriteLine("Tryk 4 for Division \n");
            Console.Write("1,2, 3 eller 4?: ");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSkriv tal 1 i rengestykket: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv tal 2 i regnestykket: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            // Henter de forskellige metoder i forhold til hvilken regnemetode brugeren har valgt.
            switch (action)
            {
                case 1:
                    {
                        resultat = Addition(tal1, tal2);
                        break;
                    }
                case 2:
                    {
                        resultat = Subtraktion(tal1, tal2);
                        break;
                    }
                case 3:
                    {
                        resultat = Multiplikation(tal1, tal2);
                        break;
                    }
                case 4:
                    {
                        resultat = Division(tal1, tal2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Noget gik galt");
                        break;
                    }
            }
            Console.WriteLine($"Resulatet er {resultat}\n");
            /*
            Console.WriteLine("Vil du regne videre? ('ja' eller 'nej')");
            string regnvidere = Convert.ToString(Console.ReadLine());

            if (regnvidere == "ja" || regnvidere == "Ja")
            {
                
            }
            else if (regnvidere == "nej" || regnvidere == "Nej")
            {
                Console.WriteLine("Vil du lukke programmet? ('ja' eller 'nej')");
                string close = Convert.ToString(Console.ReadLine());
                
                if (close == "ja")
                {
                    Environment.Exit(0);
                }
                else
                {

                }
            }
            */
        }
        //Metoder med regnestykker for hver operation.
        //Addition  
        public static double Addition(double tal1, double tal2)
        {
            double result = tal1 + tal2;
            return result;
        }

        //Substraktion  
        public static double Subtraktion(double tal1, double tal2)
        {
            double result = tal1 - tal2;
            return result;
        }

        //Multiplikation  
        public static double Multiplikation(double tal1, double tal2)
        {
            double result = tal1 * tal2;
            return result;
        }

        //Division  
        public static double Division(double tal1, double tal2)
        {
            double result = tal1 / tal2;
            return result;
        }


    }
}
