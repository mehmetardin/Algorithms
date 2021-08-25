using System;
using System.Collections.Generic;

namespace ItemsInContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "|**|*|*";
            var startIndicate = new List<int>() {1,1};
            var endIndicate = new List<int>() {5,6};
            Console.WriteLine(numberOfItems(text,startIndicate, endIndicate));
        }


        public static List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices) 
        {
            int[] mem = new int[s.Length];
            int count = 0;
            for (int i = 0; i < s.Length; ++i) {
                if (s[i] == '|') 
                    mem[i] = count;
                else 
                    count++;
            }

            List<int> ans = new List<int>();

            for (int i = 0; i < startIndices.Count; ++i) {
                int start = startIndices[i] - 1;
                int end = endIndices[i] - 1;
                
                while (start < end && s[start] != '|') 
                start++;

                while (start < end && s[end] != '|') 
                end--;

                ans.Add(mem[end] - mem[start]);
            }

            return ans;
        }
    }
}
