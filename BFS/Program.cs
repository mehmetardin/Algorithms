using System;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
           //GraphTest();

           BinaryTreeTest();
        }

        static void BinaryTreeTest()
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
            Console.WriteLine("Tree Size is " + bst.Count());
            bst.Print();

        }


        static void GraphTest()
        {
             var vertices = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var edges = new[]{  Tuple.Create(1,2), Tuple.Create(1,3),
                                Tuple.Create(2,4), Tuple.Create(3,5), 
                                Tuple.Create(3,6), Tuple.Create(4,7), 
                                Tuple.Create(5,7), Tuple.Create(5,8),
                                Tuple.Create(5,6), Tuple.Create(8,9), 
                                Tuple.Create(9,10)};

            var graph = new Graph<int>(vertices, edges);
            var algorithms = new Algorithm();

            var startVertex = 1;
            var shortestPath = algorithms.ShortestPathFunction(graph, startVertex);
            foreach (var vertex in vertices)
                Console.WriteLine("shortest path to {0,2}: {1}",
                        vertex, string.Join(", ", shortestPath(vertex)));
        }
    



    }
}
