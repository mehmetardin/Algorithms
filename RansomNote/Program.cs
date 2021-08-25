using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        /*
        given two string and and return first string can construct with the second string
        both of string contain only lower letter
        return bool
        */
        static void Main(string[] args)
        {
            var result = RansomNote("aa","aab");
            Console.WriteLine(result);
        }

        public static bool RansomNote(string str1, string str2)
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();

            for(int i=0; i < str2.Length; i++)
            {
                if(dictionary.ContainsKey(str2[i]))
                    dictionary[str2[i]]++;
                else
                    dictionary.Add(str2[i],1);
            }

            for(int j=0; j < str1.Length; j++)
            {
                
                if(!dictionary.ContainsKey(str1[j]) || dictionary[str1[j]] <= 0)
                  return false;   
                    
                    dictionary[str1[j]]--;
               
            }

            return true;
        }
    }
}
