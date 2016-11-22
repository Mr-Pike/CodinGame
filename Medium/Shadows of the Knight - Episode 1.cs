using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        
        int minX = 0;
        int maxX = W;
        int minY = 0;
        int maxY = H;
        int posX = 0;
        int posY = 0;

        // game loop
        while (true)
        {
            while(N >= 0)
            {
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
                posX = 0;
                posY = 0;
                
                // Switch the direction of the bomb.
                switch(bombDir)
                {
                    case "U":
                        posY = -1;
                        break;
                    case "UR":
                        posX = 1;
                        posY = -1;
                        break;
                    case "R":
                        posX = 1;
                        break;
                    case "DR":
                        posX = 1;
                        posY = 1;
                        break;
                    case "D":
                        posY = 1;
                        break;
                    case "DL":
                        posX = -1;
                        posY = 1;
                        break;
                    case "L":
                        posX = -1;
                        break;
                    case "UL":
                        posX = -1;
                        posY = -1;
                        break;
                }
                
                // Determine position.
                if (posX > 0)
                    minX = X0;
                if (posX < 0)
                    maxX = X0;
                if (posY > 0)
                    minY = Y0;
                if (posY < 0)
                    maxY = Y0;
                
                // Update position.
                if (posX != 0)
                    X0 = (int)((maxX + minX) / 2);
                if (posY != 0)
                    Y0 = (int)((maxY + minY) / 2);
                
                // The location of the next window Batman should jump to.
                Console.WriteLine("{0} {1}", X0, Y0);
                
                // Loose 1 try.
                N--;
            }
        }
    }
}