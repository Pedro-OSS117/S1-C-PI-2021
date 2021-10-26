using System;

namespace ExosFonctions
{
    class Fonctions
    {
        /***
            Fonction pour calculer le prix TTC d'une produit en fonction
            d'une tva et d'une quantité.
            La TVA est exprimée en pourcentage.
        */
        public static float CalculateTVA(float price, int quantity, float tva, bool displayInfos = false)
        {
            float priceTTC = (price + price * (tva / 100)) * quantity;

            if(displayInfos)
            {
                Console.WriteLine("Prix produit TTC (" + tva + "%) : " + priceTTC);
            }

            return priceTTC;
        }

        public static void DisplayCharInfo(char character)
        {
            Console.WriteLine("La valeur numérique de " + character + " est : " + (int)character);
        }

        /*

        */
        public static bool DisplayColorFromValue(int value)
        {
            if(value >= 0 && value <= 100)
            {
                if (value <= 0)
                {
                    Console.WriteLine("Noir");
                }
                else if (value >= 1 && value <= 20)
                {
                    Console.WriteLine("Rouge");
                }
                else if (value >= 21 && value <= 40)
                {
                    Console.WriteLine("Orange");
                }
                else if (value >= 41 && value <= 60)
                {
                    Console.WriteLine("Jaune");
                }
                else if (value >= 61)
                {
                    Console.WriteLine("Vert");
                }
                else
                {
                    Console.WriteLine("Blanc");
                }
                return true;
            }
            Console.WriteLine("valeur pas valide car pas entre 0 et 100, valeur " + value);
            return false;
        }

        public static void DisplaySeason(string month)
        {

        }

        public static void DisplaySeason(int month)
        {

        }

    }
}