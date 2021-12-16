using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StringProblems
    {
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

        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> dictS = new Dictionary<char, int>();
            Dictionary<char, int> dictT = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictS.ContainsKey(s[i]))
                    dictS[s[i]] += 1;
                else
                    dictS.Add(s[i], 1);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dictT.ContainsKey(t[i]))
                    dictT[t[i]] += 1;
                else
                    dictT.Add(t[i], 1);
            }
            foreach (var itm in dictT)
            {
                if (dictS.ContainsKey(itm.Key) && dictS[itm.Key] == itm.Value)
                    continue;
                else
                    return itm.Key;
            }
            return '`';
        }

        //Better solution
        public char FindTheDifferenceII(string s, string t)
        {
            int charS = 0;
            int charT = 0;
            for (int i = 0; i < s.Length; i++)
                charS += (int)s[i];
            for (int i = 0; i < t.Length; i++)
                charT += (int)t[i];
            return (char)(charT - charS);
        }

        public static string ConvertToTitle(int columnNumber)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(0, "A");
            map.Add(1, "B");
            map.Add(2, "C");
            map.Add(3, "D");
            map.Add(4, "E");

            map.Add(5, "F");
            map.Add(6, "G");
            map.Add(7, "H");
            map.Add(8, "I");
            map.Add(9, "J");

            map.Add(10, "K");
            map.Add(11, "L");
            map.Add(12, "M");
            map.Add(13, "N");
            map.Add(14, "O");

            map.Add(15, "P");
            map.Add(16, "Q");
            map.Add(17, "R");
            map.Add(18, "S");
            map.Add(19, "T");

            map.Add(20, "U");
            map.Add(21, "V");
            map.Add(22, "W");
            map.Add(23, "X");
            map.Add(24, "Y");
            map.Add(25, "Z");
            StringBuilder title = new StringBuilder();
            while(columnNumber > 0)
            {
                int rem = (columnNumber - 1) % 26;
                columnNumber = (columnNumber) / 26;
                title.Insert(0,map[rem]);
            }
            return title.ToString();
        }

        public static string CaesarCypherEncryptor(string str, int key)
        {
            // Write your code here.
            Dictionary<char, int> alpha = new Dictionary<char, int>();
            StringBuilder response = new StringBuilder();
            alpha.Add('a', 1);
            alpha.Add('b', 2);
            alpha.Add('c', 3);
            alpha.Add('d', 4);
            alpha.Add('e', 5);
            alpha.Add('f', 6);
            alpha.Add('g', 7);
            alpha.Add('h', 8);
            alpha.Add('i', 9);
            alpha.Add('j', 10);

            alpha.Add('k', 11);
            alpha.Add('l', 12);
            alpha.Add('m', 13);
            alpha.Add('n', 14);
            alpha.Add('o', 15);
            alpha.Add('p', 16);
            alpha.Add('q', 17);
            alpha.Add('r', 18);
            alpha.Add('s', 19);
            alpha.Add('t', 20);

            alpha.Add('u', 21);
            alpha.Add('v', 22);
            alpha.Add('w', 23);
            alpha.Add('x', 24);
            alpha.Add('y', 25);
            alpha.Add('z', 26);
            Dictionary<int, char> code2Char = new Dictionary<int, char>();
            code2Char.Add(1, 'a');
            code2Char.Add(2, 'b');
            code2Char.Add(3, 'c');
            code2Char.Add(4, 'd');
            code2Char.Add(5, 'e');
            code2Char.Add(6, 'f');
            code2Char.Add(7, 'g');
            code2Char.Add(8, 'h');
            code2Char.Add(9, 'i');
            code2Char.Add(10, 'j');

            code2Char.Add(11, 'k');
            code2Char.Add(12, 'l');
            code2Char.Add(13, 'm');
            code2Char.Add(14, 'n');
            code2Char.Add(15, 'o');
            code2Char.Add(16, 'p');
            code2Char.Add(17, 'q');
            code2Char.Add(18, 'r');
            code2Char.Add(19, 's');
            code2Char.Add(20, 't');

            code2Char.Add(21, 'u');
            code2Char.Add(22, 'v');
            code2Char.Add(23, 'w');
            code2Char.Add(24, 'x');
            code2Char.Add(25, 'y');
            code2Char.Add(26, 'z');
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int code = alpha[c];
                code += key;
                if(code > 26)
                {
                    code = code % 26;
                }
                response.Append(code2Char[code]);
            }
            return response.ToString();
        }

        public static int MaxPower(string s)
        {
            char currentChar = s[0];
            int maxPower = 1;
            int currentMax = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if(s[i] == currentChar)
                {
                    currentMax++;
                }
                else
                {
                    currentMax = 1;
                    currentChar = s[i];
                }
                maxPower = Math.Max(maxPower, currentMax);
            }
            return maxPower;
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int currentMax = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 1)
                {
                    currentMax++;
                }
                else
                {
                    currentMax = 0;
                }
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentMax);
            }
            return maxConsecutiveOnes;
        }

        
    }
}
