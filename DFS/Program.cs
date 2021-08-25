using System;

namespace DFS
{

    class BinaryTree{

        public class Node
        {
            public int Value { get; set; }
            public Node Right { get; set; }
            public Node Left { get; set; }

            public Node(int value)
            {
                this.Value = value;
                this.Right = null;
                this.Left = null;
            }
        }
        public Node Root { get; set; }

       public void Add(int value)

       {
           this.Root = Insert(Root,value);
       }

       public Node Insert(Node root, int value)
       {
           if(root == null)
               return root = new Node(value);
              

            if(value < root.Value)
                root.Left = Insert(root.Left, value);

            else if(value> root.Value)
                root.Right = Insert(root.Right, value);

            return root;
       }

       public void PrintInOrder()
       {
           InOrder(Root);
       }

       private void InOrder(Node root)
       {
           if(root == null)
           return;

           InOrder(root.Left);
           Console.WriteLine(root.Value);
           InOrder(root.Right);
       }

       public void PrintPreOrder()
       {
           PreOrder(Root);
       }

       private void PreOrder(Node root)
       {
           if(root == null)
           return;

           Console.WriteLine(root.Value);
           PreOrder(root.Left);
           PreOrder(root.Right);
       }

       public void PrintPostOrder()
       {
           PostOrder(Root);
       }

       private void PostOrder(Node root)
       {
           if(root == null)
           return;

           PostOrder(root.Left);
           PostOrder(root.Right);
           Console.WriteLine(root.Value);
       }

       public bool IsContainRecursive(int value)
       {
           return DFS(Root,value);
       }

       private bool DFS(Node root, int value)
       {
           if(root == null)
           return false;

           if(root.Value == value)
           return true;

           if(value < root.Value)
                return DFS(root.Left, value);
            else
                return DFS(root.Right, value);
       }

       public bool IsContainIterative(int value)
       {
           var current = Root;

           if(current.Value == value)
           return true;

           while(current != null && current.Value != value)
           {
               
                if(value< current.Value)
                    current = current.Left;
                else if(value > current.Value)
                    current = current.Right;
                
                if(current != null && current.Value == value)
                return true;
                
           }

           return false;
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
                7
              /   \
             4     8
            / \     /\
           3   6   9  10
            
            */
            var bst = new BinaryTree();
            bst.Add(7);
            bst.Add(8);
            bst.Add(4);
            bst.Add(9);
            bst.Add(10);
            bst.Add(3);
            bst.Add(6);
            Console.WriteLine("PreOrder");
            bst.PrintPreOrder();

            Console.WriteLine("InOder");
            bst.PrintInOrder();

            Console.WriteLine("PostOrder");
            bst.PrintPostOrder();

            Console.WriteLine("Recursive Result = " + bst.IsContainRecursive(4));

            Console.WriteLine("Iterative Result = " + bst.IsContainIterative(4));

        }
    }
}
