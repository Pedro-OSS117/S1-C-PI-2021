using System;

namespace LeSnake
{

    class Program
    {
        public static Grid myGrid;
        
        static void Main(string[] args)
        {
            Grid newGrid = new Grid(10, 10);
            Player player = new Player(newGrid.GetGridCenter());

            ConsoleKey key = ConsoleKey.A;

            //newGrid.GenerateLoot(player.GetPosition(), 10);
            newGrid.GenerateLoot();
            newGrid.GenerateLoot();
            newGrid.SetCharInGrid(player.GetPosition(), player.GetPlayerSkin());
            Console.WriteLine(newGrid);
            while(key != ConsoleKey.Q)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Recuperation de l'input
                Point positionToAdd = new Point(0,0);
                key = keyInfo.Key;
                switch(key)
                {
                    case ConsoleKey.RightArrow:
                        positionToAdd.x += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        positionToAdd.x -= 1;
                        break;
                    case ConsoleKey.UpArrow:
                        positionToAdd.y -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        positionToAdd.y += 1;
                        break;
                }

                // Tester si la nouvelle position est dans la grille
                Point positionPlayer = player.GetPosition();
                Point newPosition = new Point(positionToAdd.x + positionPlayer.x, positionToAdd.y + positionPlayer.y);
                if(newGrid.IsPointInGrid(newPosition.x, newPosition.y))
                {
                    Console.Clear();
                    
                    if(newGrid.ThereIsALoot(newPosition))
                    {
                        Console.WriteLine("Il y a une loot à la position : " + newPosition);
                    }

                    // effacer l'ancienne pos du player dans la grille
                    newGrid.ClearCharInGrid(positionPlayer);

                    // Translater le player
                    player.Translate(positionToAdd);

                    // ajouter la nouvelle position du player dans la grille
                    newGrid.SetCharInGrid(player.GetPosition(), player.GetPlayerSkin());

                    // reafficher la grille
                    Console.WriteLine(newGrid);
                }
            }
        }
    }
}
