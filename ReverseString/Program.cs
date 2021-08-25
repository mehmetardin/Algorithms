using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello My Name is Mehmet";
            var result = ReverseString(str);
            Console.WriteLine(result);
        }

        static string ReverseString(string str)
        {
            string result = string.Empty;

            for(int i= str.Length-1; i >= 0; i--)
            {
                result = result + str[i];
            }
            return result;
        }
    }
}
