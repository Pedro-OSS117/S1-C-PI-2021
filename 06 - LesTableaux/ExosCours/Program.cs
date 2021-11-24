using System;

namespace ExosCours
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] monTableau = new int[4];
            monTableau[0] = 1;
            monTableau[1] = 9;
            monTableau[2] = 4;
            monTableau[3] = 8;*/
            // Exo 1 - Display Tab
            int[] monTableau = {1 , 9, 4, 8};
            DisplayTab(monTableau);
            Console.WriteLine("");

            DisplayTabAvecClasse(monTableau);
            char[] monTableauDeLettre = {'b', 'o', 'b', 'y'};

            DisplayTabAvecClasseGenerique<char>(monTableauDeLettre);
            Console.WriteLine("");

            // Exo 2 - Total tab
            int total = TotalTab(monTableau);
            
            Console.Write("Le total du tableau de valeurs : ");
            DisplayTabAvecClasse(monTableau);
            Console.WriteLine(" est de : " + total);
            
            // Exo 2 Bis - Moyenne tab
            float moyenne = MoyenneTab(monTableau);
            Console.Write("La moyenne du tableau de valeurs : ");
            DisplayTabAvecClasse(monTableau);
            Console.WriteLine(" est de : " + moyenne);
        }
        
        // Exo 2 - Total tab
        static int TotalTab(int[] myTab)
        {
            int result = 0;
            for(int i = 0; i < myTab.Length; i++)
            {
                result += myTab[i];
            }
            return result;
        }

        // Exo 2 Bis - Moyenne tab
        static float MoyenneTab(int[] myTab)
        {
            float total = TotalTab(myTab);
            return total / myTab.Length;
        }

        static void DisplayTab(int[] mesValeurs)
        {
            for(int i = 0; i < mesValeurs.Length; i++)
            {
                Console.WriteLine(mesValeurs[i]);
            }

            return;
        }

        static void DisplayTabAvecClasse(int[] mesValeurs)
        {
            string display = "{";
            for(int i = 0; i < mesValeurs.Length - 1; i++)
            {
                display += "\"" + mesValeurs[i] + "\",";
            }
            display += "\"" + mesValeurs[mesValeurs.Length - 1] + "\"}";
            Console.Write(display);
        }

        static void DisplayTabAvecClasseGenerique<T>(T[] myTab)
        {
            if(myTab != null)
            {
                string display = "{";
                for(int i = 0; i < myTab.Length - 1; i++)
                {
                    if(myTab[i] != null)
                    {
                        display += "\"" + myTab[i].ToString() + "\",";
                    }
                }
                if(myTab[myTab.Length - 1] != null)
                {
                    display += "\"" + myTab[myTab.Length - 1].ToString() + "\"}";
                }
                Console.Write(display);
            }
        }
    }
}