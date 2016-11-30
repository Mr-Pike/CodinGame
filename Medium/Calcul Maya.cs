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
    
    public static List<string> ASCII = new List<string> 
    {
        "", "", "", "", "", 
        "", "", "", "", "",
        "", "", "", "", "", 
        "", "", "", "", ""
    };
    
    public const int Base = 20;
        
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int L = int.Parse(inputs[0]);
        int H = int.Parse(inputs[1]);

        
        List<string> numbers1 = new List<string>();
        List<string> numbers2 = new List<string>();
        
        // Create ASCII table.
        for (int i = 0; i < H; i++)
        {
            string numeral = Console.ReadLine();
            
            for (int j = 0; j < numeral.Length / L; j++)
            {
                ASCII[j] += (ASCII[j] != "" ? "\n" : "") + numeral.Substring(j * L, L);
            }
        }
        
        // Put numbers into array.
        int S1 = int.Parse(Console.ReadLine());
        string num1Line = "";
        for (int i = 0; i < S1; i++)
        {
            if (H == 1)
            {
                numbers1.Add(num1Line + Console.ReadLine());
                continue;
            }
            
            if ((i + 1) % H == 0)
            {
                numbers1.Add(num1Line + "\n" + Console.ReadLine());
                num1Line = "";
            }
            else 
                num1Line += (num1Line != "" ? "\n" : "") + Console.ReadLine();           
        }
        int S2 = int.Parse(Console.ReadLine());
        string num2Line = "";
        for (int i = 0; i < S2; i++)
        {
            if (H == 1)
            {
                numbers2.Add(num2Line + Console.ReadLine());
                continue;
            }
            
            if ((i + 1) % H == 0)
            {
                numbers2.Add(num2Line + "\n" + Console.ReadLine());
                num2Line = "";
            }
            else 
                num2Line += (num2Line != "" ? "\n" : "") + Console.ReadLine();
        }
        
        
        // Do the operation.
        long sum = DoOperation(GetSum(numbers1), GetSum(numbers2), Console.ReadLine());
        
        // Show the result.
        ShowMaya(sum);
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
    }
    
    // Get sum with list of string.
    static long GetSum(List<string> numbers)
    {
        long total = 0;
        
        for (int i = 0; i < numbers.Count; i++)
            total += ASCII.IndexOf(numbers[i]) * (int)Math.Pow(20, numbers.Count - i - 1);
        
        return total;
    }
    
    // Do operation between two numbers.
    static long DoOperation(long n1, long n2, string operation)
    {
        if (operation == "-")
            return n1 - n2;
        if (operation == "*")
            return n1 * n2;
        if (operation == "/")
            return n1 / n2;
        
        // By default, do the sum.
        return n1 + n2;
    }
    
    // Convert number to Maya ASCII.
    static void ShowMaya(long number)
    {
		List<string> result = new List<string>();
		
		if (number == 0)
		    Console.WriteLine(ASCII[0]);
		else
		{
    		while (number != 0) 
    		{
    			decimal mod = number % Base;
    			number = number / Base;
    			result.Insert(0, ASCII[(int)mod]);
    		}
    		
    		foreach (string s in result)
    			Console.WriteLine(s);
		}
    }
}