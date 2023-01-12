using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace MarsRoverFirstPractice
{
    public class MarsRover
    {
         static public (Point, string) simulateRover(string map, string directionCommands)
        {
            var north = "⬆️";
            var south = "⬇️";
            var east = "➡️";
            var west = "⬅️";

            //if (directionCommands == "")
            //    throw new Exception("Direction commands are empty");

            var mapArray = map.Split(" ");
            var direction = mapArray[0];
            var position = new Point(0, 0);
            List<Point> obstacles = new List<Point>();

            int gridSize = (int)Math.Sqrt(mapArray.Length);

            for (int i = 1; i < mapArray.Length; i++)
            {
                if (mapArray[i] == "X")
                {
                    obstacles.Add(new Point(i % gridSize, i / gridSize));
                }
            }

            var directionCommandsArray = directionCommands.Split(" ");
            foreach (var directionCommand in directionCommandsArray)
            {
                var previousPostion = position;
                if (directionCommand == "F")
                {
                    if (direction == north)
                        position.Y += 1;
                    else if (direction == south)
                        position.Y -= 1;
                    else if (direction == east)
                        position.X += 1;
                    else if (direction == west)
                        position.X -= 1;
                }
                else if (directionCommand == "B")
                {
                    if (direction == north)
                        position.Y -= 1;
                    else if (direction == south)
                        position.Y += 1;
                    else if (direction == east)
                        position.X -= 1;
                    else if (direction == west)
                        position.X += 1;
                }
                else if (directionCommand == "L")
                {
                    if (direction == north)
                        direction = west;
                    else if (direction == south)
                        direction = east;
                    else if (direction == east)
                        direction = north;
                    else if (direction == west)
                        direction = south;
                }
                else if (directionCommand == "R")
                {
                    if (direction == north)
                        direction = east;
                    else if (direction == south)
                        direction = west;
                    else if (direction == east)
                        direction = south;
                    else if (direction == west)
                        direction = north;
                }

                //obstacle check
                if (obstacles.Contains(position))
                {
                    position = previousPostion;
                }

                //out of bounds check(remain in position if try leave map)
                if (position.X < 0 || position.X > gridSize || position.Y < 0 || position.Y > gridSize)
                {
                    position = previousPostion;
                }
            }           
            return (position, direction);
        }       
    }
}