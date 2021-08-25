using System;
using System.Collections.Generic;

namespace LevelOrderTraverselInSpiralForm
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  7
              /  \
             6    8
            /      \
           5        9
          /          \
         4            10

            */
            var tree = new Tree(7);
            tree.Add(6);
            tree.Add(8);
            tree.Add(9);
            tree.Add(10);
            //tree.Add(5);
           // tree.Add(4);
            tree.Print();
        }
    }


    public class Tree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }

        }

        public Node Root { get; set; }
        public int Count { get; set; }

        public Tree(int value)
        {
            Root = new Node(value);
        }

        public void Add(int value)
        {
            Insert(value);
            Count++;
        }

        private void Insert(int value)
        {
            var currentNode = Root;
            var node = new Node(value);

            while(true)
            {
                if(value > currentNode.Value)
                {
                    if(currentNode.Right == null)
                    {
                        currentNode.Right = node;
                        break;
                    }
                      
                    else
                        currentNode = currentNode.Right;
                }
                else
                {
                    if(currentNode.Left == null)
                    {
                        currentNode.Left = node;
                        break;
                    }
                        else
                            currentNode = currentNode.Left;
                }
            }
        }

        public void Print()
        {
            var stack = new Stack<Node>();
            var queue = new Queue<Node>();

            Console.WriteLine(Root.Value);

            PopulateQueue(queue,Root);

            while(queue.Count != 0)
            {
                
                while(queue.Count != 0)
                {
                    var currentNode = queue.Dequeue();
                    Console.WriteLine(currentNode.Value);
                    
                    PopulateStack(stack,currentNode);
                }

                while(stack.Count != 0)
                {
                    var currentNode = stack.Pop();
                    Console.WriteLine(currentNode.Value);

                    PopulateQueue(queue,currentNode);
                }

            }

        }

        public void PopulateStack(Stack<Node> stack, Node node)
        {
            if(node.Right != null)
                stack.Push(node.Right);
                
            if(node.Left != null)
                stack.Push(node.Left);
        }

        public void PopulateQueue(Queue<Node> queue, Node node)
        {
            if(node.Left != null)
                    queue.Enqueue(node.Left);
        
            if(node.Right != null)
                    queue.Enqueue(node.Right);
        }

    }
}
