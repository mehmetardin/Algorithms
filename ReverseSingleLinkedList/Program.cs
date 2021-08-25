using System;

namespace ReverseSingleLinkedList
{
    class Program
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                var initialNode = new Node(0);
                var list = new LinkedList(initialNode);

                for (int i = 1; i < 4; i++)
                {
                    var node = new Node(i);
                    list.Append(node);
                }
                list.Print();
                list.Reverse();
                list.Print();
            }
        }

        class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        class LinkedList
        {
            public Node Head { get; set; }
            public Node Tail { get; set; }
            public int Count { get; set; }

            public LinkedList(Node node)
            {
                Head = node;
                Tail = node;
            }

            public void Prepend(Node node)
            {
                node.Next = Head;
                Head = node;
            }

            public void Reverse()
            {

                
                var p1 = Head; 
                var p2 = Head.Next; 

                p1.Next = null; 

                while (p2 != null)
                {

                    var temp = p2.Next; 

                    p2.Next = p1;
                    p1 = p2;
                    p2 = temp;

                }

                Head = p1;
            }

            public void Append(Node node)
            {
                var currentNode = Head;
                while(currentNode != null)
                {
                    if (currentNode.Next == null)
                    {
                        currentNode.Next = node;
                        Tail = node;
                        currentNode = currentNode.Next.Next;
                    }
                    else
                        currentNode = currentNode.Next;
                }
                
            }

            public void Print()
            {
                var currentNode = Head;

                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Next;
                }

                Console.WriteLine("-------------------");
            }
        }
    }
}
