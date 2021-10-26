using System;

namespace UseReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appel Calcule moyenne
            float moyenne = MyMath.CalculeMoyenne(54, 8);
            Console.WriteLine("la moyenne est de : " + moyenne);
            Console.WriteLine("la moyenne est de : " +  MyMath.CalculeMoyenne(1500.53f, 80));

            // Appel Calcule surface rectangle
            Console.WriteLine("la surface est de : " +  MyMath.CalculeSurface(12, 50));
            Console.WriteLine("la surface est de : " +  MyMath.CalculeSurface(6, 10));

            // Appel Produit en croix            
            Console.WriteLine("le pourcentage est de : " +  MyMath.CalculatePercent(12, 50) + "%");
            Console.WriteLine("le pourcentage est de : " +  MyMath.CalculatePercent(6, 10) + "%");
        }
    }
}
