using System;

namespace MaximumSumSubArray
{
    public static class DivideAndConquerSolution
    {
    static int MaxCrossingSum(int[] arr, int l, int m,int h)
        {
            // Include elements on left of mid.
            int sum = 0;
            int left_sum = int.MinValue;
            for (int i = m; i >= l; i--) 
            {
                sum = sum + arr[i];
                
                if (sum > left_sum)
                    left_sum = sum;
            }
    
            // Include elements on right of mid
            sum = 0;
            int right_sum = int.MinValue;
            
            for (int i = m + 1; i <= h; i++) 
            {
                sum = sum + arr[i];
                
                if (sum > right_sum)
                    right_sum = sum;
            }
    
            // Return sum of elements on left
            // and right of mid
            // returning only left_sum + right_sum will fail for
            // [-2, 1]
            return Math.Max(left_sum + right_sum, Math.Max(left_sum, right_sum));
        }
 
    // Returns sum of maxium sum subarray
    // in aa[l..h]
    public static int MaximumSumSubArray(int[] arr, int l, int h)
    {
 
        // Base Case: Only one element
        if (l == h)
            return arr[l];
 
        // Find middle point
        int m = (l + h) / 2;
 
        /* Return maximum of following three
        possible cases:
        a) Maximum subarray sum in left half
        b) Maximum subarray sum in right half
        c) Maximum subarray sum such that the
        subarray crosses the midpoint */
        return Math.Max(Math.Max(MaximumSumSubArray(arr, l, m), 
                        MaximumSumSubArray(arr, m + 1, h)),
                        MaxCrossingSum(arr, l, m, h));
    }
    }
}