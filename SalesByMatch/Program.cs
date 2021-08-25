using System;
using System.Collections;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20,10,20,20,20,30,10};
            var result = SalesByMatch(arr);
            Console.WriteLine("Number of Pair is " + result);

            var result1 = SalesByMatchWihHashSet(arr);
            Console.WriteLine("Number of Pair is " + result1);
        }

        static int SalesByMatchWihHashSet(int[] arr)
        {
            var count = 0;
            HashSet<int> hash = new HashSet<int>();

            for(int i= 0; i< arr.Length; i++)
            {
                if(!hash.Contains(arr[i]))
                    hash.Add(arr[i]);
                else
                {
                   count += 1;
                   hash.Remove(arr[i]);
                }
            }

            return count;
        }

        static int SalesByMatch(int[] arr)
        {
            int pair = 0;
            Hashtable hashtable = new Hashtable();

            for(int i = 0; i < arr.Length; i++)
            {
                if(!hashtable.ContainsKey(arr[i]))
                    hashtable.Add(arr[i],1);
                else
                    hashtable[arr[i]] = (int)hashtable[arr[i]] + 1;

                if(hashtable.Contains(arr[i]))
                {
                    if((int)hashtable[arr[i]] % 2 == 0)
                    {
                        pair += 1;
                    }
                }

            }

            return pair;
        }
    }
}
