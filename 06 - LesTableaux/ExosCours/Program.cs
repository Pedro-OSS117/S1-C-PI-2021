using System;

namespace ExosCours
{
    class Program
    {

        enum MyEnum
        {
            MaValeur1 = 5,
            MaValeur2,
            Mavaleur3
        }

        static void Main(string[] args)
        {
            // Initialisation valeur par valeur
            /*int[] monTableau = new int[4];
            monTableau[0] = 1;
            monTableau[1] = 9;
            monTableau[2] = 4;
            monTableau[3] = 8;*/

            MyEnum[] monTabEnum = new MyEnum[3];
            MyEnum[] monTabEnum2 = {MyEnum.MaValeur1, MyEnum.MaValeur2};
            DisplayTabAvecClasseGenerique<MyEnum>(monTabEnum2);

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

            // Exo 3 - Search Index Value
            Console.WriteLine(Exo.SearchIndexValue(monTableau, 54));

            int index = Exo.SearchIndexValue(monTableau, 54);
            if(index != -1)
            {
                monTableau[index] = 3;
            }
            
            // Exo 4 - Search Occurence Value
            int[] monTableauOccurence = {1,17,18,20,17,50,17};
            Console.WriteLine(Exo.SearchOccurenceValue(monTableauOccurence, 17));
            Console.WriteLine(Exo.SearchOccurenceValue(monTableauOccurence, 54));
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
            Console.WriteLine(display);
        }

        static void DisplayTabAvecClasseGenerique<T>(T[] myTab)
        {
            if(myTab == null)
            {
                return;
            }

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
            Console.WriteLine(display);
        }
    }
}