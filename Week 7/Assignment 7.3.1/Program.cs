using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

namespace Assignment_7._3._1 {
    internal class Program {
        /*
        You are given the root of a binary search tree (BST) and an integer val.
        Find the node in the BST that the node's value equals val and return the
        subtree rooted with that node. If such a node does not exist, return null. 
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            BST NumbersTree = new BST();
            foreach (int i in new[] {
                10,20,30,40,50,60,70
            }) NumbersTree.InsertNode(i);
            NumberTree subtree = NumbersTree.Search(40);
            if (subtree != null) {
                Console.WriteLine($"Found node {subtree.number}, " +
                                  $"subtree root is {subtree.number}");
                PrintInOrder(subtree);
            }
            else {
                Console.WriteLine("Value not found in tree.");
            }
        }

        static void PrintInOrder(NumberTree? node) {
            if (node == null) return;
            PrintInOrder(node.left);
            Console.Write(node.number + " ");
            PrintInOrder(node.right);
        }

        public class NumberTree {
            public int number;
            public NumberTree left;
            public NumberTree right;
            public NumberTree(int value) {
                number = value;
            }
        }

        class BST {
            public NumberTree root;

            public void InsertNode(int val) {
                var node = new NumberTree(val);
                if (root == null) {
                    root = node;
                    return;
                }
                var curr = root; // <-- use a local cursor
                NumberTree parent = null; // <-- remember the parent
                while (curr != null) {
                    parent = curr;
                    if (val == curr.number) {
                        Console.WriteLine("Value already exists in the tree.");
                        return;
                    }
                    else if (val < curr.number) {
                        curr = curr.left;
                    }
                    else {
                        curr = curr.right;
                    }
                }
                if (val < parent.number) parent.left = node; // <-- attach to parent
                else parent.right = node;
            }
            public NumberTree Search(int val) {
                NumberTree temp = root;
                while (temp != null) {
                    if (temp.number == val) {
                        return temp; // <-- value found
                    }
                    else if (val < temp.number) {
                        temp = temp.left; // <-- go left
                    }
                    else {
                        temp = temp.right; // <-- go right
                    }
                }
                return null; // <-- value not found
            }
        }
    }
}
/*
Absolutely way too hard to do this... I need to either practice or just keep
watching videos about this... even putting it aside two days and picking it
back up i needed to look up almost everything and mess with it a lot...
*/