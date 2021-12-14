namespace LeSnake
{
    public struct Player
    {
        private Point[] positions;

        private char skin;

        public Player(Point position, char skin = 'O')
        {
            // Init position initiale
            positions = new Point[3];
            positions[0] = position;            
            positions[1] = new Point(position.x - 1, position.y);
            positions[2] = new Point(position.x - 2, position.y);

            // Ajout de deux positions en plus sur la gauche
            this.skin = skin;
        }

        public Player(int x, int y, char skin = 'O')
        {
            // Init position initiale
            positions = new Point[3];
            positions[0] = new Point(x, y);            
            positions[1] = new Point(x - 1, y);
            positions[2] = new Point(x - 2, y);
            this.skin = skin;
        }

        public Point[] GetPosition()
        {
            return positions;
        }

        public Point GetHeadPosition()
        {
            return positions[0];
        }

        public Point GetTailPosition()
        {
            return positions[positions.Length - 1];
        }

        public void SetPosition(Point[] newVector)
        {
            positions = newVector;
        }

        public char GetPlayerSkin()
        {
            return skin;
        }

        public void Translate(Point posToAdd)
        {            
            // On décale toutes les positions
            for(int i = positions.Length - 2; i >= 0; i--)
            {
                positions[i + 1] = positions[i]; 
            }
            
            positions[0].x += posToAdd.x;
            positions[0].y += posToAdd.y;
        }

        public void Grown(Point newHead)
        {
            // Initialiser un nouveau tableau  de taille positions.lenth + 1
            Point[] newPositions = new Point[positions.Length + 1];

            // Transferer les positions du tableau positions dans le nouveau tableau
            // de 1 à la taille du nouveau tableau
            for(int i = 1; i < newPositions.Length; i++)
            {
                newPositions[i] = positions[i - 1];
            }

            // Et mettre la valeur de la nouvelle tête à la position 0 du tableau
            newPositions[0] = newHead;

            positions = newPositions;
        }

        public bool IsPointInTail(Point testPos)
        {
            for(int i = 0; i < positions.Length; i++)
            {
                if(positions[i] == testPos)
                //if(testPos.x == positions[i].x && testPos.y == positions[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}