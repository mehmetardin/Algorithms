using System;
using System.Collections.Generic;
namespace PartitionLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = PartitionLabel("ababcbacadefegdehijhklij");

            for(int i= 0; i< result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public static int[] PartitionLabel(string s)
        {
   
            return new int[] {1};
        }


    }
}
