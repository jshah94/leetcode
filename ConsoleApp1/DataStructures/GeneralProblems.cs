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
    }
}
