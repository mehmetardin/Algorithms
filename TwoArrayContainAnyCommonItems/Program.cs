using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoArrayContainAnyCommonItems
{
    class Program
    {
        //2 parameters- array - no size limit
        // return true or false
        static void Main(string[] args)
        {
            string[] array1 = {"d", null, "c", "d","h"};
            string[] array2 = {"", "y", "s", "a"};

            var resultBrute = TwoArrayContainAnyCommonItemsBruteForce(array1,array2);
            Console.WriteLine(resultBrute);

            var resultEfficent = TwoArrayContainAnyCommonItems(array1, array2);
            Console.WriteLine(resultEfficent);
        }

        public static bool TwoArrayContainAnyCommonItems(string[] arr1, string[] arr2)
        {
            var hashSet = new HashSet<string>();

            for (int i=0; i< arr1.Length;i++)
            {
                if(!hashSet.Contains(arr1[i]))
                    hashSet.Add(arr1[i]);
            }

            for(int j = 0; j<arr2.Length; j++)
            {
                if(hashSet.Contains(arr2[j]))
                    return true;
            }

            return false;
        }

        public static bool TwoArrayContainAnyCommonItemsBruteForce(string[] array1, string[] array2)
        {
            for(int i=0; i<array1.Length; i++)
            {
                for(int j=0; j<array2.Length;j++)
                {
                    if(array1[i] == array2[j])
                    return true;
                }
            }

            return false;
        }
    }
}
