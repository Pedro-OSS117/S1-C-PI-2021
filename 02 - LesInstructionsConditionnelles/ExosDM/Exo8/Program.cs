/*
Exo 8 L’échelle de Richter
L’échelle de Richter permet de décrire la magnitude des tremblements de terre :
1 Micro tremblement de terre, non ressenti
2 Très mineur. non ressenti mais détecté
3 Mineur. causant rarement des dommages
4 Léger. Secousses notables d’objets à l’intérieur des maisons
5 Modéré. Légers dommages aux édifices bien construits
6 Fort. Destructeur dans des zones allant jusqu’à 180 kilomètres à la ronde si elles sont peuplées
7 Majeur. Dommages modérés à sévères dans des zones plus vastes.
8 Important. Dommages sérieux dans des zones à des centaines de kilomètres à la ronde
9 Dévastateur.Dévaste des zones sur des milliers de kilomètres à la ronde

Si le nombre n’est pas compris entre 1 et 9 c’est qu’il y a erreur de saisie (si inférieur à 1) ou que c’est l’appocalypse (si
supérieur à 9).

Vous écrirez un programme permettant à l’utilisateur de saisir une valeur d’échelle et qui en réponse affichera à l’écran la
description associée à ce nombre. Vous n’oublierez pas de gérer le cas où le nombre tapé par l’utilisateur est ”hors-échelle”.
*/

using System;

namespace Exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un chiffre allant de 1 à 9 : ");
            int chiffre = int.Parse(Console.ReadLine());

            if(chiffre < 0)
            {
                Console.WriteLine("Un chiffre positif connard");
            }
            else
            {
                switch(chiffre)
                {
                    case 1:
                    Console.WriteLine("Micro tremblement de terre, non ressenti");
                    break;

                    case 2:
                    Console.WriteLine("Très mineur. non ressenti mais détectéTrès mineur. non ressenti mais détecté");
                    break;

                    default:
                    Console.WriteLine("C'est l'apocalypse !!!");
                    break;
                }
            }
        }
    }
}
