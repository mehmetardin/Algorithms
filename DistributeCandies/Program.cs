using System;
using System.Collections.Generic;

namespace DistributeCandies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public int DistributeCandies(int[] candyType) 
        {

        HashSet<int> uniqueCandiesSet = new HashSet<int>();
        
        for (int i=0; i< candyType.Length;i++) 
        {
            uniqueCandiesSet.Add(candyType[i]);
        }
        // Then, find the answer in the same way as before.
        return Math.Min(uniqueCandiesSet.Count, candyType.Length / 2); 
    }
    }
}
