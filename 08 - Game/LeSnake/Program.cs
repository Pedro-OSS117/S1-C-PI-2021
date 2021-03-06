using System;
using System.Threading;

namespace LeSnake
{

    class Program
    {

        static void Main(string[] args)
        {

            int timeNextLootGenerated = 5000;
            ConsoleKey key = ConsoleKey.RightArrow;
            while(key != ConsoleKey.Q)
            {
                Grid newGrid = new Grid(10, 10);
                Player player = new Player(newGrid.GetGridCenter());

                newGrid.SetCharsInGrid(player.GetPosition(), player.GetPlayerSkin());
                Console.WriteLine(newGrid);

                int currentTimeBeforeNextLoot = 0;
                int sleepValue = 233;
                //Timer timerLoot = new Timer(GenerateLoot, null, 0, 5000);
                while(key != ConsoleKey.Q)
                {
                    Thread.Sleep(sleepValue);
                    if(Console.KeyAvailable) 
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        key = keyInfo.Key;
                    }
                    
                    currentTimeBeforeNextLoot += sleepValue;
                    if(currentTimeBeforeNextLoot >= timeNextLootGenerated)
                    {
                        newGrid.GenerateLoot();
                        currentTimeBeforeNextLoot = 0;
                    }

                    // Recuperation de l'input
                    Point positionToAdd = new Point(0,0);
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
                    Point positionPlayer = player.GetHeadPosition();
                    Point newPosition = new Point(positionToAdd.x + positionPlayer.x, positionToAdd.y + positionPlayer.y);
                    if(newGrid.IsPointInGrid(newPosition.x, newPosition.y) &&  !player.IsPointInTail((newPosition)))
                    {
                        Console.Clear();
                        
                        if(newGrid.ThereIsALoot(newPosition))
                        {
                            // Ajouter position à la tête
                            player.Grown(newPosition);
                        }
                        else
                        {
                            // effacer l'ancienne pos du player dans la grille
                            newGrid.ClearCharInGrid(player.GetTailPosition());

                            // Translater le player
                            player.Translate(positionToAdd);
                        }

                        // ajouter la nouvelle position du player dans la grille
                        newGrid.SetCharsInGrid(player.GetPosition(), player.GetPlayerSkin());

                        // reafficher la grille
                        Console.WriteLine(newGrid);
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("YOUR SCORE : " + player.GetPosition().Length * 100);
                Thread.Sleep(1000);
            }
        }
    }
}
