using System;
using Utility;

namespace Cours
{
    class Program
    {
        public static float myStaticValue = 1;

        static void Main(string[] args)
        {
            //Helper.MyFonction();

            //int value = MyFunctionWithReturn();

            // Tous les types suivants, lorsqu'ils sont passés
            // il y aura une copie en mémoire
            // Type de base
            // Ennumeration
            // Structure
            // Tableau
            int value = 5;
            MyFunctionWithReturn0(14);
            Console.WriteLine(value);
            MyFunctionWithReturn0(value);
            Console.WriteLine(value);

            string name = "roger";
            MyFunctionStringModify(name, "jeanne");
            Console.WriteLine(name);
        }

        public static string MyFunctionStringModify(string name, string prefix)
        {
            name = prefix + "_" + name;
            Console.WriteLine("Vous vous appelez desormais " + name);
            Console.WriteLine("Bonjour MessieursDames " + name);
            return name;
        }

        // Fonction sans type de retour
        public static void MyFunctionWithReturn0(int value)
        {
            value++;
            Console.WriteLine("value in " + value);
        }

        // Fonction avec type de retour - int
        private static int MyFunctionWithReturn()
        {
            float myFloat = 1.0f;
            return (int)myFloat;
        }

        // Fonction avec type de retour - float
        private static float MyFunctionWithReturn1()
        {
            int myInt = 1;
            return myInt;
        }

        // Fonction avec type de retour - string
        private static string MyFunctionWithReturn2()
        {
            return "coucou";
        }
        
        // Fonction avec type de retour - il faut une
        // instruction de type return dans tous les cas
        private static string MyFunctionWithReturn3(int value)
        {
            // toujours avoir une intruction de type return
            // s'il y a un type de retour
            if(value > 0)
            {
                return "coucou";
            }

            if(value <= 0)
            {
                return "Noncoucou";
            }
            return "jamais atteint";
        }

        // signature la plus simple
        // pas de retour
        // pas d'arguments
        private static void MyFonction()
        {
            int value = 5;
            if(value < 5)
            {
                return;
            }
        }

        // Deux fonctions peuvent avoir le même identifiant
        // mais dans ce cas elles doivent avoir une signature différente
        // au niveau de leurs arguments.
        public static void MyFonction(int value = 2)
        {
            Console.WriteLine("Program MyFonction " + value);
        }
    }
}
