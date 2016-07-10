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
            
        int heightest;
        int maxHeight;
        // game loop
        while (true)
        {
            heightest = 0;
            maxHeight = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.
                
                
                    if(maxHeight < mountainH) {
                    maxHeight = mountainH;
                    heightest = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(heightest); // The number of the mountain to fire on.
        }
    }
}