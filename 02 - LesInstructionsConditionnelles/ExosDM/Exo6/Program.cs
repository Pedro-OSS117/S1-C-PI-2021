/*
Exo 6 :
Si l’année A n’est pas divisible par 4, alors elle n’est pas bissextile Si A est divisible par 4, l’année est bissextile sauf si
A est divisible par 100 et pas par 400.
Exemples :
– 1901 n’est pas bissextile car non divisible par 4
– 2004 est bissextile car divisible par 4 et pas par 100
– 2100 n’est pas bissextile car divisible par 4, divisible par 100 mais pas par 400
– 2000 est bissextile car divisible par 4, par 100 et pas par 400
Ecrire un programme qui détermine si une année est bissextile ou non.
*/

using System;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, Veuillez indiquer une année.");
            int year = int.Parse(Console.ReadLine());

            // Si l’année A n’est pas divisible par 4, 
            // alors elle n’est pas bissextile Si A est divisible par 4, l’année est bissextile sauf si
            // A est divisible par 100 et pas par 400.
            if(year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
            {
                Console.WriteLine(year + " est une année bissextile");
            }
            else
            {
                Console.WriteLine(year + " n'est pas une année bissextile.");
            }
        }
    }
}
