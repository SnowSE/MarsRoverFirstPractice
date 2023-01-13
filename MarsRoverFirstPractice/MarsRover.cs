using System;

namespace MarsRoverFirstPractice
{
    public class MarsRover
    {
        public int x;
        public int y;
        public string direction;
        public int obsticaleX, obsticaleY;
        public MarsRover(string location)
        {
            int.TryParse(location.Split(" ")[0], out x);
            int.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }
        public void RotateLeft()
        {
            switch(direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void RotateRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void MoveForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void Obsticale(string obsticaleLocation)
        {
            
            int.TryParse(obsticaleLocation.Split(" ")[0], out obsticaleX);
            int.TryParse(obsticaleLocation.Split(" ")[1], out obsticaleY);
        }
        public void Move(string moveRoverCommands)
        {
            char[] instructions = moveRoverCommands.ToCharArray();

            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'F':
                        if (x + 1 == obsticaleX || x - 1 == obsticaleX || y + 1 == obsticaleY || y - 1 == obsticaleY)
                        {
                            break;
                        }
                        else
                        {
                            MoveForward();
                            break;
                        }
                        /*MoveForward();
                        break;*/
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}