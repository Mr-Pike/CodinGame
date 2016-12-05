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
        string MESSAGE = Console.ReadLine();
        string resultat = "";
        
        // Constitution de la chaine binaire.
        string ChaineBinaire = "";
        byte[] bytes = Encoding.UTF8.GetBytes(MESSAGE);
        foreach(byte b in bytes)
        {
            string Binaire = Convert.ToString(b, 2);
            Binaire = new string('0', 7 - Binaire.Length) + Binaire;
            ChaineBinaire += Binaire;
        }
        
        // Affichage de la chaine binaire.
        Console.Error.WriteLine(ChaineBinaire);
        
        // Parcours de la chaine binaire.
        string chainePrecedente = "";
        int compteur = 0;
        for(int i = 0; i < ChaineBinaire.Length; i++)
        {
            if(i == 0)
            {
                chainePrecedente = ChaineBinaire[i].ToString();
                compteur++;
            }
            else
            {
                if(chainePrecedente != ChaineBinaire[i].ToString())
                {
                    if(resultat != "")
                    {
                        resultat += " ";
                    }
                    
                    if(chainePrecedente.ToString() == "1")
                    {
                        resultat += "0 ";
                    }
                    else
                    {
                        resultat += "00 ";
                    }
                    
                    for(int j = 0; j < compteur; j++)
                    {
                        resultat += "0";
                    }
                    
                    chainePrecedente = ChaineBinaire[i].ToString();
                    compteur = 1;
                }
                else
                {
                    compteur++;
                }
                
            }
        }
        
        
        if(chainePrecedente.ToString() == "1")
        {
            resultat += " 0 ";
        }
        else
        {
            resultat += " 00 ";
        }
        
        for(int j = 0; j < compteur; j++)
        {
            resultat += "0";
        }

        Console.WriteLine(resultat);
    }
}