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
}