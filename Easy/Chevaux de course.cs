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
        int N = int.Parse(Console.ReadLine());
        
        ArrayList tab = new ArrayList();
        int ecartpi = int.MaxValue;
        
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            tab.Add(pi);
        }
        
        tab.Sort();
        
        for (int i = 1; i < tab.Count; i++)
        {
            int puissance = int.Parse(tab[i].ToString()) - int.Parse(tab[i-1].ToString()) ;
            if (puissance < ecartpi)
                ecartpi = puissance;
        }

        Console.WriteLine(ecartpi);
    }
}