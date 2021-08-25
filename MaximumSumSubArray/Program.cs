using System;

namespace MaximumSumSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-2, -3, 4, -1, -2, 1, 5, -3};
            Console.WriteLine("Maximum contiguous with Kadene Solution sum is " + KadenesAlgorithmSolution.MaximumSumSubArray(arr));
            Console.WriteLine("Maximum contiguous with Brute Force Solution sum is " + BruteForceSolution.MaximumSumSubArray(arr));
            Console.WriteLine("Maximum contiguous with Divide and Conquer Solution sum is " + DivideAndConquerSolution.MaximumSumSubArray(arr,0,arr.Length-1));

        
        }
    }
}
