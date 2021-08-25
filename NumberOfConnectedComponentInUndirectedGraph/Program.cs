using System;
using System.Collections.Generic;

namespace NumberOfConnectedComponentInUndirectedGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = 4;
            var arr = new int[][] { new int[]{0,1}, 
                                    new int[]{1,2}, 
                                    new int[]{3,4}};

            Console.WriteLine(CountOfComponents(arr, nodes));
        }

        static int CountOfComponents(int[][] edges, int n)
        {
            var adj = new Dictionary<int,List<int>>();

            for(int i = 0; i<= n; i++)
                adj.Add(i,new List<int>());

            for(int i= 0; i< edges.Length; i++)
            {
                adj[edges[i][0]].Add(edges[i][1]);
                adj[edges[i][1]].Add(edges[i][0]);
            }

            var visited = new bool[n+1];
            int count = 0;

            for(int i= 0; i<n; i++)
            {
                if(visited[i] == false)
                {
                    count++;
                    Dfs(adj, i, visited);
                }
            }

            return count;
        }

        private static void Dfs(Dictionary<int,List<int>> adj, int index, bool[] visited)
        {
            visited[index] = true;

            foreach(var j in adj[index])
            {
                if(!visited[j]) //base case
                Dfs(adj,j,visited);
            }
        }
    }
}
