using System.Drawing;

namespace MarsRoverFirstPractice
{
    public class Class1
    {
         static public (Point,char) simulateRover( string map, string directionCommands)
        {
            var size = Convert.ToInt32(Math.Sqrt(map.Length));
            
            var index = 0;
           
            var currentPosition = new Point();
            var direction = ' ';

            char[,] marsMap = new char[size, size];


            for (int x = 0; x < size; x++)
            {
                for(int y = 0; y < size; y++)
                {
                    marsMap[x, y] = map[index];
                    if(marsMap[x,y] != 'O' && marsMap[x,y]!= 'X')
                    {
                        currentPosition.X = x;
                        currentPosition.Y = y;
                        direction = marsMap[x,y];
                    }
                    index += 1;
                }
            }

            for (int i = 0; i < directionCommands.Length; i++)
            {

                if(directionCommands[i] == 'F')
                {
                    if (direction == 'N')
                    {
                        if (currentPosition.X - 1 < 0) { continue; }
                        if (marsMap[currentPosition.X-1, currentPosition.Y] == 'X') { }
                        else { currentPosition.X = currentPosition.X - 1; }
                        continue;
                    }
                    if (direction == 'E')
                    {
                        if (currentPosition.Y + 1 >= size) { continue; }
                        if (marsMap[currentPosition.X, currentPosition.Y+1] == 'X') { }
                        else { currentPosition.Y = currentPosition.Y + 1; }
                        continue;
                    }
                    if (direction == 'W')
                    {
                        if (currentPosition.Y - 1 <0) { continue; }
                        if (marsMap[currentPosition.X, currentPosition.Y - 1] == 'X') { }
                        else { currentPosition.Y = currentPosition.Y - 1; }
                        continue;
                    }
                    if (direction == 'S')
                    {
                        if (currentPosition.X + 1 >=size) { continue; }
                        if (marsMap[currentPosition.X + 1, currentPosition.Y] == 'X') { }
                        else { currentPosition.X = currentPosition.X + 1; }
                        continue;
                    }
                }

                else
                {
                    if (directionCommands[i] == 'L')
                    {
                        switch (direction)
                        {
                            case 'N': direction = 'W'; break;  
                            case 'E': direction = 'N'; break;  
                            case 'S': direction = 'E'; break;  
                            case 'W': direction = 'S'; break;  
                        }
                    }
                    if (directionCommands[i] == 'R')
                    {
                        switch (direction)
                        {
                            case 'N': direction = 'E'; break;
                            case 'E': direction = 'S'; break;
                            case 'S': direction = 'W'; break;
                            case 'W': direction = 'N'; break;
                        }
                    }
                }
            }

            return (currentPosition, direction);

        }
    }
}