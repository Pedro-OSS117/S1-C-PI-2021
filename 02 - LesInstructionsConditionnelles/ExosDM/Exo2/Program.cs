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
