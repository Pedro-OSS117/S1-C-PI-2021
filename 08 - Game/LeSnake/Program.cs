using System;

namespace LeSnake
{

    class Program
    {
        public static Grid myGrid;
        
        static void Main(string[] args)
        {
            Grid newGrid = new Grid(10, 10);
            Console.WriteLine(newGrid);
        }
    }
}
