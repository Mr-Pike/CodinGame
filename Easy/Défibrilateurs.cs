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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        double longitudeA = double.Parse(LON.Replace(',', '.'));
        double latitudeA = double.Parse(LAT.Replace(',', '.'));
        double distanceMin = double.MaxValue;
        string defibAdresse = "";
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            Console.Error.WriteLine(DEFIB);
            string[] Champs = DEFIB.Split(';');
            
            double longitudeB = double.Parse(Champs[4].ToString().Replace(',', '.'));
            double latitudeB = double.Parse(Champs[5].ToString().Replace(',', '.'));
            
            double x = (longitudeB - longitudeA) * Math.Cos(((latitudeA + latitudeB) / 2));
            double y = latitudeB - latitudeA;
            double D = Math.Sqrt(((x*x) + (y*y))) * 6371;
            
            if(D < distanceMin)
            {
                distanceMin = D;
                defibAdresse = Champs[1].ToString();
            }
        }

        Console.WriteLine(defibAdresse);
    }
}