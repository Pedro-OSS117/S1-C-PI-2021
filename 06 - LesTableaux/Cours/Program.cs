using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            char[] monMot = null;

            // Initialisation
            int[] mesValeurs = new int[4];
            monMot = new char[5];
            Console.WriteLine("Tableau monMot : " + monMot.Length);
            Console.WriteLine("Tableau mesValeurs : " + mesValeurs.Length);

            // Accès éléments du tableau
            Console.WriteLine(mesValeurs[0]);
            Console.WriteLine(mesValeurs[1]);
            Console.WriteLine(mesValeurs[3]);
            Console.WriteLine(mesValeurs[mesValeurs.Length - 1]);
            Console.WriteLine(monMot[0]);

            // Affectation d'une valeur d'un tableau
            mesValeurs[1] = 4;
            Console.WriteLine(mesValeurs[1]);

            monMot[3] = 'z';
            Console.WriteLine(monMot[3]);

            // Accès Interdi à l'exterieur du tableau
            // mesValeurs[7] = 4;
            // mesValeurs[-1] = 4;
            
            // Declaration avec assignation de valeurs par défaut directement.
            int[] monTableau1 = {1, 2, 3};
            char[] monTableauDeChar = {'1', '2', (char)3};

        }
    }
}
