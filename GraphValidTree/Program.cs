using System;
using System.Collections.Generic;

namespace GraphValidTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var edges = new int[][] {new int[]{0,1},
                                     new int[]{0,2},
                                     new int[]{0,3},
                                     new int[]{1,4}};
            var nodes = 5;
            
            Console.WriteLine(IsValidGraph(nodes,edges));
        }


          public static bool IsValidGraph(int n, int[][] edges) 
          {
        
            var adj = new Dictionary<int,List<int>>();
            var visited = new HashSet<int>();


            for(int i=0; i<n; i++)
            adj.Add(i,new List<int>());

            for(int i=0; i<edges.Length; i++)
            {
               adj[edges[i][0]].Add(edges[i][1]);
               adj[edges[i][1]].Add(edges[i][0]);
            }

            
            return Dfs(0,-1,visited,adj) && visited.Count == n;
        
    }
        private static bool Dfs(int node, int parent, HashSet<int> visited, Dictionary<int,List<int>> adj)
        {
            if(visited.Contains(node))
            return false;

            visited.Add(node);

            for(int i =0; i<adj[node].Count; i++)
            {
                var neighbour = adj[node][i];
                if(neighbour != parent)
                {
                    bool result  = Dfs(neighbour, node, visited, adj);

                    if(!result)
                    return false;
                }
                
            }

            return true;
            
        }
    }
}
