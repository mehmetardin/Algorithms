using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,4,5,6,7,8};

            int[] result = Array.Sort(array);

            for(int i=0; i< result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
