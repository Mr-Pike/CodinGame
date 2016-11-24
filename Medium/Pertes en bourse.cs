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
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] values = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
        
        int delta = 0;
        int value = values[0];
        for (int i = 1; i < n; i++) 
        {
            int actualDelta = values[i] - value;
            if (actualDelta < 0 && actualDelta < delta)
                delta = actualDelta;
            else if (actualDelta > 0)
                value = values[i];
        }

        Console.WriteLine(delta);
    }
}