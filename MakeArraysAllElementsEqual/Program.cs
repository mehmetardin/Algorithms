using System;
using System.Collections.Generic;

namespace MakeArraysAllElementsEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {5, 5, 5, 5,4};

            //4,2,8
            //5,7,3,7

            var result = GetEvenNumbersOfPair(arr);
            Console.WriteLine(result);
        }

        private static int GetEvenNumbersOfPair(int[] arr)
        {
            int currentSum = 0;
            int counter = 0;
            int pair = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                pair++;
                currentSum  += arr[i];

                if(pair == 2)
                {
                    if(currentSum %2 == 0)
                    {
                        counter ++;
                        currentSum = 0;
                        pair = 0;
                    }
                    else 
                    {
                        currentSum = 0;
                        i--;
                        pair = 0;
                    }
                }
               
            }
            return counter;
        }

        private static int MakeAllelementsEqualSteps(int[] A)
        {
            if(A.Length <= 1 || A == null)
                return 0;
           
            Array.Sort(A);
            int left = 0;
            int right = A.Length -1;
            int sum = 0;

            while(left<right)
            {
                sum += A[right] - A[left];
                left++;
                right--;
            }

            return sum;
        }
    }
}
