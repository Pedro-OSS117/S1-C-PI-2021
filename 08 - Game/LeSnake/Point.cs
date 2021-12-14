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

        public override bool Equals(object obj)
        {
            Point toTest = (Point)obj;
            return x == toTest.x && y == toTest.y;
        }
    }
}