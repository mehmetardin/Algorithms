using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
        }


        public static int LengthOfLongestSubstring(string s) 
        {
        
        if(s == "")
            return 0;
        
        var hash = new HashSet<char>();
        var maxCount = 0;
        var left = 0;
        var right = 0;

        while(right < s.Length)
        {
            if(!hash.Contains(s[right]))
            {
                hash.Add(s[right++]);
                maxCount = Math.Max(hash.Count,maxCount);
            }
            else
                hash.Remove(s[left++]);

        }
       return maxCount;
        
    }
    }
}
