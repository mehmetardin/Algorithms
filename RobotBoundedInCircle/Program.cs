using System;

namespace RobotBoundedInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(IsRobotBounded2("GLRLGLLGLGRGLGL")); //false
        }

//does not work
     public static bool IsRobotBounded(string instructions) {
        
          //1:North, 2:South, 3:West, 4:East
        int x = 0;
        int y = 0;
        var direction = 1;
        var z = 0;
        
        for(int i = 0; i< instructions.Length; i++)
        {
            

            var move = instructions[i];
            if( move == 'G' )
            {
                z++;
                if(direction == 1 )
                    y++;
                else if(direction == 2 )
                    y--;
                else if(direction == 3 )
                    x--;
                else if(direction == 4 )
                    x++;
                    
            }
            else if(move == 'L')
                direction = direction == 1 ? 3 : direction - 1;
            else if(move == 'R')
                direction = direction == 3 ? 1 : direction + 1;

                if(x==0 & y == 0)
                    z = 0;
        }

        return (x == 0 && y == 0) || direction != 1;
            
    }

//does not work
    public static bool IsRobotBounded1(string instructions) {
        
          //1:North, 2:South, 3:West, 4:East
        int x = 0;
        int y = 0;
        int dx = 0;
        int dy = 1;
        
        for(int i = 0; i< instructions.Length; i++)
        {
            var move = instructions[i];
            if( move == 'G' )
            {
               x += dx;
               y += dy;
                    
            }
            else if(move == 'L')
            {
                var temp = dy;
                dy = dx;
                dx = -temp;
            }
            else if(move == 'R')
            {
                var temp = dy;
                dx = dy;
                dy = -temp;
            }
        }
        return x == 0 && y == 0 || dy != 1;
    }

    public static bool IsRobotBounded2(string instructions)
    {
          // north = 0, east = 1, south = 2, west = 3
        int[][] directions = new int[][]{new int[]{0, 1}, new int[]{1, 0}, new int[]{0, -1}, new int[]{-1, 0}};
        // Initial position is in the center
        int x = 0, y = 0;
        // facing north
        int faceDirection = 0;
        
        foreach (var i in instructions) 
        {
            if (i == 'L')
                faceDirection = (faceDirection + 3) % 4;
            else if (i == 'R')
                faceDirection = (faceDirection + 1) % 4;
            else {
                x += directions[faceDirection][0];
                y += directions[faceDirection][1];   
            }    
        }
        
        // after one cycle:
        // robot returns into initial position
        // or robot doesn't face north
        return (x == 0 && y == 0) || (faceDirection != 0);
    }
    }
}
