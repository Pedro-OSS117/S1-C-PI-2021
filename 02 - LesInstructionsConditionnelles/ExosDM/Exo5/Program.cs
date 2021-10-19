using System;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir un mois pour obtenir une saison :");
            string month = Console.ReadLine();

            month = month.Replace('é', 'e');
            month = month.Replace('à', 'a');
            month = month.Replace('è', 'e');

            // Transforme le mot en minuscule
            month = month.ToLower();

            Console.WriteLine(month);
            
            switch(month)
            {
                case "janvier":
                case "fevrier":
                case "mars":
                Console.WriteLine("Hiver");
                break;
                
                case "avril":
                case "mai":
                case "juin":
                Console.WriteLine("Printemps");
                break;
                default:
                Console.WriteLine("Ce n'est pas un mois");
                break;

            }

            // Les premiers cas du switch en version if
            if(month == "janvier" || month == "fevrier" || month == "mars")
            {

            }
        }
    }
}
