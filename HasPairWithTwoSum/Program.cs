using System;
using System.Collections.Generic;
using System.Collections;



/*
Input: arr[] = {0, -1, 2, -3, 1}
        sum = -2
Output: -3, 1
If we calculate the sum of the output,
1 + (-3) = -2

Input: arr[] = {1, -2, 1, 0, 5}
       sum = 0
Output: -1
No valid pair exists.

*/


namespace HasPairWithTwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = {1,3,4};
            var targetSum = 2;

            var result = HasPairWithTwoSum(arr,targetSum);
            Console.WriteLine(result);
        }

        static bool HasPairWithTwoSum(int[] arr, int sum)
        {
            var hashSet = new HashSet<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                var difference = sum - arr[i];
                if(hashSet.Contains(difference))
                return true;

                hashSet.Add(arr[i]);

            }
            return false;
            
        }
    }
}
