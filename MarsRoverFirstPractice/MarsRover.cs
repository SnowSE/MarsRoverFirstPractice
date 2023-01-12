using System.Drawing;

namespace MarsRoverFirstPractice
{
    public class MarsRover
    {
         static public (Point,String) simulateRover(String map, String directionCommands)
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
            
            var directionCommandsArray = directionCommands.Split(" ");

            foreach (var directionCommand in directionCommandsArray)
            {
                
                if (directionCommand == "F")
                {
                    if (direction == north && mapArray[1] != "X")
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
                
                

            }

            
            return (position, direction);
        }
        
        
    }
}