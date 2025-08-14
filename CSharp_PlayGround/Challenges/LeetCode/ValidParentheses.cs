using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/valid-parentheses/description/
    class ValidParenthesesClass
    {
        //with Stack.Any() slow , Stack.Count is fast

        //Runtime 9ms Beats 8.75%,-> TO 2ms 82.60%
        //Memory 42.60MB Beats 13.88% -> TO 42.01MB 63.86
        public static bool ValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            Stack<char> lastOpens = new Stack<char>();

            foreach (char ch in s) 
            {
                if (IsOpen(ch))
                    lastOpens.Push(ch);
                else if (lastOpens.Count == 0 || GetMatchForClose(ch) != lastOpens.Pop())
                    return false;
            }

            return lastOpens.Count == 0;
        }
        private static bool IsOpen(char ch) 
        {
            return ch == '(' || ch == '{' || ch == '[';
        }
        private static char GetMatchForClose(char ch) 
        {
            switch (ch) 
            {
                case ')': return '(';
                case '}': return '{';
                case ']': return '[';
                default: return '\0';
            }
        }

        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool ValidParentheses_Final(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            // Get ready initial state (enforce element type)
            var k = new Stack<char>();
            // Evaluate each character for potential mismatch 
            foreach (char c in s)
            {
                // Push closing round bracket onto the stack
                if (c == '(') { k.Push(')'); continue; }
                // Push closing curly bracket onto the stack
                if (c == '{') { k.Push('}'); continue; }
                // Push closing square bracket onto the stack
                if (c == '[') { k.Push(']'); continue; }
                // Look out for imbalanced strings or mismatches
                if (k.Count == 0 || c != k.Pop()) return false;
            }
            // Empty stack means string is valid and invalid otherwise
            return k.Count == 0;
        }
        
        public static void Implement()
        {
            string s = "({})";
            Console.WriteLine(ValidParentheses(s));

            s = "()";
            Console.WriteLine(ValidParentheses(s));

            s = "()[]{}";
            Console.WriteLine(ValidParentheses(s));

            s = "(]";
            Console.WriteLine(ValidParentheses(s));

            s = "([)]";
            Console.WriteLine(ValidParentheses(s));

            s = "[";
            Console.WriteLine(ValidParentheses(s));

            s = ")";
            Console.WriteLine(ValidParentheses(s));

            s = "[])";
            Console.WriteLine(ValidParentheses(s));
        }

    }
}
