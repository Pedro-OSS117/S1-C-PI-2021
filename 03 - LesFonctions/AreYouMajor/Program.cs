using System;

namespace AreYouMajor
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Quelle est votre année de naissance ?");
            int dateDonnee = int.Parse(Console.ReadLine());
            
            if(DetermineMajorite(CalculeAge(dateDonnee)))
            {
                Console.WriteLine("Vous êtes majeur !");
            }
            else
            {                
                Console.WriteLine("Vous n'êtes pas majeur !");
            }
        }

        static int CalculeAge(int naisssanceDate)
        {
            return DateTime.Today.Year - naisssanceDate;
        }

        static bool DetermineMajorite(int age)
        {
            return age >= 18;
        }
    }
}
