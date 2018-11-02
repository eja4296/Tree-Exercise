# Tree-Exercise

## Problem
Building a tree of integers.
Root node has a value of 1.
Every node has two children.
The left child's value is the sum of its parent's value and its parent's left neighbor's value.
The right child's value is the sum of its parent's value and its parent's right neighbor's value.
If the parent does not have a particular neighbor, the child's value is equal to the parent's value.

## How to run and use the program
Run the "Tree-Exercise.exe" in Tree-Exercise/Tree-Exercise/bin/debug (it will open up a console window).
Once running, type an integer to specify the number of tree levels and hit 'ENTER'.
The program will build the tree and display it, and then ask for another input.
Type 'exit' to exit the program.

## Structure and organization
There are three main classes for this program:

### Node
The node class is for creating a node of a generic type (an integer in this case).
It has a 'key,' or value, attribute.
It has references to its left and right child nodes.
It has references to its left and right neighbor nodes.
The key value is set in the constructor when the node is created.
It also has a 'Print' method which returns its key value to display in the console.

### Tree
The tree class is for creating the tree full of nodes.
It has a root node.
It has a integer value for its number of levels.
It has a 'BuildTree' method which takes an integer for the number of tree levels and builds the tree according to the parameters specified in the Problem section.
The BuildTree method starts by creating the root node, and then goes row by row creating each level of nodes before moving onto the next, meaning that a node is connected to its neighbors before its children are created (The child values are based on the nodes neighbor values, so it must know its neighbors before creating its children).

### Program
Program handles the main loop and user input.
It has a Tree attribute.
It promts the user for an integer value to determine the number of tree levels.
It then creates thre Tree based on the user's input.
It will continue to loop until the user exits the program (by typing 'exit').