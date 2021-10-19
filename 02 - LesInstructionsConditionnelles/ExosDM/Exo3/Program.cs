using System;
/*
Exo 3 :
- Declarer une variable qui represente la vie et l'initialiser à 100 de valeur.
- Declarer une variable qui represente l'état invincible/non invincible et l'initialiser à non invincible.
- Declarer une variable dommage et demander à l’utilisateur de saisir la valeur.

- Appliquer les degats en testant si la vie est tjrs superieur à zero ET si l'etat n'est pas invincible
- Afficher la valeur de la vie

- Mettre la variable invincible dans l'état invincible.
- Appliquer les degats en faisant les mêmes tests précédents
- Afficher la valeur de la vie
*/
namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vie = 100;
            bool invincible = false;
            int dommage;
            Console.WriteLine("Entrez une valeur de dommage");
            string input = Console.ReadLine();
            dommage = int.Parse(input);

            if (vie > 0 && !invincible)
            {
                vie -= dommage;
                //vie = vie - dommage;
            }
            Console.WriteLine("Resultat de la vie\n" + vie);

            invincible = true;

            if (vie > 0 && !invincible)
            {
                vie -= dommage;
            }

            Console.WriteLine("Resultat de la vie\n" + vie);

            // Exo fait avec une fonction.
            vie = CalculateDamage(vie, dommage, invincible);
        }

        private static int CalculateDamage(int life, int damage, bool isInvincible)
        {
            if (life > 0 && !isInvincible)
            {
                life -= damage;
            }
            return life;
        }
    }
}
