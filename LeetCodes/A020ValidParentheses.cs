using System.Collections;
using System.Collections.Generic;

namespace LeetCodes
{
    public class A020ValidParentheses
    {
        public Hashtable matchMap = new Hashtable();
        public bool IsValid(string s) {
            matchMap.Add(')','(');
            matchMap.Add(']','[');
            matchMap.Add('}','{');
            Stack<char> stack = new Stack<char>();
            foreach (var ch in s)
            {
                switch (ch)
                {
                        case '(':
                        case '[':
                        case '{':
                            stack.Push(ch);
                            break;
                        case ')':
                        case ']':
                        case '}':
                            if (!IsMatch(stack, ch))
                            {
                                return false;
                            }

                            break;
                }
            }
            return stack.Count == 0;
        }

        public bool IsMatch(Stack<char> stack, char ch)
        {
            if (!stack.TryPeek(out var chIn))
            {
                return false;
            }

            if (chIn == (char) matchMap[ch])
            {
                stack.Pop();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}