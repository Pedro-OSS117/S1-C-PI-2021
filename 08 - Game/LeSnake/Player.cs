namespace LeSnake
{
    public struct Player
    {
        private Point position;

        private char skin;

        public Player(Point position, char skin = 'O')
        {
            this.position = position;
            this.skin = skin;
        }

        public Player(int x, int y, char skin = 'O')
        {
            position = new Point(x, y);
            this.skin = skin;
        }

        public Point GetPosition()
        {
            return position;
        }

        public void SetPosition(Point newVector)
        {
            position = newVector;
        }

        public char GetPlayerSkin()
        {
            return skin;
        }

        public void Translate(Point posToAdd)
        {
            position.x += posToAdd.x;
            position.y += posToAdd.y;
        }
    }
}