/*
Exo 2
Ecrire un programme qui teste si un nombre entier est pair, demander à l’utilisateur de saisir le nombre.
Dans le cas où le chiffre est pair, vous afficherez un message du
type ”Le chiffre X est pair”, et s'il est impair vous afficherez "Le chiffre X est pair"
*/

using System;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberValue;
            Console.WriteLine("Veuillez saisir un chiffre : ");
            string value= Console.ReadLine();
            numberValue = int.Parse(value);

            // Si number Value est pair
            if (numberValue % 2 == 0)
            {
                Console.WriteLine("Votre chiffre est Pair !");
            } 
            else
            {
                Console.WriteLine("Votre chiffre est Impair !");
            }
        }
    }
}
