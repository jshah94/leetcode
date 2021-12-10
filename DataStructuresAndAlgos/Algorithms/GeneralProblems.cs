using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    internal class GeneralProblems
    {
        public static int Factorial(int input)
        {
            if (input == 0)
            {
                return 1;
            }
            if (input > 1)
            {
                return input * Factorial(input - 1);
            }
            else
            {
                return input;
            }
        }

        public static Stack<int> SortStack(Stack<int> stack)
        {
            // Write your code here.
            if (stack.Count == 0)
            {
                return null;
            }
            var top = stack.Pop();
            SortStack(stack);
            InsertSortedStack(stack, top);
            return stack;
        }

        public static void InsertSortedStack(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
            }
            var top = stack.Pop();
            InsertSortedStack(stack, value);
            stack.Push(top);
        }

        public static int GetNthFib(int n)
        {
            // Write your code here.

            // 0, 1, 1, 2, 3, 5, 8, 13, 21
            if (n == 2)
                return 1;
            if (n <= 1)
                return 0;
            return GetNthFib(n - 1) + GetNthFib(n - 2);


        }

        public static int HammingDistanceII(int x, int y)
        {
            //x = 001
            //y = 100
            //dif = 101

            // dif = 101 & 100 = > 100 = 100 & 011
            // = 000

            int diff = x ^ y;
            int distance = 0;
            while (diff != 0)
            {
                diff = diff & diff - 1;
                distance++;
            }

            return distance;
        }

        public static int HammingDistance(int x, int y)
        {
            StringBuilder xbinary = ToBinary(x);
            StringBuilder ybinary = ToBinary(y);
            int lengthDifference = Math.Abs(xbinary.Length - ybinary.Length);
            if (lengthDifference != 0)
            {
                if (xbinary.Length > ybinary.Length)
                {

                    for (int m = 0; m < lengthDifference; m++)
                    {
                        ybinary = ybinary.Insert(0, "0");
                    }
                }
                else
                {
                    for (int m = 0; m < lengthDifference; m++)
                    {
                        xbinary = xbinary.Insert(0, "0");
                    }
                }
            }
            int difference = 0;
            int i = xbinary.Length - 1;
            int j = ybinary.Length - 1;
            while (i >= 0 && j >= 0)
            {
                if (xbinary[i] != ybinary[j])
                {
                    difference++;
                }
                i--;
                j--;
            }
            return difference;
        }

        public static StringBuilder ToBinary(Int32 Decimal)
        {
            // Declare a few variables we're going to need
            Int64 BinaryHolder;
            StringBuilder BinaryResult = new StringBuilder();

            while (Decimal > 0)
            {
                BinaryHolder = Decimal % 2;
                BinaryResult.Insert(0, BinaryHolder);
                Decimal = Decimal / 2;
            }

            return BinaryResult;
        }


        public static int GetASCIIHash(string str)
        {
            var bytes = Encoding.ASCII.GetBytes(str);
            int total = 0;
            foreach (var item in bytes)
            {
                total += item;
            }
            return total;
        }

        /// <summary>
        /// Formula explanation:
        /// initialize the current step to 0 and list for number of ways for each step. add 1 at top.
        /// start looping
        /// initialize start of window = currentStep - maxSteps - 1
        /// initialize end of window = currentStep - 1
        /// if start of window >= 0 then subtract the start of window from current number of ways.
        /// add end of window to the current number of ways.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="maxSteps"></param>
        /// <returns></returns>
        public static int StaircaseTraversal(int height, int maxSteps)
        {
            // Write your code here.
            int currentNumberOfWays = 0;
            List<int> waysToTop = new List<int>();
            waysToTop.Add(1);
            for (int currentStep = 1; currentStep <= height; currentStep++)
            {
                int startOfWindow = currentStep - maxSteps - 1;
                int endOfWindow = currentStep - 1;
                if (startOfWindow >= 0)
                {
                    currentNumberOfWays -= waysToTop[startOfWindow];
                }

                currentNumberOfWays += waysToTop[endOfWindow];
                waysToTop.Add(currentNumberOfWays);
            }
            return waysToTop[height];
        }

        public static bool IsPalindrome(int x)
        {
            if (x == 0)
                return false;
            int q = 0;
            int p = x;
            while (p > 0)
            {
                q = q * 10 + (p % 10);
                p = p / 10;
            }
            return q == x;
        }
        /// <summary>
        /// So keep adding the height and index in the stack.
        /// as soon as you come against a value which is smaller than the last item added.
        /// pop the item, caculate it's area, set the current start to the index of the popped height.
        /// add the current item to stack with height and index.
        /// in the end pop all the left values in stack and calculate area
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>


        // 1,2,3,1
        public static int Rob(int[] nums)
        {
            int score1 = 0;
            int score2 = 0;
            foreach (var sc in nums)
            {
                int temp = Math.Max(sc + score1, score2);
                score1 = score2;
                score2 = temp;
            }
            return score2;
        }

        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public static int Tribonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            int first = 0;
            int second = 1;
            int third = 1;
            for (int i = 3; i <= n; i++)
            {
                int newNum = first + second + third;
                first = second;
                second = third;
                third = newNum;
            }
            return third;
        }

        public static int Divide(int dividend, int divisor)
        {
            int sign = dividend > 0 ^ divisor > 0 ? -1 : 1;
            long m = Math.Abs((long)dividend), n = Math.Abs((long)divisor), count = 0;
            for (m -= n; m >= 0; m -= n)
            {
                count++;
                if (m == 0) break;
                for (int subCount = 1; m - (n << subCount) >= 0; subCount++)
                {
                    m -= n << subCount;
                    count += (int)Math.Pow(2, subCount);
                }
            }
            return count * sign > int.MaxValue ? int.MaxValue : (int)count * sign;
        }

        //n = 2
        public static int FibonacciWithSlidingWindow(int n)
        {
            if (n <= 2)
                return 1;
            List<int> list = new List<int> { 0, 1, 1 };
            int currentMax = 1;
            for (int i = 2; i < n; i++)
            {
                int startWindow = list.Count - 2 - 1;
                int endWindow = list.Count - 1;
                if (startWindow >= 0)
                {
                    currentMax -= list[startWindow];
                }
                currentMax += list[endWindow];
                list.Add(currentMax);
            }
            return currentMax;
        }

        public static int FibonacciBottomUp(int n)
        {
            if (n == 2 || n == 1)
                return 1;
            else if (n == 0)
                return 0;
            int previousMax = 0;
            int currentMax = 1;
            for (int i = 1; i < n; i++)
            {
                int temp = currentMax + previousMax;
                previousMax = currentMax;
                currentMax = temp;
            }
            return currentMax;
        }

        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }

        /// <summary>
        /// This is faster on leetcode but takes more memory
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int GetDecimalValue(ListNode head)
        {
            if (head == null)
                return 0;
            var current = head;
            Stack<int> stack = new Stack<int>();
            while (current != null)
            {
                stack.Push(current.val);
                current = current.next;
            }
            int decNumber = 0;
            int i = 0;
            while (stack.Count > 0)
            {
                int bit = stack.Pop();
                decNumber = decNumber + (int)(bit * Math.Pow(2, i));
                i++;
            }
            return decNumber;
        }

        /// <summary>
        /// this solution is slower on leetcode but takes less memory
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int GetDecimalValueII(ListNode head)
        {
            if (head == null)
                return 0;
            int sum = 0;
            while (head != null)
            {
                sum *= 2;
                sum += head.val;
                head = head.next;
            }
            return sum;
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> response = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                if (i == 0)
                {
                    response.Add(new List<int> { 1 });
                    continue;
                }

                var lst = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                        lst.Add(1);
                    else if (j == i)
                        lst.Add(1);
                    else
                        lst.Add(response[i - 1][j - 1] + response[i - 1][j]);
                }
                response.Add(lst);
            }

            return response;
        }

        public static int singleNumber(int[] A)
        {
            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                result ^= A[i];
            }
            return result;
        }

        public string ConvertToTitle(int columnNumber)
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
            while (columnNumber > 0)
            {
                int rem = (columnNumber - 1) % 26;
                columnNumber = (columnNumber - 1) / 26;
                title.Insert(0, map[rem]);
            }
            return title.ToString();
        }

        public int TitleToNumber(string columnTitle)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("A", 0);
            map.Add("B", 1);
            map.Add("C", 2);
            map.Add("D", 3);
            map.Add("E", 4);
            map.Add("F", 5);
            map.Add("G", 6);
            map.Add("H", 7);
            map.Add("I", 8);
            map.Add("J", 9);

            map.Add("K", 10);
            map.Add("L", 11);
            map.Add("M", 12);
            map.Add("N", 13);
            map.Add("O", 14);
            map.Add("P", 15);
            map.Add("Q", 16);
            map.Add("R", 17);
            map.Add("S", 18);
            map.Add("T", 19);
            map.Add("U", 20);
            map.Add("V", 21);
            map.Add("W", 22);
            map.Add("X", 23);
            map.Add("Y", 24);
            map.Add("Z", 25);

            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                result = result * 10;
                result += (map[columnTitle[i].ToString()] + 1);
            }

            return result;
        }

        //123
        public string IntToRoman(int num)
        {
            String[] M = { "", "M", "MM", "MMM" };
            String[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            String[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }
    }
}
