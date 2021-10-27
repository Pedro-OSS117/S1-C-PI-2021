using System;

namespace TestBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boucle de base avec incrementation
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("valeur de l'index : " + i);
            }

            // Boucle de base avec decrementation
            for(int i = 20; i >= 0; i--)
            {
                Console.WriteLine("valeur de l'index : " + i);
            }
            
            for(int i = 20; i >= 0 && i <= 20; i -= 2)
            {
                Console.WriteLine("valeur de l'index : " + i);
            }
            
            // Variable de l'index initialisé à l'exterieur
            int j;
            for(j = 25; j < 999; j += 25)
            {
                Console.WriteLine("valeur de l'index : " + j);
            }
            Console.WriteLine("valeur à la fin de l'index : " + j);

            //// While
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine(" while Play ! " + counter);
                counter++;
            }

            /// Do While
            counter = 0;
            do
            {
                Console.WriteLine("Do While Play ! " + counter);
                counter++;
            } while(counter < 5);


            // Boucle infinie            
            /*for(;;)
            {
                
            }*/

            /*while(true)
            {

            }*/
            // Boucle infinie
            /*for(int i = 0; i >= 0; i++)
            {
                Console.WriteLine("valeur de l'index : " + i);
            }*/
        }
    }
}
