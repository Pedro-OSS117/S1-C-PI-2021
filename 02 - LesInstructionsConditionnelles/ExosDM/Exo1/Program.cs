using System;
/*
Exo 1
Ecrivez un programme qui :
1. déclarer 2 variables a et b, demander à l’utilisateur de saisir les valeurs.
2. déclarer une variable nbmin également entière.
3. à l’aide d’un if, fait en sorte que la variable nbmin contienne la valeur minimale de a et b
4. affiche cette valeur minimale ainsi déterminée.
*/
namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez un nombre : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez un 2e nombre : ");
            int b = int.Parse(Console.ReadLine());

            int nbMin = a;
            // Si b < a
            if(b < a)
            {
                // alors j'assigne la valeur de b à nbMin
                nbMin = b;
            }
            // Sinon je laisse la valeur de a dans nbMin
            Console.WriteLine("Le plus petit valeur est : " + nbMin);

            // Utilisation du '?' pour faire un if sans un if dans une instruction
            nbMin = b < a ? b : a;
            
            // Si b < a alors j'assigne la valeur de b à nbMin, sinon j'assigne la valeur de a à nbMin 
            Console.WriteLine("Le plus petit valeur est : " + nbMin);
        }
    }
}
