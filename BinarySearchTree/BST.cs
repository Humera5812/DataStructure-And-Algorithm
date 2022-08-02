using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
       
        public Node root;
        public virtual bool BST
        {
            get
            {
                return isBSTUtil(root, int.MinValue, int.MaxValue);
            }
        }
        public virtual bool isBSTUtil(Node node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.data < min || node.data > max)
            {
                return false;
            }
            return (isBSTUtil(node.left, min, node.data - 1) && isBSTUtil(node.right, node.data + 1, max));
        }

        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(4);
            tree.root.left = new Node(2);
            tree.root.right = new Node(5);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(3);

            if (tree.BST)
            {
                Console.WriteLine("Is Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}

