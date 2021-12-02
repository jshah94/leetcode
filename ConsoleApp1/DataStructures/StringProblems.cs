using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StringProblems
    {
        public static int RomanToInt(string s)
        {
            int number = 0;
            int previous = Int32.MaxValue;
            for (int i = 0; i < s.Length; i++)
            {
                char romanChar = s[i];
                int num = GetIntFromRomanChar(romanChar);
                if (romanChar == 'I')
                {
                    int _num = 0;
                    int j = i;
                    while (s[j] == 'I' && j < s.Length)
                    {
                        _num++;
                        j++;
                    }
                    num = _num;
                    i = j - 1;
                }
                if (previous >= num)
                {
                    number += num;
                }
                else
                {
                    number -= previous;
                    num -= previous;
                    number += num;
                }
                previous = num;
            }
            return number;
        }

        public static int GetIntFromRomanChar(char roman)
        {
            switch (roman)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }

        public static int LongestSubStringWithoutRepeatingCharacters(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            char[] charArray = str.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs.Add(charArray[0], 0);
            int longest = 0;
            int j = 0;
            for (int i = 1; i < charArray.Length; i++)
            {

                while (keyValuePairs.ContainsKey(charArray[i]))
                {
                    keyValuePairs.Remove(charArray[j]);
                    j++;
                }

                keyValuePairs.Add(charArray[i], 0);
                longest = Math.Max(longest, i - j + 1);
            }
            return longest;
        }

        public static bool BalancedBrackets(string str)
        {
            // Write your code here.
            string openingBrackets = "[{(";
            string closingBrackets = ")}]";
            Dictionary<char, char> openClosePairs = new Dictionary<char, char>();
            openClosePairs.Add(']', '[');
            openClosePairs.Add('}', '{');
            openClosePairs.Add(')', '(');
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (openingBrackets.IndexOf(str[i]) != -1)
                {
                    stack.Push(str[i]);
                }
                else if (closingBrackets.IndexOf(str[i]) != -1)
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char item = stack.Pop();
                        if (item != openClosePairs[str[i]])
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(haystack) && !string.IsNullOrEmpty(needle))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            int i = 0;
            int j = 0;
            while (i < haystack.Length && j < needle.Length)
            {
                if (haystack[i] == needle[0])
                {
                    int k = i;
                    while (j < needle.Length && k < haystack.Length)
                    {
                        if (needle[j] == haystack[k])
                        {
                            j++;
                            k++;
                        }
                        else
                            break;
                    }
                    if (j == needle.Length)
                        return i;
                    else
                    {
                        j = 0;
                        i++;
                    }
                }
                else
                    i++;
            }
            return -1;
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            List<string> response = new List<string>();
            BackTrack(response, "", 0, 0, n);
            foreach (var item in response)
            {
                Console.WriteLine(item);
            }
            return response;
        }

        public static void BackTrack(List<string> list, string str, int open, int close, int max)
        {
            if (str.Length == max * 2)
            {
                list.Add(str);
                return;
            }

            if (open < max)
            {
                BackTrack(list, str + "(", open + 1, close, max);
            }
            if (close < open)
            {
                BackTrack(list, str + ")", open, close + 1, max);
            }
        }


        public static string LongestPalindrome(string s)
        {
            //brute force solution
            //abcaababac
            //abba
            if (string.IsNullOrWhiteSpace(s))
                return s;

            int longestString = 1;
            int[] index = new int[] { 0, 1 };
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    int j = i;
                    int k = i + 1;
                    while (j >= 0 && k < s.Length)
                    {
                        if (s[j] == s[k])
                        {
                            j--;
                            k++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (k - j > longestString)
                    {
                        longestString = k - (j + 1);
                        index[0] = j + 1;
                        index[1] = longestString;
                    }
                }
                else if (i > 0 && i < s.Length - 1 && s[i - 1] == s[i + 1])
                {
                    int j = i - 1;
                    int k = i + 1;
                    while (j >= 0 && k < s.Length)
                    {
                        if (s[j] == s[k])
                        {
                            j--;
                            k++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (k - j > longestString)
                    {
                        longestString = k - (j + 1);
                        index[0] = j + 1;
                        index[1] = longestString;
                    }
                }
            }
            return s.Substring(index[0], index[1]);
        }
        public static bool GenerateDocument(string characters, string document)
        {
            // Write your code here.
            if (characters.Length < document.Length)
            {
                return false;
            }
            var dictionary = CreateCharacterDictionary(characters);
            for (int i = 0; i < document.Length; i++)
            {
                if (dictionary.ContainsKey(document[i]) && dictionary[document[i]] > 0)
                {
                    dictionary[document[i]] -= 1;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static Dictionary<char, int> CreateCharacterDictionary(string characters)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < characters.Length; i++)
            {
                if (dictionary.ContainsKey(characters[i]))
                {
                    dictionary[characters[i]] += 1;
                }
                else
                    dictionary.Add(characters[i], 1);
            }
            return dictionary;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            string longestCommon = strs[0];
            int i = 1;
            while (i < strs.Length && longestCommon.Length != 0)
            {
                string str = strs[i];
                while (str.IndexOf(longestCommon) != 0)
                {
                    longestCommon = longestCommon.Substring(0, longestCommon.Length - 1);
                }
                i++;
            }
            return longestCommon;
        }

        public static int LengthOfLongestSubstring(string s = "abcabcbb")
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int[] max = new int[] { 0, 1 };
            int start = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (dic.ContainsKey(c))
                {
                    start = Math.Max(start, dic[c] + 1);
                }
                if (i - start + 1 > max[1] - max[0])
                {
                    max[0] = start;
                    max[1] = i + 1;
                }
                dic[c] = i;
            }
            return max[1] - max[0];
        }

        public static bool IsValidParenthesis(string s)
        {
            Stack<char> openingStack = new Stack<char>();
            Dictionary<char, char> parenthesis = new Dictionary<char, char>();
            parenthesis.Add('}', '{');
            parenthesis.Add(')', '{');
            parenthesis.Add(']', '[');
            for (int i = 0; i < s.Length; i++)
            {
                if (IsOpening(s[i]))
                {
                    openingStack.Push(s[i]);
                }
                else
                {
                    if (openingStack.Count > 0)
                    {
                        char opening = openingStack.Pop();
                        if (parenthesis[s[i]] == opening)
                            continue;
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (openingStack.Count > 0)
                return false;
            return true;
        }


        public static bool IsOpening(char parenthesis)
        {
            if (parenthesis == '(' || parenthesis == '{' || parenthesis == '[')
                return true;
            return false;
        }

        //public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        //{
        //    var l1Current = l1;
        //    var l2Current = l2;


        //}



        public static int NumDecodings(string s)
        {
            Dictionary<int, int> dp = new Dictionary<int, int>();
            dp.Add(s.Length, 1);

            return dfs(s, 0, dp);
        }
        /// <summary>
        /// Dry run
        /// </summary>
        /// <param name="str"></param>
        /// <param name="idx"></param>
        /// <param name="ways"></param>
        /// <returns></returns>
        public static int dfs(string str, int idx, Dictionary<int, int> ways)
        {
            if (ways.ContainsKey(idx))
            {
                return ways[idx];
            }
            if (str[idx] == '0')
                return 0;
            int res = dfs(str, idx + 1, ways);
            if (idx + 1 < str.Length && (str[idx] == '1' || (str[idx] == '2' && "0123456".Contains(str[idx + 1]))))
            {
                res += dfs(str, idx + 2, ways);
                ways[idx] = res;
                return res;
            }
            return res;
        }
    }
}
