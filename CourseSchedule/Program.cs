using System;
using System.Collections.Generic;

namespace CourseSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCourses = 2;
            var courses = new int[][] { new int[]{1,0},new int[]{0,1}};
            Console.WriteLine(CanFinish(numCourses,courses));
        }

 public static bool CanFinish(int numCourses, int[][] prerequisites) {
        
        var adj = new Dictionary<int, List<int>>();
        
        for(int i=0; i<numCourses; i++)
            adj.Add(i,new List<int>());
        
        for(int i =0; i< prerequisites.Length; i++)
            adj[prerequisites[i][1]].Add(prerequisites[i][0]); // directed graph
        
        int[] visited = new int[numCourses];
        
        for(int i=0; i< numCourses; i++)
        {
            if(!Dfs(visited, i, adj))
                return false;
        }
        
        return true;
    }
    
    public static bool Dfs(int[] visited, int course, Dictionary<int, List<int>> adj)
    {
        //if the value is equal -1 that is man that we visited this vertex during same DFS detect cycle
        if(visited[course] == -1)
            return false;
        
        //if the value is equal 1 that is mean we visited this vertex previous DFS
        if(visited[course] == 1)
            return true;
        
        //mark visited 
        visited[course] = -1;
        
        for (int i = 0; i<adj[course].Count; i++)
        {
            if(!Dfs(visited, adj[course][i] , adj))
                return false;
        }
        
        visited[course] = 1;
        return true;
    }

    


    }
}
