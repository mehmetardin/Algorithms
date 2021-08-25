using System;

namespace MergeSort
{
    public static class Array
    {
        public static int[] Sort(int[] arr)
        {

            Console.WriteLine("dizi uzunluğu =" + arr.Length);
            int middle = (arr.Length) / 2;
            Console.WriteLine("dizi uzunluk yarısı =" + middle);
            return arr;
        }
    }
}