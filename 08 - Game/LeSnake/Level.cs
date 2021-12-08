namespace LeSnake
{
    public struct Grid
    {
        private char[] grid;
        private int width, height;

        private static char empty = ' ';
        private static char limitSideBorder = '|';
        private static char limitTopBottomBorder = '-';

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

        public void SetCharInGrid(int x, int y, char newChar)
        {
            int index = GetIndexFromPosition(x, y);
            if(index != -1)
            {
                grid[index] = newChar;
            }
        }

        public static void ChangeSkin(char newLimitSideBorder)
        {
            limitSideBorder = newLimitSideBorder;
        }
        
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