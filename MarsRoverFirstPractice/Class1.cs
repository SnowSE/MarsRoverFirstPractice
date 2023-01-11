using System.Drawing;

namespace MarsRoverFirstPractice
{
    public class Class1

    {

        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }
        public char[,] Map { get; set; }

        public Class1(int x, int y, char direction, char[,] map)
        {
            X = x;
            Y = y;
            Direction = direction;
            Map = map;
        }
        public void simulateRover(char directionCommand)
        {

               switch (directionCommand)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                     case 'U':
                    if (!MoveForward())
                    {
                        Console.WriteLine("Opps obstacle at: ({0}, {1})", X, Y);
                        return;
                    }
                    break;
               
            }
            
        }

        private void TurnLeft()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'W';
                    break;
                case 'E':
                    Direction = 'N';
                    break;
                case 'S':
                    Direction = 'E';
                    break;
                case 'W':
                    Direction = 'S';
                    break;
            }
        }

        private void TurnRight()
        {
            switch (Direction)
            {
                case 'N':
                    Direction = 'E';
                    break;
                case 'E':
                    Direction = 'S';
                    break;
                case 'S':
                    Direction = 'W';
                    break;
                case 'W':
                    Direction = 'N';
                    break;
            }
        }

        private bool MoveForward()
        {
            int newX = X;
            int newY = Y;
            switch (Direction)
            {
                case 'N':
                    newY--;
                    break;
                case 'E':
                    newX++;
                    break;
                case 'S':
                    newY++;
                    break;
                case 'W':
                    newX--;
                    break;
            }
            if (newX < 0 || newX >= Map.GetLength(1) || newY < 0 || newY >= Map.GetLength(0) || Map[newY, newX] == '#')
            {               
                return false;
            }
            X = newX;
            Y = newY;
            return true;
        }
    }


}
                                                                                                     