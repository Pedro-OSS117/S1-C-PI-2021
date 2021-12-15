using System;

namespace LeSnake
{
    public struct Grid
    {
        private char[] grid;
        private int width, height;
        private static char empty = ' ';
        private static char limitSideBorder = '|';
        private static char limitTopBottomBorder = '-';
        private static char skinLoot = 'X';

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;

            grid = new char[width*height];
            InitGrid();
            //InitGridForTest();
        }

        private void InitGrid()
        {
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = empty;
            }
        }

        private void InitGridForTest()
        {
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = '*';
            }

            grid[width - 1] = 'V';
            grid[width + width / 2] = 'J';
            grid[grid.Length - 1] = 'E';

            // Ajouter un caracter au centre de la grille
            SetCharInGrid(width / 2, height / 2, 'O');
            // Test limits
            SetCharInGrid(0, 0, 'X');
            SetCharInGrid(0, height - 1, 'X');
            SetCharInGrid(width - 1, 0, 'X');
            SetCharInGrid(width - 1, height - 1, 'X');
        }

        private int GetIndexFromPosition(int x, int y)
        {
            if(x >= 0 && x < width && y >= 0 && y < height)
            {
                return x + width * y;
            }
            return -1;
        }

        public bool IsPointInGrid(int x, int y)
        {
            return GetIndexFromPosition(x, y) != -1;
        }

        public void SetCharInGrid(int x, int y, char newChar)
        {
            int index = GetIndexFromPosition(x, y);
            if(index != -1)
            {
                grid[index] = newChar;
            }
        }

        public void SetCharsInGrid(Point[] positions, char newChar)
        {
            for(int i = 0; i < positions.Length; i++)
            {
                SetCharInGrid(positions[i], newChar);
            }
        }

        public void SetCharInGrid(Point position, char newChar)
        {
            SetCharInGrid(position.x, position.y, newChar);
        }

        public void ClearCharInGrid(Point position)
        {
            SetCharInGrid(position.x, position.y, empty);
        }

        public Point GetGridCenter()
        {
            return new Point(width / 2, height / 2);
        }

        public static void ChangeSkin(char newLimitSideBorder)
        {
            limitSideBorder = newLimitSideBorder;
        }

        #region LOOT
        public void GenerateLoot()
        {
            Random rand = new Random();
            Point positionRand = new Point();
            positionRand.x = rand.Next(0, width);
            positionRand.y = rand.Next(0, height);
            SetCharInGrid(positionRand, skinLoot);
        }

        public bool ThereIsALoot(Point positionToTest)
        {
            int index = GetIndexFromPosition(positionToTest.x, positionToTest.y);
            if(index != -1)
            {
                return grid[index] == skinLoot;
            }
            return false;
        }

        public void GenerateLoot(Point positionToSkip, int nbrToGenerate)
        {
            // Initialisation d'un tableau avec le nombre de
            // position possible - la position player
            Point[] positionsValid = new Point[grid.Length - 1];
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if(positionToSkip.x != i && positionToSkip.y != j)
                    {
                        positionsValid[i * j] = new Point(i,j);
                    }
                }
            }

            Console.WriteLine(positionsValid.Length);
            Random rand = new Random();
            for(int i = 0; i < nbrToGenerate; i++)
            {
                int indexRand = rand.Next(0, positionsValid.Length);
                Point choosenOne = positionsValid[indexRand];
                SetCharInGrid(choosenOne, skinLoot);
                
                Point[] newPositionsValid = new Point[positionsValid.Length - 1];
                for(int j = 0; j < indexRand; j++)
                {
                    newPositionsValid[j] = positionsValid[j];
                }

                for(int j = indexRand; j < newPositionsValid.Length; j++)
                {
                    newPositionsValid[j] = positionsValid[j + 1];
                }

                positionsValid = newPositionsValid;
                
                Console.WriteLine(positionsValid.Length);
            }
        }
        #endregion LOOT
        
        #region DISPLAY GRID
        public override string ToString()
        {
            string toDisplay = DisplayTopBottomLine();
            toDisplay += DisplayCenterLines();
            toDisplay += DisplayTopBottomLine();
            return toDisplay;
        }

        private string DisplayCenterLines()
        {
            string toDisplay = "";
            for(int j = 0; j < height; j++)
            {
                toDisplay += limitSideBorder;
                int preCalcul = j * width;
                for(int i = 0; i < width; i++)
                {
                    toDisplay += empty.ToString() + grid[preCalcul + i] + empty;
                }
                toDisplay += limitSideBorder + "\n";
            }
            return toDisplay;
        }

        private string DisplayTopBottomLine()
        {
            string toDisplay = " ";
            for(int i = 0; i < width; i++)
            {
                toDisplay += limitTopBottomBorder.ToString() + limitTopBottomBorder + limitTopBottomBorder;
            }
            toDisplay += " \n";
            return toDisplay;
        }
        #endregion DISPLAY GRID
    }
}