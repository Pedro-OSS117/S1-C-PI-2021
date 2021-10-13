using System;

namespace ExoCours
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void IsMultResultPos()
        {
            Console.WriteLine("Bonjour bienvenue dans ce magnifique programme à la pointe de la technologie !");
            Console.WriteLine("Tapez un entier s'il vous plait :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez un second entier s'il vous plait :");
            int b = int.Parse(Console.ReadLine());

            bool isANegatif = a < 0 && b > 0;
            bool isBNegatif =  a > 0 && b < 0;
            if(isANegatif || isBNegatif)
            {
                Console.WriteLine("Le résultat est : " + (a * b) + " et il est négatif.");
            }
            else
            {                
                Console.WriteLine("Le résultat est : " + (a * b) + " et il est positif.");
            }
        }
    }
}
