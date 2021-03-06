﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erik Azzarano

namespace Tree_Exercise
{
    // Main Program Class
    // Handles user input to create Trees
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth *= 2;

            // Attributes
            Tree tree;
            bool active = true; // program runs while true, will exit when false
            string inputStr = "";
            int inputInt = 0;

            // Header
            Console.WriteLine("TREE-EXERCISE");


            // Main loop
            // Take user input for number of Tree levels and create Tree
            // Keeps looking until 'exit' is typed
            while (active)
            {
                // Promt user to enter value for levels
                Console.WriteLine("Specify number of levels to create Tree: ");
                inputStr = Console.ReadLine();

                // Exit program if 'exit' is typed
                // Notification for exit command available after first tree is created
                if (inputStr == "exit")
                {
                    active = false;
                }

                // Parse user input to get integer value
                bool inputParsed = int.TryParse(inputStr, out inputInt);
                if (inputParsed == false || inputInt < 1)
                {
                    // Provide error feedback if input is not valid
                    Console.WriteLine("Input not valid. Enter an integer greater than 0.");
                    continue;
                }
                // Otherwise if the input was an integer, create the tree
                else
                {
                    // Create tree based on levels
                    Console.WriteLine("Creating tree with " + inputInt + " levels.");
                    tree = new Tree();
                    tree.BuildTree(inputInt);
                }

                Console.WriteLine();
                Console.WriteLine("(Type 'exit' to leave TREE-EXERCISE)");
            }

        }
    }
}
