using System;
using Cours;

namespace Utility
{
    class Helper
    {
        public static void MyFonction()
        {
            Console.WriteLine("Helper MyFonction ");
            Program.MyFonction();
            Console.WriteLine(Program.myStaticValue);
            Program.myStaticValue = 3;
            Console.WriteLine(Program.myStaticValue);
        }
    }
}