using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Exercise
{
    // Node Class
    // Every Node has a value
    // Every Node has 2 children
    class Node
    {
        // Attributes
        private int value; // node's value
        private Node leftChild; // node's left child, value = parent's value + parent's left neighbor's value
        private Node rightChild; // node's right child, value = parent's value + parent's right neightbor's value
        private Node leftNeighbor; // node's left neighbor
        private Node rightNeighbor; // node's right neighbor

        // Constructor
        public Node(int val)
        {
            value = val;
        }

    }
}

