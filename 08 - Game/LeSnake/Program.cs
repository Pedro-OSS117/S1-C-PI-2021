using System;

namespace LeSnake
{

    class Program
    {
        public static Grid myGrid;
        
        static void Main(string[] args)
        {
            Grid newGrid = new Grid(10, 10);
            newGrid.SetCharInGrid(14, 12, 'v');
            newGrid.SetCharInGrid(5, 8, 'j');
            newGrid.SetCharInGrid(2, 3, 's');

            Console.WriteLine(newGrid);
        }
    }
}
