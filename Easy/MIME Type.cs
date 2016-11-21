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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            dictionary.Add(EXT.ToLower(), MT);
        }
        
		for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            string result = "UNKNOWN";
            string[] fichier = FNAME.Split('.');
            int tailleFichier = fichier.Length;
            if(tailleFichier >= 2)
            {
                if(dictionary.ContainsKey(fichier[tailleFichier - 1].ToLower()))
                    result = dictionary[fichier[tailleFichier - 1].ToLower()];
            }
            
            Console.WriteLine(result);
        }
    }
}