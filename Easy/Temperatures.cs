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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        string[] temperatures = temps.Split(' ');
        int result = 0;
        
        if(n > 0) 
        {
            result = int.Parse(temperatures[0]);
            for(int i = 1; i < n; i++)
            {
                int temperature = int.Parse(temperatures[i]);
                if(int.Parse(temperatures[i]) < 0)
                {
                    temperature = temperature * (-1);
                }
                
                int temperatureBasse = result;
                if(temperatureBasse < 0)
                {
                    temperatureBasse = temperatureBasse * (-1);
                }
                
                if(temperature < temperatureBasse)
                {
                    result = int.Parse(temperatures[i]);
                } 
                
                if(temperature == temperatureBasse)
                {
                    if(result < int.Parse(temperatures[i]))
                    {
                        result = int.Parse(temperatures[i]);
                    }
                }
            }
        }

        // Afficher le résultat.
        Console.WriteLine(result);
    }
}