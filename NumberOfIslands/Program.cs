using System;

namespace NumberOfIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[][] {  new string[] {"1","1","1","1","0"},
                                        new string[] {"1","1","0","1","0"},
                                        new string[] {"1","1","0","0","1"},
                                        new string[] {"0","0","1","0","1"}};

            Console.WriteLine(NumberOfIslands(arr));
        }


        public static int NumberOfIslands(string[][] grid)
        {
            if(grid == null || grid.Length == 0)
            return 0;

            int numIslands = 0;
            for(int i = 0; i< grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == "1")
                    {
                        numIslands += Dfs(grid, i, j);
                    }
                }
            }

            return numIslands;
        }

        public static int Dfs(string[][] grid, int i, int j)
        {
            if(i<0 || i>= grid.Length || j<0 || j>= grid[i].Length || grid[i][j] == "0")
                return 0;

            grid[i][j] = "0";
            
            Dfs(grid, i+1, j);
            Dfs(grid, i-1, j);
            Dfs(grid, i, j+1);
            Dfs(grid, i, j-1);
            
            return 1;

        }
    }
}
