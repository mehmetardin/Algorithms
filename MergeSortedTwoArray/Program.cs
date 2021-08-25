using System;

namespace MergeSortedTwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,2,4,5,0,0,0,0};
            int[] arr2 = {2,4,5,9};
            
            Merge(arr1, 4, arr2, 4);
            Console.WriteLine("Hello World!");
        }

       

        public static void Merge(int[] arr1, int m, int[] arr2, int n)
        {
            int arr1Middle = m - 1;
            int arr1Right = arr1.Length-1;
            int arr2Right = arr2.Length - 1;


            while(arr2Right >= 0)
            {
                if (arr1[arr1Middle] < arr2[arr2Right])
                    arr1[arr1Right--] = arr2[arr2Right--];
                else
                    arr1[arr1Right--] = arr1[arr1Middle--];
                    
            }

            
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
