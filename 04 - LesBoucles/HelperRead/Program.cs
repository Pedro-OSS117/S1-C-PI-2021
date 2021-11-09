using System;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valueUser = HelperRead.ReadInt();
            Console.WriteLine("La valeur entrée par l'utilisateur est : " + valueUser);
            valueUser = HelperRead.ReadInt("Bonjour mon petit ami, si tu rentres une valeur, tu auras une sucette : ");
            Console.WriteLine("La valeur entrée par l'utilisateur est : " + valueUser);*/

            HelperRead.ReadIntMinMax(1, 4);
        }
    }
}
