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
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nbFloors = int.Parse(inputs[0]); // number of floors
        int width = int.Parse(inputs[1]); // width of the area
        int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
        int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
        int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
        int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
        int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
        int nbElevators = int.Parse(inputs[7]); // number of elevators
        Dictionary<int, int> Elevators = new Dictionary<int, int>(); // List of elevators Elevator[NbFloor] = Position. 
        bool[] BlockClone = new bool[nbFloors];
        for (int i = 0; i < nbElevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            Elevators.Add(int.Parse(inputs[0]), int.Parse(inputs[1]));
        }

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor = int.Parse(inputs[0]); // floor of the leading clone
            int clonePos = int.Parse(inputs[1]); // position of the leading clone on its floor
            string direction = inputs[2]; // direction of the leading clone: LEFT or RIGHT
            
            // No clone leader.
            if (cloneFloor == -1 && clonePos == -1 &&  direction == "NONE")
                Console.WriteLine("WAIT");
            else
            {
                // Destination : exit if the same floor else position of elevator.
                int destPos = cloneFloor == exitFloor ? exitPos : Elevators[cloneFloor];

                if (!BlockClone[cloneFloor] && 
                (direction == "RIGHT" && destPos < clonePos) || (direction == "LEFT" && destPos > clonePos))
                {
                    Console.WriteLine("BLOCK");
                    BlockClone[cloneFloor] = true;
                }
                else
                    Console.WriteLine("WAIT");
            }
        }
    }
}