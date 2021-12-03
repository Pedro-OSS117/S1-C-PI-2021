using System;

namespace Cours
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * Declaration et intialisation
             * Variable de type MaPremiereStructure
             */
            MaPremiereStructure mps = new MaPremiereStructure();
            MaPremiereStructure mps2 = new MaPremiereStructure(12);
            MaPremiereStructure mps3 = mps2;
            MaPremiereStructure mps4 = new MaPremiereStructure(1 , 25, ConsoleKey.A);

            Console.WriteLine(mps.message);
            Console.WriteLine(mps3.message);

            // Appelle de fonction non static ou methode
            // par une variable ou instance de type MaPremiereStructure
            int sum1 = mps.GetSumValue();
            int sum3 = mps3.GetSumValue();
            int sum4 = mps4.GetSumValue();
            Console.WriteLine(sum1);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);

            // Appelle de fonction static au travers de la structure
            MaPremiereStructure.SetGlobalValue(10);

            sum1 = mps.GetSumValue();
            sum3 = mps3.GetSumValue();
            sum4 = mps4.GetSumValue();
            
            Console.WriteLine(sum1);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);

            // Accès a une variable static de la structure
            MaPremiereStructure.mapPropStatic2 = 15;

            // Il y a copie lorsqu'on passe une structure en parametre
            Console.WriteLine(mps3.message);
            ChangeMessageStruct(mps3);
            Console.WriteLine(mps3.message);

            // Surcharge de ToString();
            Console.WriteLine(mps.ToString());
            Console.WriteLine(mps3);
            Console.WriteLine(mps2);
            Console.WriteLine(mps4);
        }

        public static string ChangeMessageStruct(MaPremiereStructure mps)
        {
            mps.message = "bonjour";
            Console.WriteLine(mps.message);
            return mps.message;
        }
    }
}
