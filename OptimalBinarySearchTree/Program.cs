using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalBinarySearchTree
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            // Construct the tree
            BinaryTree binaryTree = Program.CreateTree();

            // Get all node values from tree (this means we can pass any tree into this function
            int[] nodeValues = binaryTree.GetNodeValues();
            // Frequencies from the announcment
            int[] frequencies = { 30, 60, 10, 20, 30, 50, 40, 10, 30, 60, 30, 10, 20, 50, 40 };

            Console.WriteLine();
            Console.Write("The minimum cost of the binary search tree is: " + 
                DynamicAlgorithm.FindOptimalSearchTreeValue(nodeValues, frequencies));
        }

        public static BinaryTree CreateTree()
        {
            BinaryTree binaryTree = new BinaryTree();

            // Left side of the tree
            binaryTree.Root                     = new BinaryTree.Node(8);
            binaryTree.Root.Left                = new BinaryTree.Node(4);
            binaryTree.Root.Left.Left           = new BinaryTree.Node(2);
            binaryTree.Root.Left.Left.Left      = new BinaryTree.Node(1);
            binaryTree.Root.Left.Left.Right     = new BinaryTree.Node(3);
            binaryTree.Root.Left.Right          = new BinaryTree.Node(6);
            binaryTree.Root.Left.Right.Left     = new BinaryTree.Node(5);
            binaryTree.Root.Left.Right.Right    = new BinaryTree.Node(7);

            // Right side of the tree
            binaryTree.Root.Right               = new BinaryTree.Node(12);
            binaryTree.Root.Right.Left          = new BinaryTree.Node(10);
            binaryTree.Root.Right.Left.Left     = new BinaryTree.Node(9);
            binaryTree.Root.Right.Left.Right    = new BinaryTree.Node(11);
            binaryTree.Root.Right.Right         = new BinaryTree.Node(14);
            binaryTree.Root.Right.Right.Left    = new BinaryTree.Node(13);
            binaryTree.Root.Right.Right.Right   = new BinaryTree.Node(15);

            return binaryTree;
        }
    }
}
