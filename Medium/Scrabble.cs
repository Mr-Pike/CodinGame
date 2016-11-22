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
		// Dictionary containing the points of each letter.
		Dictionary <char, byte> letterPoints = new Dictionary <char, byte>();
		letterPoints.Add('e', 1);
		letterPoints.Add('a', 1);
		letterPoints.Add('i', 1);
		letterPoints.Add('o', 1);
		letterPoints.Add('n', 1);
		letterPoints.Add('r', 1);
		letterPoints.Add('t', 1);
		letterPoints.Add('l', 1);
		letterPoints.Add('s', 1);
		letterPoints.Add('u', 1);
		letterPoints.Add('d', 2);
		letterPoints.Add('g', 2);
		letterPoints.Add('b', 3);
		letterPoints.Add('c', 3);
		letterPoints.Add('m', 3);
		letterPoints.Add('p', 3);
		letterPoints.Add('f', 4);
		letterPoints.Add('h', 4);
		letterPoints.Add('v', 4);
		letterPoints.Add('w', 4);
		letterPoints.Add('y', 4);
		letterPoints.Add('k', 5);
		letterPoints.Add('j', 8);
		letterPoints.Add('x', 8);
		letterPoints.Add('q', 10);
		letterPoints.Add('z', 10);
		
		// Dictionary containing possible words with number of total points.
        Dictionary <string, byte> dictionaryWords = new Dictionary <string, byte>();
        List<string> possibleWorlds = new List<string>(); 
        
		// For each words, get the number of points.
		int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
			string W = Console.ReadLine();
			byte points = 0;
			foreach (char letter in W)
				points += letterPoints[letter];
			dictionaryWords.Add(W, points);
        }
		
		// Letters.
        string LETTERS = Console.ReadLine();
		List<char> listLetter = new List<char>();
		foreach (char letter in LETTERS)
			listLetter.Add(letter);
		
		// Fetch all words in the dictionnary.
		foreach (string word in dictionaryWords.Keys)
		{
			// Create temporary list of letters.
			List<char> TempListLetter = listLetter.ToList();
			bool bValideWord = true;
			
			// For each char in the word of dictionary check if we have the letter.
			foreach (char letter in word)
			{
			    if (!TempListLetter.Contains(letter))
			    {
			        bValideWord = false;
					break;  
			    }
				
				TempListLetter.Remove(letter);
			}
			
			if (bValideWord)
			    possibleWorlds.Add(word);
		}
		
		// Found the word having max of points.
		string theWord = "";
		byte maxPoints = 0;
		foreach (string word in possibleWorlds)
	    {
		    if (dictionaryWords[word] > maxPoints)
		    {
		        theWord = word;
		        maxPoints = dictionaryWords[word];
		    }
		}

		// Show the result.
        Console.WriteLine(theWord);
    }
}