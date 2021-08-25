using System;
using System.Collections;

namespace LogAllPairsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,4,5,6};

            LogAllPairsOfArray(arr);
        }

        public static void LogAllPairsOfArray(int[] arr)
        {
            var arrQueue = new Queue();
            int counter = 0;
            int counter1 = 0;
            int pair = 0;

            for(int i=0; i< arr.Length; i++)
            arrQueue.Enqueue(arr[i]);

            pair = (int)arrQueue.Dequeue();

            while(counter <= arr.Length) 
            {
                Console.WriteLine($"{arr[counter1]},{pair}");
                counter1++;

                if(counter1 == arr.Length)
                {
                    counter++;
                    counter1 = 0;

                    if(counter < arr.Length)
                    pair = (int)arrQueue.Dequeue();
                }
            } 

        }
    }
}
