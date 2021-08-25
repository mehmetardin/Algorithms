using System;
using System.Collections.Generic;

namespace BFS
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
        private int _count;

        public int Count()
        {
            return this._count;
        }

       public void Add(int value)

       {
           this.Root = Insert(Root,value);
           _count++;
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

       public void Print()
       {
           var queue = new Queue<Node>();
           var visited = new bool[this._count];
           queue.Enqueue(Root);

           while(queue.Count != 0)
           {
               var current = queue.Dequeue();
               Console.WriteLine(current.Value);
               
               if(current.Left != null)
               {
                   if(!visited[current.Left.Value])
                    queue.Enqueue(current.Left);

               }

               if(current.Right != null)
               {
                   if(!visited[current.Right.Value])
                    queue.Enqueue(current.Right);

               }
           }
       }

      
       public bool IsContainRecursive(int value)
       {
           return BFS(Root,value);
       }

       private bool BFS(Node root, int value)
       {
           return true;
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
}