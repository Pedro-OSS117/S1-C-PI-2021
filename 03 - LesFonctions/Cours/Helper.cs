using System;
using Cours;

namespace Utility
{
    class Helper
    {
        public static void MyFonction()
        {
            Console.WriteLine("Helper MyFonction ");
            // Je peux appeler une fonction static d'une autre Classe
            // n'importe où dans le programme à partir du moment
            // où le namespace correspond ou que le bon using est appelé
            Program.MyFonction();

            // J'ai accès aux variables static n'importe où dans le programme
            // à partir du moment
            // où le namespace correspond ou que le bon using est appelé
            Console.WriteLine(Program.myStaticValue);
            Program.myStaticValue = 3;
            Console.WriteLine(Program.myStaticValue);

            Program.MyFunctionWithReturn0(19);
        }
    }
}