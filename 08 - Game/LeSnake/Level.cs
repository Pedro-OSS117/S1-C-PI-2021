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
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = '*';
            }

            grid[grid.Length / 2] = 'X';
            grid[width - 1] = 'V';
            grid[width + width / 2] = 'J';
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
                for(int i = 0; i < width; i++)
                {
                    toDisplay += empty.ToString() + grid[j * width + i] + empty;
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