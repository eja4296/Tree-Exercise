using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Exercise
{
    // Generic Node Class
    // Every Node has a value
    // Every Node has 2 children
    class Node <T>
    {
        // Attributes
        private T key; // node's value
        private Node<T> leftChild; // node's left child, key = parent's key + parent's left neighbor's key
        private Node<T> rightChild; // node's right child, key = parent's key + parent's right neightbor's key
        private Node<T> leftNeighbor; // node's left neighbor
        private Node<T> rightNeighbor; // node's right neighbor

        // Constructor
        public Node(T ky)
        {
            key = ky;
        }

        // Properties
        public T Key
        {
            get { return key; }
            set { key = value; }
        }

        public Node<T> LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }

        public Node<T> RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        public Node<T> LeftNeighbor
        {
            get { return leftNeighbor; }
            set { leftNeighbor = value; }
        }

        public Node<T> RightNeighbor
        {
            get { return rightNeighbor; }
            set { rightNeighbor = value; }
        }

        // Methods
        // Print method
        // Prints key of node
        public void Print()
        {
            Console.Write(" - " + key + " - ");
        }

    }
}

