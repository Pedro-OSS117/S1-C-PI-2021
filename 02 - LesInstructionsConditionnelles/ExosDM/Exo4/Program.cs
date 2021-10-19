using System;
/*
Exo 4 : 
Declarer une variable life et et demander à l’utilisateur de saisir la valeur.
ensuite afficher une couleur en mot en fonction de sa valeur :
0 ou inferieur : NOIR
entre 1 et 20 : ROUGE
entre 21 et 40 : ORANGE
entre 41 et 60 : JAUNE
entre 61 et 100 ou superieur à 100 : VERT
*/
namespace Exo4
{

    class Program
    {
        static void Main(string[] args) 
        {
            int life;
            Console.WriteLine("Veulliez saisir une valeur : ");
            life = int.Parse(Console.ReadLine());

            if (life <= 0)
            {
                Console.WriteLine("Noir");
            }
            else if (life >= 1 && life <= 20)
            {
                Console.WriteLine("Rouge");
            }
            else if (life >= 21 && life <= 40)
            {
                Console.WriteLine("Orange");
            }
            else if (life >= 41 && life <= 60)
            {
                Console.WriteLine("Jaune");
            }
            else if (life >= 61)
            {
                Console.WriteLine("Vert");
            }
        }
    }
}
