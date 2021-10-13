using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTheTruth = false;
            // On ne rentre pas dans le if parce que le bool est à false
            if(isTheTruth)
            {
                Console.WriteLine(isTheTruth);
            }
            
            isTheTruth = true;
            if(isTheTruth)
            {
                Console.WriteLine(isTheTruth);
            }

            if(!isTheTruth)
            {
                Console.WriteLine(isTheTruth);
            }

            // Operateur de comparaison
            // Besoin d'avoir u le même type de chaque coté de l'operateur de comparaison
            // ou un type compatible ex : float et int

            int myValue = 1;
            float myValueFloat = 1.0f;
            string name = "roger";
            if(myValue == myValueFloat)
            {
                Console.WriteLine(myValue);
            }

            if(!(myValue == myValueFloat))
            {
                Console.WriteLine(myValue);
            }

            int value1 = 10;
            int value2 = 23;

            bool testCompareOperator = value1 >= value2;
            testCompareOperator = value2 != value1;

            bool testCompareOperator2 = value1 < value2;

            testCompareOperator = !testCompareOperator2;

            // Operateur de logique || , && et !
            if(testCompareOperator || testCompareOperator2)
            {
                Console.WriteLine(testCompareOperator);
            }

            if(value1 >= value2 || value2 != value1 && value1 < value2)
            {
                Console.WriteLine(testCompareOperator);
            }

            int x = 1;
            if(x >= 0 && x <= 10)
            {
                Console.WriteLine(x);
            }

            bool testCompareOperator3 = value1 >= value2 || value2 != value1 && value1 < value2;

            // Si x entre 0 et 10
            if(x >= 0 && x <= 10)
            {
                Console.WriteLine(x);
            }
            else if(x > 10 && x <= 40) // Si x entre 11 et 40
            {

            }
            else if(x > 40) // si x superieur à 40
            {

            }
            else
            {
                Console.WriteLine("Les nombres négatifs ");
            }

            // Switch, interessant pour faire des cas que sur une seule variable
            Console.WriteLine("Tapez votre nom");
            name = Console.ReadLine();
            switch(name)
            {
                case "bob":
                case "bobette":
                    Console.WriteLine("vous faites parties des bobinous");
                break;

                case "alice":
                case "aliceette":
                case "alic0":
                    Console.WriteLine("vous faites parties des alicinou");
                break;

                default:
                    Console.WriteLine("Vous n'avez pas d'ame");
                    break;

            }
        }
    }
}
