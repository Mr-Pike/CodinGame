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
        int W = int.Parse(inputs[0]); // number of columns.
        int H = int.Parse(inputs[1]); // number of rows.
        int[,] Tunnel = new int[H, W]; // Grid. 
        for (int i = 0; i < H; i++)
        {
            int[] LINE = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray(); // represents a line in the grid and contains W integers. Each integer represents one room of a given type.
            for (int j = 0; j < W; j++)
                Tunnel[i, j] = LINE[j];
        }
        int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int XI = int.Parse(inputs[0]);
            int YI = int.Parse(inputs[1]);
            string POS = inputs[2];
            
            switch (Tunnel[YI,XI])
            {
                case 1:
                case 3:
                case 7:
                case 8:
                case 9:
                case 12:
                case 13:    
                    YI++;
                    break;
                case 2:
                case 6:
                    if (POS == "LEFT") 
                        XI++;
                    else
                        XI--;
                    break;
                case 4:
                    if (POS == "TOP") 
                        XI--;
                    else 
                        YI++;
                    break;
                case 5:
                    if (POS == "TOP")
                        XI++;
                    else
                        YI++;
                    break;
                case 10:
                    XI--;
                    break;
                case 11:
                    XI++;
                    break;
                default:
                    // Impossible case.
                    break;
            }
            
            // Show the result.
            Console.WriteLine("{0} {1}", XI, YI);
        }
    }
}