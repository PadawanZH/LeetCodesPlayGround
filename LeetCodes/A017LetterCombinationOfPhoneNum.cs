using System.Collections.Generic;

namespace LeetCodes
{
    public class A017LetterCombinationOfPhoneNum
    {
        string[] book = new string[] {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
        
        public IList<string> LetterCombinations(string digits) {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            IList<string> temp = new List<string>();
            temp.Add("");
            DisplayDigit(digits, ref temp);
            return temp;
        }

        public void DisplayDigit(string str, ref IList<string> resList)
        {
            if (string.IsNullOrEmpty(str))
            {
                return;
            }
            List<string> temp = new List<string>();
            foreach (var s in resList)
            {
                foreach (var choice in book[str[0] - 50])
                {
                    string t = s + choice;
                    temp.Add(t);
                }
            }

            resList = temp;
            if (str.Length > 1)
            {
                DisplayDigit(str.Substring(1), ref resList);
            }
        }
    }
    
   
}