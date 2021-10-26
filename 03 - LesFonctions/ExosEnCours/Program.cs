using ExosFonctions;
using System;

namespace ExosEnCours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exo fonction Calcule TVA
            float priceProductTTC1 = Fonctions.CalculateTVA(19.64f, 10, 5.0f);
            float priceProductTTC2 = Fonctions.CalculateTVA(254.50f, 2, 20.0f, true);

            float priceTotalTTC = Fonctions.CalculateTVA(19.64f, 10, 5.0f);
            priceTotalTTC += Fonctions.CalculateTVA(254.50f, 2, 20.0f, true);

            // Exo fonction afficher valeur caractère
            Fonctions.DisplayCharInfo('z');
            Fonctions.DisplayCharInfo('Z');
            Fonctions.DisplayCharInfo('a');
            
            // Exo fonction display color
            Fonctions.DisplayColorFromValue(-40);
            Fonctions.DisplayColorFromValue(40);

            Fonctions.DisplaySeason(10);
        }


    }
}
