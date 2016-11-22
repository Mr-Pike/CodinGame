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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string result = "";
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            
            for (int j = 0; j < T.Length; j++) 
			{
                int num = CharToNumber(T[j]);
                result += ROW.Substring(num*L, L);
            }
            
            result += Environment.NewLine;
        }

        Console.WriteLine(result);
    }
    
    public static int CharToNumber(char c)
    {
        if (c >= 'a' && c <= 'z') 
            return c - 'a';
        else if(c >= 'A' && c <= 'Z') 
            return c - 'A';
        else 
            return 'Z' - 'A' + 1;
    }
}