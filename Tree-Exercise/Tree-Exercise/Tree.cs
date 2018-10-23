using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Exercise
{
    // Tree class
    class Tree
    {
        // Attributes
        private Node<int> root; // root node, key = 1
        private int levels; // number of tree levels

        // Constructor
        public Tree()
        {

        }

        // Properties
        public Node<int> Root
        {
            get { return root; }
            set { root = value; }
        }

        public int Levels
        {
            get { return levels; }
            set { levels = value; }
        }

        // Methods
        // Build Tree method
        // Create a tree based on number of levels specified
        public void BuildTree(int lvls)
        {
            levels = lvls;

            // Start by creating root node
            // key = 1, 2 children, no neighbors
            Node<int> newNode = new Node<int>(1);

            root = newNode;

            // Set the root node
            Node<int> currentNode = root;

            // Create a list to hold all nodes of the current level
            List<Node<int>> currentLevelNodes = new List<Node<int>>();

            // Add root node to list
            currentLevelNodes.Add(root);

            // Create a list to hold all nodes of the new level
            List<Node<int>> newLevelNodes = new List<Node<int>>();

            // Track current level of tree
            int currentLevel = 0;

            // Loop until all levels have been created
            while(currentLevel < levels)
            {

                // Loop through current level nodes
                // Determine neighbors
                // Create children and add them to new level nodes
                for (int i = 0; i < currentLevelNodes.Count; i++)
                {
                    // If the nodes is the first in the level (far left) it will not have a left neighbor
                    if (i == 0)
                    {
                        // Set left neighbor to null
                        currentLevelNodes[i].LeftNeighbor = null;
                        // If it is not the root node, set right neighbor to next node
                        if (i < currentLevelNodes.Count - 1)
                        {
                            currentLevelNodes[i].RightNeighbor = currentLevelNodes[i + 1];
                        }
                        // If it is the root node, set the right neighbor to null as well
                        else
                        {
                            currentLevelNodes[i].RightNeighbor = null;
                        }
                    }
                    // If the node is in the middle of the level
                    else if (i > 0 && i < currentLevelNodes.Count - 1)
                    {
                        // Set the left neighbor to the left (previous) node
                        currentLevelNodes[i].LeftNeighbor = currentLevelNodes[i - 1];
                        // Set the right neighbor to the right (next) node
                        currentLevelNodes[i].RightNeighbor = currentLevelNodes[i + 1];
                    }
                    // If the node if the last in the level (far right) it will not have a right neighbor
                    else
                    {
                        // Set the left neightbor to the left (previous) node
                        currentLevelNodes[i].LeftNeighbor = currentLevelNodes[i - 1];
                        // Set the right neighbor to null
                        currentLevelNodes[i].RightNeighbor = null;
                    }

                    // Create children
                    Node<int> leftChild;
                    // If the parent has a left neighbor
                    if(currentLevelNodes[i].LeftNeighbor != null)
                    {
                        // Set the left child key equal to the parent key + the parent's left neighbor key
                        leftChild = new Node<int>(currentLevelNodes[i].Key + currentLevelNodes[i].LeftNeighbor.Key);
                    }
                    // If the parent does not have a left neighbor
                    else
                    {
                        // Set the left child key equal to the parent key
                        leftChild = new Node<int>(currentLevelNodes[i].Key);
                    }

                    Node<int> rightChild;
                    // If the parent has a right neighbor
                    if(currentLevelNodes[i].RightNeighbor != null)
                    {
                        // Set the right child key equal to the parent key + the parent's left neighbor key
                        rightChild = new Node<int>(currentLevelNodes[i].Key + currentLevelNodes[i].RightNeighbor.Key);
                    }
                    // If the parent does not have a right neighbor
                    else
                    {
                        // Set the right child key equal to the parent key
                        rightChild = new Node<int>(currentLevelNodes[i].Key);
                    }

                    // Add the children to the new level nodes list
                    newLevelNodes.Add(leftChild);
                    newLevelNodes.Add(rightChild);

                    // Print the current node
                    currentLevelNodes[i].Print();
                }

                // Add space between tree levels
                Console.WriteLine();

                // Make the new level nodes the current level nodes
                currentLevelNodes = newLevelNodes;
                // Reset the new level nodes
                newLevelNodes = new List<Node<int>>();

                // Increment the current level for the loop
                currentLevel += 1;
            }
        }
    }
}
