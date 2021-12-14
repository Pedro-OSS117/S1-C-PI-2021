namespace LeSnake
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "{" + this.x + "," + this.y + "}";
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.x == b.x && a.y == b.y;
        }
        
        public static bool operator !=(Point a, Point b)
        {
            return a.x != b.x || a.y != b.y;
        }
    }
}