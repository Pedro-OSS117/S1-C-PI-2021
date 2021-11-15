using System;

class HelperRead
{
    public static int ReadInt(string message = "Entrez une valeur entière : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur entière : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        int value = 0;

        while(!int.TryParse(saisie, out value))
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }

    public static float ReadFloat(string message = "Entrez une valeur à virgule : ")
    {
        if(string.IsNullOrWhiteSpace(message))
        {
            message = "Entrez une valeur à virgule : ";
        }

        Console.WriteLine(message);
        string saisie = Console.ReadLine();
        
        float value = 0;

        while(!float.TryParse(saisie, out value))
        {
            Console.WriteLine("Erreur de saisie !");
            Console.WriteLine(message);
            saisie = Console.ReadLine();
        }
        
        return value;
    }

    public static int ReadIntMinMax(int min, int max, string message = "")
    {
        if(string.IsNullOrEmpty(message))
        {
            message = "Entrer une valeur entre " + min + " et " + max;
        }
        
        int value = 0;

        
        bool isNotValid = true;
        // La boucle do while est utile si
        // On veut passer au moins une fois dans la boucle
        do
        {
            // On recupere une valeur entière
            value = ReadInt(message);

            isNotValid = value < min || value > max;
            
            if(isNotValid)
            {
                Console.WriteLine("Valeur pas dans l'interval : [" + min + "," + max + "]" );
            }

        } while(isNotValid);

        return value;
    }

    public static float ReadFloatMinMax(float min, float max, string message)
    {
        float value = 0;

        // La boucle do while est utile si
        // On veut passer au moins une fois dans la boucle
        do
        {
            // On recupere une valeur entière
            value = ReadFloat(message);

        } while(value < min || value > max);

        return value;
    }
    
}