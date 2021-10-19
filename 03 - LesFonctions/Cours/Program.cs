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

            // Value vaut 1
            int value = MyFunctionWithReturn();

            //ConsoleKeyInfo infos = Console.ReadKey();

            MyFunctionWithReturn0(14);
            Console.WriteLine(value);
            MyFunctionWithReturn0(value);
            Console.WriteLine(value);
        }

        // Fonction sans type de retour
        private static void MyFunctionWithReturn0(int value)
        {
            value++;
            Console.WriteLine("value in " + value);
        }

        private static int MyFunctionWithReturn()
        {
            float myFloat = 1.0f;
            return (int)myFloat;
        }

        private static float MyFunctionWithReturn1()
        {
            int myInt = 1;
            return myInt;
        }

        private static string MyFunctionWithReturn2()
        {
            return "coucou";
        }
        
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
