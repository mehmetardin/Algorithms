using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,15,16,17,18,19,20,21};
            int leftIndex = 1;
            int rightIndex = arr.Length-1;
            int searchValue = 2;
            var result = BinarySearchRecursive(arr, leftIndex, rightIndex ,searchValue);

            Console.WriteLine("Recursive Element found at index at " + result);

            Console.WriteLine("Iterative Element fount at index " +  BinarySearchIterative(arr,99));
        }


        static int BinarySearchRecursive(int[] arr, int l, int r, int x)
        {
            if (r >= l) 
            {
                int mid = (l + r) / 2;
    
                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                    return mid;
    
                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearchRecursive(arr, l, mid - 1, x);
    
                // Else the element can only be present
                // in right subarray
                return BinarySearchRecursive(arr, mid + 1, r, x);
            }
    
            // We reach here when element is not present
            // in array
            return -1;
        }

        static int BinarySearchIterative(int[] arr, int target)
        {
            var left = 0;
            var right = arr.Length - 1;

            while(left <= right)
            {
                var middle = (left + right) / 2;

                if(arr[middle] == target)
                return middle;

                if(target > arr[middle])
                    left = middle + 1;
                else
                right = middle - 1;

            }

            return -1;
            
        }
    }
}
