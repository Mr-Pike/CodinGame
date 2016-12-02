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
        // List of Nodes.
        Dictionary<int, List<int>> Nodes = new Dictionary<int, List<int>>();
        int Hours = 0;
        
        int n = int.Parse(Console.ReadLine()); // the number of adjacency relations
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int xi = int.Parse(inputs[0]); // the ID of a person which is adjacent to yi
            int yi = int.Parse(inputs[1]); // the ID of a person which is adjacent to xi
            
            if (!Nodes.ContainsKey(xi))
                Nodes.Add(xi, new List<int>());
            if (!Nodes.ContainsKey(yi))
                Nodes.Add(yi, new List<int>());
            
            Nodes[xi].Add(yi);
            Nodes[yi].Add(xi);
        }
        
        while (Nodes.Keys.Count > 0)
        {
            Dictionary<int, int> DeleteKeys = new Dictionary<int, int>();
            
            foreach (int Key in Nodes.Keys) 
            {
            	if (Nodes[Key].Count > 1) 
            		continue;
            		
            	DeleteKeys.Add(Key, Nodes[Key][0]);
            }
            
            // Delete key from Nodes.
            foreach (int Key in DeleteKeys.Keys)
            {
                Nodes.Remove(Key);
                
                if (Nodes.ContainsKey(DeleteKeys[Key]))
                {
                    Nodes[DeleteKeys[Key]] = Nodes[DeleteKeys[Key]].Where( x => x != Key).ToList();
                    
                    if (Nodes[DeleteKeys[Key]].Count == 0)
                        Nodes.Remove(DeleteKeys[Key]);
                }  
            }
            
            Hours++;
        }

        // Show result.
        Console.WriteLine(Math.Max(Hours, 2));
    }
}