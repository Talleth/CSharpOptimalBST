using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimalBinarySearchTree
{
    public class BinaryTree
    {
        private Node m_root;

        public BinaryTree()
        {
        }

        public Node Root
        {
            get { return this.m_root; }
            set { this.m_root = value; }
        }

        public int[] GetNodeValues()
        {
            // Function to return all of the nodes values from the tree
            List<int> values = new List<int>();
            this.TraverseTreeForValues(this.Root, values);
            return values.ToArray();
        }

        private void TraverseTreeForValues(Node currentNode, List<int> values)
        {
            // Function to traverse the tree for values
            if (currentNode != null)
            {
                this.TraverseTreeForValues(currentNode.Left, values);
                values.Add(currentNode.Data);
                this.TraverseTreeForValues(currentNode.Right, values);
            }
        }

        public class Node
        {
            private Node    m_right;
            private Node    m_left;
            private int     m_data;

            public Node(int data)
            {
                this.m_data = data;
                this.m_right = null;
                this.m_left = null;
            }

            public Node Right
            {
                get { return this.m_right; }
                set { this.m_right = value; }
            }

            public Node Left
            {
                get { return this.m_left; }
                set { this.m_left = value; }
            }

            public int Data
            {
                get { return this.m_data; }
                set { this.m_data = value; }
            }
        }
    }
}
