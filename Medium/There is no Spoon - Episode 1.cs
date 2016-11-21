using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
class Player
{ 
    static void Main(string[] args)
    {
        // Declare vars.
        int width = int.Parse(Console.ReadLine()); // The number of cells on the X axis.
        int height = int.Parse(Console.ReadLine()); // The number of cells on the Y axis.
        List<Node> ListNodes = new List<Node>(); // List of Node.

        // Fill List of nodes.
        for (int y = 0; y < height; y++)
        {
            string line = Console.ReadLine(); // width characters, each either 0 or .
            for (int x = 0; x < width; x++)
            {
                if (line[x].ToString() == "0")
                    ListNodes.Add(new Node(x, y));
            }
        }
        
        // Fetch all nodes.
        foreach (Node node in ListNodes)
        {
            string CoordNodeRight = "-1 -1";
            string CoordNodeBottom = "-1 -1";
            
            // Search on right.
            foreach (Node NodeS in ListNodes)
            {
                if (NodeS.y == node.y && NodeS.x > node.x)
                {
                    CoordNodeRight = NodeS.x + " " + NodeS.y; 
                    break;
                }
            }
            
            // Search on bottom.
            foreach (Node NodeS in ListNodes)
            {
                if (NodeS.x == node.x && NodeS.y > node.y)
                {
                    CoordNodeBottom = NodeS.x + " " + NodeS.y; 
                    break;
                }  
            }   
            
            // Show Result.
            Console.WriteLine("{0} {1} {2} {3}", node.x, node.y, CoordNodeRight, CoordNodeBottom);
        }
    }
}

// Class Node.
public class Node 
{    
	public int x { get; set; }
	public int y { get; set; }
    
    public Node(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}