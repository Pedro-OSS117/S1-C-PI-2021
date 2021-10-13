using System;

namespace CharacterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyer sur une touche : ");       
            ConsoleKeyInfo consoleKeyInf = Console.ReadKey();
            char characterRead = consoleKeyInf.KeyChar;
            int valCaracter = characterRead;
            Console.WriteLine("\nVous avez appuyé sur la touche : " + characterRead + " de valeur " + valCaracter);
        }
    }
}
