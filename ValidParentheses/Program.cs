using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("{[]}"));
        }

        public static bool IsValid(string s) 
        {
        
        var stack = new Stack<char>();
        
        for(int i=0; i<s.Length;i++)
        {
            if(stack.Count == 0)
            {
                stack.Push(s[i]);
                continue;
            }
            
            var previous = stack.Peek();
            var current = s[i];
            
            if(previous == '(' && current == ')')
                stack.Pop();
            else if(previous == '{' && current == '}')
                stack.Pop();
            else if(previous == '[' && current == ']')
                stack.Pop();
            else
                stack.Push(current);
        }
        
        return (stack.Count == 0);
        
    }
    }
}
