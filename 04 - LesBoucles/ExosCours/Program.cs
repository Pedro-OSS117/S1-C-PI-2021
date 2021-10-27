using System;

namespace ExosCours
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAllNumbers(5);
            DisplayAllNumbers(5);
            DisplayAllNumbersWithFor(4);
        }

        /**
        Exo cours 1 : 
        Creer une fonction 'DisplayAllNumbers' qui prend en paramètre 
        un int et affiche tous les nombres de 0 au nombre passé en paramètre
        Ex resultat si 4 est passé en paramètre :
        */
        static void DisplayAllNumbers(int number)
        {
            Console.WriteLine("Loop While Display numbers." );
            int i = 0;
            while(number >= i)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void DisplayAllNumbersWithFor(int number)
        {
            Console.WriteLine("Loop For Display numbers." );
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }

        /**
        Exo cours 2 :
            Creer une fonction 'DisplayBy3' qui prend en paramètre un int et affiche tous les nombres de 0 au nombre passé en paramètre tous les 3 nombres
            Ex resultat si 7 est passé en paramètre :
            0 
            3
            6
        */
        static void DisplayBy3(int number)
        {
            for(int i = 0; i < number; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            // Version optimisé
            for(int j = 0; j < number; j += 3)
            {
                Console.WriteLine(j);
            }
        }

        /**
        Exo cours 3 :
            Creer une fonction 'IsPairOrImpair' qui prend en paramètre un int.
            La fonction doit afficher les nombres de 1 au nombre passé en paramètre et afficher s'ils sont pair ou impair
            Ex : 4 est passé en paramètre. Le programme affiche : 
            1 est impair
            2 est pair
            3 est impair
            4 est pair

            faire une version avec la boucle for et une version avec la boucle while                                                                                
        */
        static void IsPairOrImpair(int number)
        {
            Console.WriteLine("Loop For Display numbers." );
            for(int i = 0; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i + " Pair");
                }
                else
                {
                    Console.WriteLine(i + " Impair");
                }
            }
        }
    }
}
