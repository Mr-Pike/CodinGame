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
        int R = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
            
        // Put number in List.
        List<int> numberList = new List<int>{R};

        for (int i = 1; i < L; i++)
        {
            // Create temporary list and put value and initialize count.
            List<int> tempNumberList = new List<int>();
            int count = 1;
            int value = numberList[0];
            
            // For each number, check this is the same number and increment it.
            for (int j = 1; j < numberList.Count(); j++)
            {
                if (value == numberList[j])
                    count++;
                else
                {
                    // Add values.
                    tempNumberList.Add(count);
                    tempNumberList.Add(value);
                    
                    // Reinitializing.
                    count = 1;
                    value = numberList[j];
                }
            }
            
            // Add last values. 
            tempNumberList.Add(count);
            tempNumberList.Add(numberList[numberList.Count() - 1]);
            
            numberList = tempNumberList.ToList();
        }
        
		// Show result.
        Console.WriteLine(String.Join(" ", numberList.ToArray()));
    }
}