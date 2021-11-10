using System;
using MyEnum;

namespace PendantLeCours
{
    class Program
    {
        static void Main(string[] args)
        {
            DoigtMain doigt = 0;

            DoigtMain.Annulaire = 1;
            
            doigt = DoigtMain.Pouce;
            DoigtMain doigt2 = DoigtMain.Majeur;
            
            Console.WriteLine("Value : " + doigt);

            doigt++;
            Console.WriteLine("Value : " + doigt);

            ConsoleKeyInfo readKey = Console.ReadKey();
            switch(readKey.Key)
            {
                case ConsoleKey.Z:
                case ConsoleKey.Q:
                case ConsoleKey.D:
                case ConsoleKey.S:
                    FunctionMove(readKey.Key);
                    break;
                default:
                    DefaultFunction(readKey.Key);
                    break;
            }

            int moisInt = HelperRead.ReadIntMinMax(1, 12, "Tapez un mois entre 1 et 12");
            Mois mois = (Mois)(moisInt);
            switch(mois)
            {
                case Mois.Decembre:
                case Mois.Janvier:
                case Mois.Fevrier:
                    DisplaySeason(mois, Season.Hiver);
                    break;
                case Mois.Mars:
                case Mois.Avril:
                case Mois.Mai:
                    DisplaySeason(mois, Season.Printemps);
                    break;
            }

            // passer d'une string à une enum
            string monthLabel = "Janvier";
            mois = (Mois)Enum.Parse(typeof(Mois), monthLabel);
            Console.WriteLine("passer d'une string à une enum : " + mois);

            // passer d'une enum à une string
            string season = Enum.GetName(typeof(Season), Season.Printemps);
            Console.WriteLine("passer d'une enum à une string : " + season);

            // Recupérer toutes les valeurs d'une enum
            Mois[] allMonth = (Mois[])Enum.GetValues(typeof(Mois));
            Console.WriteLine("Recupérer toutes les valeurs d'une enum : ");
            for(int i = 0; i < allMonth.Length; i++)
            {
                Console.WriteLine(allMonth[i]);
                Console.WriteLine((int)allMonth[i]);
            }


            TestEnum monObjectRoger = new TestEnum();
            monObjectRoger.maPropriete = 25;
            TestEnum monObjectRoger2 = new TestEnum();

            TestEnum.MyFunctionStatic();
            TestEnum.maVariableStatic = 10;
        }

        private static void FunctionMove(ConsoleKey key)
        {
            Console.WriteLine("coucou " + key);
        }

        private static void DefaultFunction(ConsoleKey key)
        {
            Console.WriteLine("default " + key);
        }

        private static void DisplaySeason(Mois month, Season season)
        {
            Console.WriteLine("Le mois " + month + " est dans la saison " + season);
        }
    }
}
