using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rob(new int[] { 1, 2, 3, 1 });
            //LargestRectangleArea(new int[] { 2, 1, 2 });
            //IsPalindrome(121);
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(1);
            //head.next.next = new ListNode(1);
            //head.next.next.next= new ListNode(3);
            //head.next.next.next.next = new ListNode(3);
            //DeleteDuplicates(head);
            //RomanToInt("IV");
            //StaircaseTraversal(5, 2);
            //PlusOne(new int[] { 9 });
            //NumDecodings("10112");
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 0 };
            matrix[1] = new int[] { 2, 1 };
            matrix[2] = new int[] { 8, 1 };
            matrix[3] = new int[] { 15, 18 };
            //Merge(matrix);
            //Rotate(matrix);
            //ListNode head;
            //head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);

            //ListNode head2;
            //head2 = new ListNode(1);
            //head2.next = new ListNode(2);
            //head2.next.next = new ListNode(3);
            //head2.next.next.next = new ListNode(4);
            //head2.next.next.next.next = new ListNode(5);

            //MergeTwoLists(head2, head);

            //IsValidParenthesis("()");
            //RemoveNthFromEnd(new ListNode(), 1);
            //BinarySearchTree bt = new BinarySearchTree(5);
            //bt.Left = new BinarySearchTree(3);
            //bt.Right = new BinarySearchTree(6);
            //bt.Left.Left = new BinarySearchTree(2);
            ////bt.Left.Right = new BinarySearchTree(4);
            //bt.Right.Right = new BinarySearchTree(7);
            //LengthOfLongestSubstring();
            //RemoveElement(new int[] { 3, 2, 2, 3 }, 3);

            //[1,1,2,3,3,4,4,8,8]
            //[3,3,7,7,10,11,11]
            //[1,1,2]
            //Console.WriteLine(SingleNonDuplicate(new int[] { 3, 3, 7, 7, 10, 11, 11 }));

            char[][] board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'E', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
            MaximalRectangle(null);
            //Console.WriteLine(Exist(board, "ABCEFSADEESE"));
            //Console.WriteLine(HammingDistanceII(1, 4));
            //int[] disappear = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            //FindDisappearedNumbers(disappear);
            //int[][] twoD = new int[3][];
            //twoD[0] = new int[] { 1, 2, 3, 4 };
            //twoD[1] = new int[] { 5, 6, 7, 8 };
            //twoD[2] = new int[] { 9, 10, 11, 12 };
            //SpiralTraverse(twoD);
            //UniquePaths(2, 3);
            //HasSingleCycle();
            //int[] distances = { 1, 3, 10, 6, 7, 7, 2, 4 };
            int[] fuel = { 1, 1, 1, 1, 1, 1, 1, 1 };
            //ValidStartingCity(distances, fuel, 5);
            int[,] grapht = new int[,]{
                                        {1, 0, 0, 1, 0},
                                        {1, 0, 1, 0, 0},
                                        {0, 0, 1, 0, 1},
                                        {1, 0, 1, 0, 1},
                                        {1, 0, 1, 1, 0}
                                      };
            int[,] graph = new int[,] { { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0 } };

            Console.WriteLine(RiverSizes(graph));
            //Console.WriteLine("babad".Substring(0, 5));
            //int[,] matrix = new int[3, 2];
            //Console.WriteLine(matrix.Length);
            //Console.WriteLine(matrix.GetLength(1));
            for (int i = 0; i < grapht.GetLength(0); i++)
            {
                for (int j = 0; j < grapht.GetLength(1); j++)
                {
                    Console.Write(grapht[i, j]);
                }
                Console.WriteLine("\n");
            }
            FindThreeLargestNumbers(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 });
            GraphConstructionAndTraversal(3, 2);
            //Console.WriteLine(WaterArea(new int[0]));
            //GenerateParenthesis(3);
            int[] array = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(SearchInsert(new int[] { 1, 3 }, 2));
            int[] array2 = new int[] { 7, -5, -2, 11, 15, -6, 3 };
            List<int> array3 = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
            int[] distanceArray = new int[] { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };
            Console.WriteLine(distanceArray.Where(x => x == 3).FirstOrDefault());
            //Console.WriteLine(MinNumberOfJumps(distanceArray));
            ListNode listNode = new ListNode(8);
            listNode.next = new ListNode(9);
            listNode.next.next = new ListNode(9);
            listNode.next.next.next = new ListNode(9);

            ListNode listNode2 = new ListNode(9);
            listNode2.next = new ListNode(9);
            listNode2.next.next = new ListNode(9);
            //Console.WriteLine(StrStr("stackoverflow", "overr"));
            //AddTwoNumbers(listNode, listNode2);

            //TaskAssignment(3, array3);
            //MoveElementToEnd(array3, 2);
            //SmallestDifference(array, array2);
            //TwoSum(array, array2, 0);
            //Console.WriteLine(MaxProfit(array));
            //Console.WriteLine($"Fibonacci number: {Factorial(6)}");
            //Console.WriteLine("abc".Reverse().ToString());
            int[] sampleArray2 = new int[] { 45, 61, 71, 72, 73, 0, 1, 21, 33, 37 };
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };
            //Console.WriteLine($"Median is: {FindMedianSortedArrays(nums1, nums2)}");
            int target = 5;

            BinarySearchTree root = new BinarySearchTree(13);
            root.Insert(10);
            root.Insert(5);
            root.Insert(2);
            root.Insert(6);
            root.Insert(15);
            root.Insert(22);
            root.Insert(1);
            //Console.WriteLine($"Min Value : {root.GetMinValue()}");
            List<int> inOrderTraverse = new List<int>();
            //InOrderTraverse(root, inOrderTraverse);
            //LevelOrderTraversal(root);
            foreach (var item in inOrderTraverse)
            {
                Console.WriteLine($"In Order : {item}");
            }

            //Console.WriteLine($"Searching 11: {SearchInBST(root, 11)}");
            //Console.WriteLine($"Searching 13: {SearchInBST(root, 13)}");
            //Console.WriteLine(ClosestValueInBST(bST, bST.Value, 0));
            //Console.WriteLine($"Depth of tree: {NodeDepthBinaryTree(root)}");

            List<int> brancSum = new List<int>();
            //BranchSum(root, brancSum, 0);
            //foreach (var item in brancSum)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Tree height is: {TreeHeight(root)}");
            //Console.WriteLine($"Max substring length: {LongestSubStringWithoutRepeatingCharacters("dvdf")}");
            //QuickSort(array, 0, array.Length - 1);

            //var res = MergeSort(array);

            //var response = ShiftedBinarySearch(sampleArray2, 21);
            //SortedSquares(new int[] { -6, -3, 0, 2, 4, 7 });
            //Console.WriteLine(response);

            //Console.Read();
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = start;
            int Left = start + 1;
            int Right = end;
            while (Right >= Left)
            {
                if (array[Left] > array[pivot] && array[Right] < array[pivot])
                {
                    SwapNumbers(array, Left, Right);
                }
                if (array[Left] <= array[pivot])
                {
                    Left++;
                }
                if (array[Right] >= array[pivot])
                {
                    Right--;
                }
            }

            SwapNumbers(array, pivot, Right);
            bool leftIsSmall = (Right - 1 - start) < (end - (Right + 1));
            if (leftIsSmall)
            {
                QuickSort(array, start, Right - 1);
                QuickSort(array, Right + 1, end);
            }
            else
            {
                QuickSort(array, start, Right - 1);
                QuickSort(array, Right + 1, end);
            }
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int t = targetSum - array[i];
                if (dic.ContainsValue(t))
                {
                    return new int[2] { dic.FirstOrDefault(x => x.Value == t).Key, i };
                }
            }
            return new int[0];
        }

        public static int BinarySearch(int[] array, int target)
        {
            // Write your code here.
            int min = 0;
            int max = array.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (target == array[mid])
                    return mid;
                else if (target > array[mid])
                {
                    min = mid + 1;
                }
                else if (target < array[mid])
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

        public static int[] BubbleSort(int[] array)
        {
            bool sorted = false;
            int counter = 0;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1 - counter; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
                counter++;
            }
            return array;
        }

        public static int[] SwapNumbers(int[] array, int Left, int Right)
        {
            array[Left] = array[Left] + array[Right];
            array[Right] = array[Left] - array[Right];
            array[Left] = array[Left] - array[Right];
            return array;
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int[] auxilaryArray = (int[])array.Clone();
            MergeSort(array, 0, array.Length - 1, auxilaryArray);
            return array;
        }

        public static void MergeSort(int[] mainArray, int start, int end, int[] auxilaryArray)
        {
            if (start == end)
            {
                return;
            }

            int mid = (start + end) / 2;

            MergeSort(auxilaryArray, start, mid, mainArray);
            MergeSort(auxilaryArray, mid + 1, end, mainArray);
            DoMerge(mainArray, start, mid, end, auxilaryArray);
        }

        public static void DoMerge(int[] mainArray, int start, int mid, int end, int[] auxilaryArray)
        {
            int k = start;
            int i = start;
            int j = mid + 1;
            while (i <= mid && j <= end)
            {
                if (auxilaryArray[i] <= auxilaryArray[j])
                {
                    mainArray[k] = auxilaryArray[i];
                    i++;
                }
                else
                {
                    mainArray[k] = auxilaryArray[j];
                    j++;
                }
                k++;
            }
            while (j <= end)
            {
                mainArray[k] = auxilaryArray[j];
                k++;
                j++;
            }

            while (i <= mid)
            {
                mainArray[k] = auxilaryArray[i];
                k++;
                i++;
            }
        }

        //[45, 61, 71, 72, 73, 0, 1, 21, 33, 37]
        public static int ShiftedBinarySearch(int[] array, int target)
        {
            if (array.Length == 0)
            {
                return -1;
            }
            int Left = 0;
            int Right = array.Length - 1;
            int mid = (Left + Right) / 2;
            while (Left <= Right)
            {
                mid = (Left + Right) / 2;
                if (target == array[mid])
                    return mid;
                if (array[Left] <= array[mid])
                {
                    if (target >= array[Left] && target < array[mid])
                    {
                        Right = mid - 1;
                    }
                    else
                    {
                        Left = mid + 1;
                    }
                }
                else
                {
                    if (target <= array[Right] && target > array[mid])
                    {
                        Left = mid + 1;
                    }
                    else
                    {
                        Right = mid - 1;
                    }
                }
            }

            return -1;
        }

        public static void SortedSquares(int[] array)
        {
            int Left = 0;
            int Right = array.Length - 1;
            int[] sortedSquares = new int[array.Length];
            for (int i = sortedSquares.Length - 1; i > 0; i--)
            {
                if (Math.Abs(array[Left]) > Math.Abs(array[Right]))
                {
                    sortedSquares[i] = array[Left] * array[Left];
                    Left++;
                }
                else
                {
                    sortedSquares[i] = array[Right] * array[Right];
                    Right--;

                }
            }

            for (int i = 0; i < sortedSquares.Length; i++)
            {
                Console.WriteLine(sortedSquares[i]);
            }
        }

        public static List<int> InOrderTraverse(BinarySearchTree tree, List<int> array)
        {
            // Write your code here.
            if (tree.Left != null)
            {
                InOrderTraverse(tree.Left, array);
                array.Add(tree.Value);
            }
            else
            {
                array.Add(tree.Value);
            }
            if (tree.Right != null)
                InOrderTraverse(tree.Right, array);
            return array;
        }

        public static List<int> PreOrderTraverse(BinarySearchTree tree, List<int> array)
        {
            // Write your code here.
            array.Add(tree.Value);
            if (tree.Left != null)
            {
                PreOrderTraverse(tree.Left, array);
            }
            if (tree.Right != null)
            {
                PreOrderTraverse(tree.Right, array);
            }
            return array;
        }

        public static List<int> PostOrderTraverse(BinarySearchTree tree, List<int> array)
        {
            // Write your code here.
            if (tree.Left != null)
            {
                PostOrderTraverse(tree.Left, array);
            }
            if (tree.Right != null)
            {
                PostOrderTraverse(tree.Right, array);
            }
            array.Add(tree.Value);
            return array;
        }

        public static List<int> InsertTreeIntoDictionary(BinarySearchTree tree, List<int> dictionary)
        {
            if (tree.Left != null)
            {
                InsertTreeIntoDictionary(tree.Left, dictionary);
                dictionary.Add(tree.Value);
            }
            else
            {
                dictionary.Add(tree.Value);
            }
            if (tree.Right != null)
            {
                InsertTreeIntoDictionary(tree.Right, dictionary);

            }
            return dictionary;
        }

        public static bool SearchInBST(BinarySearchTree tree, int Value)
        {
            if (Value == tree.Value)
            {
                return true;
            }

            if (Value < tree.Value)
            {
                if (tree.Left == null)
                    return false;
                else
                    return SearchInBST(tree.Left, Value);
            }
            else if (Value > tree.Value)
            {
                if (tree.Right == null)
                    return false;
                else
                    return SearchInBST(tree.Right, Value);
            }
            else
                return false;
        }

        public static int ClosestValueInBST(BinarySearchTree tree, int closest, int target)
        {
            if (Math.Abs(tree.Value - target) < Math.Abs(closest - target))
                closest = tree.Value;
            if (target > tree.Value)
            {
                if (tree.Right != null)
                {
                    return ClosestValueInBST(tree.Right, closest, target);
                }
                else
                {
                    return closest;
                }
            }
            else if (target < tree.Value)
            {
                if (tree.Left != null)
                {
                    return ClosestValueInBST(tree.Left, closest, target);
                }
                else
                {
                    return closest;
                }
            }
            return closest;
        }

        public static int NodeDepthBinaryTree(BinarySearchTree tree)
        {
            int sum = 0;
            Stack<Level> bstStack = new Stack<Level>();

            bstStack.Push(new Level(tree, 0));
            while (bstStack.Count > 0)
            {
                Level top = bstStack.Pop();
                var node = top.root;
                int depth = top.depth;
                if (node == null)
                {
                    continue;
                }
                sum += depth;
                bstStack.Push(new Level(node.Left, depth + 1));
                bstStack.Push(new Level(node.Right, depth + 1));
            }
            return sum;
        }

        public static void BranchSum(BinarySearchTree tree, List<int> branchSum, int sum)
        {

            sum += tree.Value;
            if (tree.Left == null && tree.Right == null)
            {
                branchSum.Add(sum);
            }
            if (tree.Left != null)
            {
                BranchSum(tree.Left, branchSum, sum);
            }
            if (tree.Right != null)
            {
                BranchSum(tree.Right, branchSum, sum);
            }
        }

        public static void TwoSum(int[] a1, int[] a2, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < a1.Length; i++)
            {
                if (!dic.ContainsKey(a1[i]))
                {
                    dic.Add(a1[i], 0);
                }
            }
            for (int j = 0; j < a2.Length; j++)
            {
                int lookup = target - a2[j];
                if (dic.ContainsKey(lookup))
                {
                    Console.WriteLine("Pair Found");
                }
            }
        }

        public static int MaxProfit(int[] array)
        {
            int maxProfit = 0;
            int minPrice = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - minPrice > maxProfit)
                {
                    maxProfit = array[i] - minPrice;
                }
                if (array[i] < minPrice)
                {
                    minPrice = array[i];
                }
            }
            return maxProfit;
        }

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

        public static void LevelOrderTraversal(BinarySearchTree tree)
        {
            Queue<BinarySearchTree> queus = new Queue<BinarySearchTree>();
            queus.Enqueue(tree);
            while (queus.Count > 0)
            {
                var tr = queus.Dequeue();
                Console.WriteLine(tr.Value);
                if (tr.Left != null)
                    queus.Enqueue(tr.Left);
                if (tr.Right != null)
                    queus.Enqueue(tr.Right);
            }
        }

        public static int TreeHeight(BinarySearchTree tree)
        {
            if (tree == null)
            {
                return 0;
            }
            int lH = TreeHeight(tree.Left);
            int rh = TreeHeight(tree.Right);
            if (lH > rh)
            {
                return lH + 1;
            }
            else
            {
                return rh + 1;
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

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0; int j = 0;
            int k = 0;
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    mergedArray[k] = nums1[i];
                    i++;
                    k++;
                }
                else if (nums2[j] < nums1[i])
                {
                    mergedArray[k] = nums2[j];
                    j++;
                    k++;
                }
                else
                {
                    mergedArray[k] = nums2[j];
                    k++;
                    j++;
                    mergedArray[k] = nums1[i];
                    k++;
                    i++;
                }
            }
            while (i < nums1.Length)
            {
                mergedArray[k] = nums1[i];
                i++;
                k++;
            }

            while (j < nums2.Length)
            {
                mergedArray[k] = nums2[j];
                j++;
                k++;
            }
            if (mergedArray.Length % 2 == 0)
            {
                return (mergedArray[mergedArray.Length / 2] + mergedArray[(mergedArray.Length / 2) - 1]) / 2.0;
            }
            else
            {
                return mergedArray[mergedArray.Length / 2];
            }
        }

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

        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            int minimumDifference = Int32.MaxValue; //Math.Abs(arrayOne[0] - arrayTwo[0]);
            int[] resultAarray = new int[2];
            int i = 0, j = 0;
            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                int difference = Math.Abs(arrayOne[i] - arrayTwo[j]);
                if (difference == 0)
                {
                    return new int[] { arrayOne[i], arrayTwo[j] };
                }
                if (difference < minimumDifference)
                {
                    minimumDifference = difference;
                    resultAarray[0] = arrayOne[i];
                    resultAarray[1] = arrayTwo[j];
                }
                if (arrayOne[i] < arrayTwo[j])
                    i++;
                else
                    j++;
            }
            Console.WriteLine($"Minimum difference :{minimumDifference}");
            return resultAarray;
        }

        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            // Write your code here.
            int left = 0;
            int right = array.Count - 1;
            while (right >= left)
            {
                if (array[left] == toMove && array[right] == toMove)
                {
                    right--;
                }
                else if (array[left] != toMove && array[right] == toMove)
                {
                    right--;
                    left++;
                }
                else if (array[left] != toMove && array[right] != toMove)
                {
                    left++;
                }
                else if (array[left] == toMove && array[right] != toMove)
                {
                    int temp = array[right];
                    array[right] = array[left];
                    array[left] = temp;
                    left++;
                    right--;
                }

            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }

        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            List<int[]> response = new List<int[]>();
            Array.Sort(array);
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                while (right > left)
                {
                    int sum = array[i] + array[left] + array[right];
                    if (sum == targetSum)
                    {
                        response.Add(new int[] { array[i], array[left], array[right] });
                        left++;
                        right--;
                    }
                    else if (sum > targetSum)
                    {
                        right--;
                    }
                    else if (sum < targetSum)
                    {
                        left++;
                    }

                }
            }
            // Write your code here.
            return response;
        }

        public static int LongestPeak(int[] array)
        {
            // Write your code here.
            int longestPeak = 0;
            for (int i = 1; i < array.Length - 2; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    int left = i - 1;
                    int right = i + 1;
                    while ((left > 0 && right < array.Length - 1) &&
                        array[left + 1] < array[left] || array[right - 1] < array[right])
                    {

                    }
                }
            }
            return -1;
        }

        public static List<List<int>> TaskAssignment(int k, List<int> tasks)
        {
            List<int> sortedTasks = tasks;
            Dictionary<int, List<int>> valueIndexes = GetIndicesDictionary(tasks);
            sortedTasks.Sort();
            List<List<int>> pairedTasks = new List<List<int>>();
            for (int i = 0; i < k; i++)
            {
                var task1 = sortedTasks[i];
                var task1IndexList = valueIndexes[task1];
                var task1Index = task1IndexList.FirstOrDefault();
                task1IndexList.RemoveAt(task1IndexList.Count - 1);

                var task2 = sortedTasks[sortedTasks.Count - 1 - i];
                var task2IndexList = valueIndexes[task2];
                var task2Index = task2IndexList.FirstOrDefault();
                task2IndexList.RemoveAt(task2IndexList.Count - 1);

                pairedTasks.Add(new List<int> { task1Index, task2Index });
            }

            return new List<List<int>>();
        }

        public static Dictionary<int, List<int>> GetIndicesDictionary(List<int> tasks)
        {
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (keyValuePairs.ContainsKey(tasks[i]))
                {
                    keyValuePairs[tasks[i]].Add(i);
                }
                else
                {
                    keyValuePairs.Add(tasks[i], new List<int> { i });
                }
            }

            return keyValuePairs;
        }

        public static int NodeDepths(BinarySearchTree tree)
        {
            if (tree == null)
            {
                return 0;
            }
            int leftNodeDepth = NodeDepths(tree.Left);
            int rightNodeDepth = NodeDepths(tree.Right);
            if (leftNodeDepth > rightNodeDepth)
            {
                return leftNodeDepth + 1;
            }
            else
            {
                return rightNodeDepth + 1;
            }
        }

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // Write your code here.
            var current = linkedList;
            while (current != null)
            {
                var nextDistinct = current.next;
                while (nextDistinct != null && nextDistinct.value == current.value)
                {
                    nextDistinct = nextDistinct.next;
                }
                current.next = nextDistinct;
                current = nextDistinct;
            }
            return linkedList;
        }

        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            // Write your code here.
            StringBuilder listOne = new StringBuilder("");
            StringBuilder listTwo = new StringBuilder("");
            var current = linkedListOne;
            while (current != null)
            {
                listOne.Append(current.value);
                current = current.next;
            }
            current = linkedListTwo;
            while (current != null)
            {
                listTwo.Append(current.value);
                current = current.next;
            }
            var num1Array = listOne.ToString().ToCharArray();
            var num2Array = listTwo.ToString().ToCharArray();
            Array.Reverse(num2Array);
            Array.Reverse(num1Array);

            var sumCharArray = (Convert.ToInt32(num1Array.ToString()) + Convert.ToInt32(num2Array.ToString())).ToString().ToCharArray();
            Array.Reverse(sumCharArray);
            string sum = sumCharArray.ToString();
            LinkedList response = new LinkedList(Convert.ToInt32(sum[0]));
            current = response.next;
            for (int i = 1; i < sum.Length; i++)
            {
                current.next = new LinkedList(Convert.ToInt32(sum[0]));
                current = current.next;
            }
            return response;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (keyValues.ContainsKey(difference))
                {
                    return new int[] { keyValues[nums[i]], i };
                }
                else
                {
                    keyValues.Add(nums[i], i);
                }
            }
            return new int[0];
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)

        {

            ListNode result = new ListNode();
            ListNode resultCurrent = result;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = 0;
                if (l1 != null && l2 != null)
                {
                    sum = l1.val + l2.val + carry;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null)
                {
                    sum = l1.val + carry;
                    l1 = l1.next;
                }
                else if (l2 != null)
                {
                    sum = l2.val + carry;
                    l2 = l2.next;
                }
                else if (carry > 0)
                {
                    sum = carry;
                }

                if (sum >= 10)
                {
                    resultCurrent.val = sum % 10;
                    carry = 1;
                }
                else
                {
                    resultCurrent.val = sum;
                    carry = 0;
                }
                if (l1 != null || l2 != null || carry > 0)
                {
                    resultCurrent.next = new ListNode();
                    resultCurrent = resultCurrent.next;
                }
            }
            return result;
        }

        public int MaxProfitII(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] - prices[i] > 0)
                {
                    maxProfit += prices[i + 1] - prices[i];
                }

            }
            return maxProfit;
        }

        public int MaxProfitIII(int[] prices)
        {
            int transaction1 = 0;
            int transaction2 = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                int tempProfit = prices[i + 1] - prices[i];
                if (tempProfit > 0)
                {
                    if (tempProfit >= transaction1)
                    {
                        int temp = transaction1;
                        transaction1 = tempProfit;
                        transaction2 = temp;
                    }
                    else if (tempProfit >= transaction2)
                    {
                        transaction2 = tempProfit;
                    }
                }

            }
            return (transaction2 + transaction1);
        }

        public int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            int duplicates = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValues.ContainsKey(nums[i]))
                {
                    duplicates += 1;
                }
                else
                {
                    keyValues.Add(nums[i], i);
                }
            }
            return duplicates;
        }

        public static int ProductSum(List<object> array, int level)
        {
            // Write your code here.
            int productSum = 0;
            foreach (var item in array)
            {
                if (item is IList<object>)
                {
                    productSum += ProductSum((List<object>)item, level + 1);
                }
                else
                {
                    productSum += (level * (int)item);
                }

            }
            return productSum;
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

        public static int ShiftedBinarySearchII(int[] nums, int target)
        {
            // Write your code here.
            int response = ShiftedBinarySearchII(nums, target, 0, nums.Length - 1);
            return response;
        }

        public static int ShiftedBinarySearchII(int[] nums, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (nums[left] <= nums[middle])
                {
                    if (target < nums[middle] && target >= nums[left])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                else
                {
                    if (target > nums[middle] && target <= nums[right])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
            }
            return -1;
        }

        public List<int> SunsetViews(int[] buildings, string direction)
        {
            // Write your code here.
            List<int> response = new List<int>();
            int maxHeight = 0;
            if (direction == "EAST")
            {
                for (int i = buildings.Length - 1; i > 0; i--)
                {
                    if (buildings[i] > maxHeight)
                    {
                        response.Add(buildings[i]);
                        maxHeight = buildings[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < buildings.Length; i++)
                {
                    if (buildings[i] > maxHeight)
                    {
                        response.Prepend(buildings[i]);
                        maxHeight = buildings[i];
                    }
                }
            }
            if (direction == "EAST")
            {
                response.Reverse();
            }
            return response;
        }

        public static int MinNumberOfJumps(int[] array)
        {
            // Write your code here.
            //"array": [3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3]
            if (array.Length <= 1)
            {
                return 0;
            }
            int jumps = 0;
            int maxReach = array[0];
            int steps = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                maxReach = Math.Max(maxReach, i + array[i]);
                steps--;
                if (steps == 0)
                {
                    jumps++;
                    steps = maxReach - i;
                }
            }
            return jumps + 1;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (end >= start)
            {
                mid = (end + start) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return mid;
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

        public static int MinimumPassesOfMatrix()
        {
            int[][] mat = new int[3][];
            mat[0] = new int[] { 0, -1, -3, 2, 0 };
            mat[1] = new int[] { 1, -2, -5, -1, -3 };
            mat[2] = new int[] { 3, 0, 0, -4, -1 };
            var nextPassQueue = GetAllPositiveValues(mat);
            int passes = 0;
            while (nextPassQueue.Count > 0)
            {
                var currentPassQueue = nextPassQueue;
                nextPassQueue = new List<int[]>();

                while (currentPassQueue.Count > 0)
                {
                    var value = currentPassQueue[0];
                    currentPassQueue.RemoveAt(0);
                    int currentRow = value[0];
                    int currentColumn = value[1];

                    var adjacentPositions = GetAdjacentValues(mat, currentRow, currentColumn);
                    foreach (var item in adjacentPositions)
                    {
                        int row = item[0];
                        int col = item[1];
                        int val = mat[row][col];
                        if (val < 0)
                        {
                            mat[row][col] = val * -1;
                            nextPassQueue.Add(new int[] { row, col });
                        }
                    }
                }
                passes++;
            }
            return (!ContainsNegative(mat) ? passes - 1 : -1);
        }

        public static bool ContainsNegative(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 0) return true;
                }
            }
            return false;
        }

        public static List<int[]> GetAdjacentValues(int[][] matrix, int row, int col)
        {
            List<int[]> result = new List<int[]>();
            if (row > 0)
            {
                result.Add(new int[] { row - 1, col });
            }
            if (row < matrix.Length - 1)
            {
                result.Add(new int[] { row + 1, col });
            }
            if (col < matrix[row].Length - 1)
            {
                result.Add(new int[] { row, col + 1 });
            }
            if (col > 0)
            {
                result.Add(new int[] { row, col - 1 });
            }
            return result;
        }

        public static List<int[]> GetAllPositiveValues(int[][] matrix)
        {
            List<int[]> result = new List<int[]>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        result.Add(new int[] { row, col });
                    }
                }
            }
            return result;
        }

        public static int WaterArea(int[] heights)
        {
            // Write your code here.
            //brute force solution
            if (heights == null || heights.Length <= 1)
            {
                return 0;
            }
            int[] leftMaxList = new int[heights.Length];
            int[] rightMaxList = new int[heights.Length];
            int totalWater = 0;
            int leftMax = heights[0];
            for (int i = 0; i < heights.Length; i++)
            {
                if (i == 0)
                {
                    leftMaxList[i] = 0;
                }
                else
                {
                    leftMax = Math.Max(leftMax, heights[i - 1]);
                    leftMaxList[i] = leftMax;
                }
                Console.WriteLine(leftMaxList[i]);
            }
            int rightMax = heights[heights.Length - 1];
            for (int i = heights.Length - 1; i >= 0; i--)
            {
                if (i == heights.Length - 1)
                {
                    rightMaxList[i] = 0;
                }
                else
                {
                    rightMax = Math.Max(rightMax, heights[i + 1]);
                    rightMaxList[i] = rightMax;
                }
                Console.WriteLine(rightMaxList[i]);
            }
            for (int i = 0; i < heights.Length; i++)
            {
                int minPillar = Math.Min(leftMaxList[i], rightMaxList[i]);
                if (minPillar > heights[i])
                {
                    totalWater += minPillar - heights[i];
                }
            }
            return totalWater;
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

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int maxSubArraySum = 0;


            return maxSubArraySum;
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

        public static int NumberOfWaysToTraverseGraph(int width, int height)
        {
            // Write your code here.
            int[,] graph = new int[height + 1, width + 1];
            for (int i = 1; i < width + 1; i++)
            {
                for (int j = 1; j < height + 1; j++)
                {
                    if (i == 1 || j == 1)
                    {
                        graph[i, j] = 1;
                    }
                    else
                    {
                        int leftUp = graph[i - 1, j];
                        int rightUp = graph[i, j - 1];
                        graph[i, j] = leftUp + rightUp;
                    }
                }
            }
            return graph[height, width];
        }

        public static void GraphConstructionAndTraversal(int width, int height)
        {
            int[,] graph = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    graph[i, j] = i * j;
                    Console.WriteLine(graph[i, j]);
                }
            }
        }

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            string currentBestTeam = "";
            int currentBestTeamScore = 0;
            Dictionary<string, int> languageWins = new Dictionary<string, int>();
            languageWins.Add(currentBestTeam, currentBestTeamScore);
            for (int i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                var result = results[i];
                var home = competition[0];
                var away = competition[1];
                var langWon = result == 1 ? home : away;

                if (languageWins.ContainsKey(langWon))
                {
                    languageWins[langWon] += 1;
                }
                else
                {
                    languageWins.Add(langWon, 1);
                }

                if (languageWins[langWon] > currentBestTeamScore)
                {
                    currentBestTeam = langWon;
                    currentBestTeamScore = languageWins[langWon];
                }
            }
            return currentBestTeam;
        }

        public static int NonConstructibleChange(int[] coins)
        {
            // Write your code here.
            if (coins.Length == 0)
                return 1;
            int currentChangeCreated = 0;
            Array.Sort(coins);
            foreach (var item in coins)
            {
                if (item > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }
                currentChangeCreated += item;
            }

            return currentChangeCreated + 1;
        }

        public int MinimumWaitingTime(int[] queries)
        {
            // Write your code here.
            Array.Sort(queries);
            int[] resultArray = new int[queries.Length];
            resultArray[0] = 0;
            int waitingTime = 0;
            for (int i = 1; i < queries.Length; i++)
            {
                waitingTime += queries[i];
                resultArray[i] = waitingTime;
            }
            int totalWaitingTime = 0;
            for (int i = 0; i < resultArray.Length; i++)
            {
                totalWaitingTime += resultArray[i];
            }
            return totalWaitingTime;
        }

        public static int[] FindThreeLargestNumbers(int[] array)
        {
            // Write your code here.
            //int[] maxArray = new int[] { array[0], array[1], array[2] };
            //Array.Sort(maxArray);
            //for (int i = 3; i < array.Length; i++)
            //{
            //    if (array[i] >= maxArray[2])
            //    {
            //        int temp = maxArray[2];
            //        int temp1 = maxArray[1];
            //        maxArray[2] = array[i];
            //        maxArray[1] = temp;
            //        maxArray[0] = temp1;
            //    }
            //    else if (array[i] >= maxArray[1])
            //    {
            //        int temp = maxArray[1];
            //        maxArray[1] = array[i];
            //        maxArray[0] = temp;
            //    }
            //    else if (array[i] >= maxArray[0])
            //    {
            //        maxArray[0] = array[i];
            //    }
            //}
            int[] maxArray = new int[3] { Int32.MinValue, Int32.MinValue, array[0] };
            int lastLargest = array[0];
            //maxArray[2] = lastLargest;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= lastLargest)
                {
                    maxArray[2] = array[i];
                    array[0] = maxArray[1];
                    maxArray[1] = lastLargest;
                    lastLargest = array[i];
                }
                else if (array[i] >= maxArray[1])
                {
                    maxArray[0] = maxArray[1];
                    maxArray[1] = array[i];
                }
                else if (array[i] > maxArray[0])
                {
                    maxArray[0] = array[i];
                }

            }
            return maxArray;
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

        public static List<int> RiverSizes(int[,] matrix)
        {
            // Write your code here.
            List<int> riverSizes = new List<int>();
            Dictionary<string, int> visited = new Dictionary<string, int>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1 && !visited.ContainsKey($"{row}{col}"))
                    {
                        visited.Add($"{row}{col}", 0);
                        int length = CheckAdjacent(matrix, row, col, visited, 1);
                        riverSizes.Add(length);
                    }
                }
            }
            return riverSizes;
        }

        public static int CheckAdjacent(int[,] matrix, int row, int col, Dictionary<string, int> visited, int riverLength)
        {
            if (col + 1 < matrix.GetLength(1) && !visited.ContainsKey($"{row}{col + 1 }"))
            {
                int right = matrix[row, col + 1];
                if (right == 1)
                {
                    visited.Add($"{row}{col + 1}", 0);
                    riverLength = CheckAdjacent(matrix, row, col + 1, visited, riverLength + 1);
                }
            }
            if (col > 0 && !visited.ContainsKey($"{row}{col - 1}"))
            {
                int left = matrix[row, col - 1];
                if (left == 1)
                {
                    visited.Add($"{row}{col - 1}", 0);
                    riverLength = CheckAdjacent(matrix, row, col - 1, visited, riverLength + 1);
                }
            }
            if (row > 0 && !visited.ContainsKey($"{row - 1}{col}"))
            {
                int top = matrix[row - 1, col];
                if (top == 1)
                {
                    visited.Add($"{row - 1}{col}", 0);
                    riverLength = CheckAdjacent(matrix, row - 1, col, visited, riverLength + 1);
                }
            }
            if (row + 1 < matrix.GetLength(0) && !visited.ContainsKey($"{row + 1}{col}"))
            {
                int bottom = matrix[row + 1, col];
                if (bottom == 1)
                {
                    visited.Add($"{row + 1}{col}", 0);
                    riverLength = CheckAdjacent(matrix, row + 1, col, visited, riverLength + 1);
                }
            }
            return riverLength;
        }

        public static int NumIslands(char[][] grid)
        {
            int Islands = 0;
            Dictionary<string, int> visited = new Dictionary<string, int>();
            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (!visited.ContainsKey($"{row}{col}"))
                    {
                        if (grid[row][col] == '1')
                        {
                            visited.Add($"{row}{col}", 0);
                            CheckAdjacent2D(grid, row, col, visited, 1);
                            Islands++;
                        }
                        else
                            visited.Add($"{row}{col}", 0);
                    }
                }
            }
            return Islands;
        }

        public static int CheckAdjacent2D(char[][] matrix, int row, int col, Dictionary<string, int> visited, int riverLength)
        {
            if (col + 1 < matrix[row].Length && !visited.ContainsKey($"{row}{col + 1 }"))
            {
                char right = matrix[row][col + 1];
                if (right == '1')
                {
                    visited.Add($"{row}{col + 1}", 0);
                    riverLength = CheckAdjacent2D(matrix, row, col + 1, visited, riverLength + 1);
                }
            }
            if (col > 0 && !visited.ContainsKey($"{row}{col - 1}"))
            {
                char left = matrix[row][col - 1];
                if (left == '1')
                {
                    visited.Add($"{row}{col - 1}", 0);
                    riverLength = CheckAdjacent2D(matrix, row, col - 1, visited, riverLength + 1);
                }
            }
            if (row > 0 && !visited.ContainsKey($"{row - 1}{col}"))
            {
                char top = matrix[row - 1][col];
                if (top == '1')
                {
                    visited.Add($"{row - 1}{col}", 0);
                    riverLength = CheckAdjacent2D(matrix, row - 1, col, visited, riverLength + 1);
                }
            }
            if (row + 1 < matrix.Length && !visited.ContainsKey($"{row + 1}{col}"))
            {
                char bottom = matrix[row + 1][col];
                if (bottom == '1')
                {
                    visited.Add($"{row + 1}{col}", 0);
                    riverLength = CheckAdjacent2D(matrix, row + 1, col, visited, riverLength + 1);
                }
            }
            return riverLength;
        }

        int rows = 0;
        int cols = 0;
        public int NumIslandsII(char[][] grid)
        {
            int count = 0;
            rows = grid.Length;
            if (rows == 0) return 0;
            cols = grid[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    if (grid[i][j] == '1')
                    {
                        DFSMarking(grid, i, j);
                        ++count;
                    }
            }
            return count;
        }

        private void DFSMarking(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= rows || j >= cols || grid[i][j] != '1') return;
            grid[i][j] = '0';
            DFSMarking(grid, i + 1, j);
            DFSMarking(grid, i - 1, j);
            DFSMarking(grid, i, j + 1);
            DFSMarking(grid, i, j - 1);
        }

        public static AncestralTree GetYoungestCommonAncestor(
        AncestralTree topAncestor,
        AncestralTree descendantOne,
        AncestralTree descendantTwo
        )
        {
            List<AncestralTree> dOneAncestors = new List<AncestralTree>();
            List<AncestralTree> dTwoAncestors = new List<AncestralTree>();
            MakeAncestralList(dOneAncestors, descendantOne);
            MakeAncestralList(dTwoAncestors, descendantTwo);
            int i = 0;
            int j = 0;
            AncestralTree youngestAncestor = topAncestor;
            while (i < dOneAncestors.Count && j < dTwoAncestors.Count && dOneAncestors[i] == dTwoAncestors[j])
            {
                youngestAncestor = dOneAncestors[i];
                i++;
                j++;
            }
            return youngestAncestor;
        }
        public static void MakeAncestralList(List<AncestralTree> ancestors, AncestralTree decendant)
        {
            if (decendant.ancestor != null)
                MakeAncestralList(ancestors, decendant.ancestor);
            ancestors.Add(decendant);
        }

        /*
         * "edges": [
                        [1, 3],
                        [2, 3, 4],
                        [0],
                        [],
                        [2, 5],
                        []]
            0 -> 1, 3
            1 -> 2,3,4
            2 -> 0
        current = 1 
        visited = [0, 1]
        Stack = [0, 1]
        nieghbours = [2, 3, 4]
         */

        public bool CycleInGraph(int[][] edges)
        {
            // Write your code here.
            bool[] visited = new bool[edges.Length];
            bool[] currentlyInStack = new bool[edges.Length];
            Array.Fill(visited, false);
            Array.Fill(currentlyInStack, false);
            for (int row = 0; row < edges.Length; row++)
            {
                if (visited[row])
                {
                    continue;
                }
                if (DFSCycleII(edges, visited, currentlyInStack, row))
                    return true;
            }
            return false;
        }

        public bool DFSCycleII(int[][] edges, bool[] visited, bool[] currentlyInStack, int current)
        {
            visited[current] = true;
            currentlyInStack[current] = true;
            int[] neighbours = edges[current];
            foreach (var neighbour in neighbours)
            {
                if (currentlyInStack[neighbour])
                    return true;
                if (DFSCycleII(edges, visited, currentlyInStack, neighbour))
                    return true;

            }
            currentlyInStack[current] = false;
            return false;
        }

        public bool DFSCycle(int[][] edges, int row, int col, Dictionary<int, int> visitedStack)
        {
            if (row >= edges.Length || col >= edges[row].Length)
                return false;
            int vertex = edges[row][col];
            if (visitedStack.ContainsKey(vertex))
                return true;

            visitedStack.Add(vertex, col);
            if (DFSCycle(edges, vertex, 0, visitedStack))
                return true;
            return false;

        }

        /*
         * 
         "distances": [5, 25, 15, 10, 15],
         "fuel": [1, 2, 1, 0, 3],
         "mpg": 10

        start city = 1
        milesLeft = 5
        nextStop = 3
        distancens = 10
         */

        public static int ValidStartingCity(int[] distances, int[] fuel, int mpg)
        {
            // Write your code here.
            int startCity = 0;
            int milesLeft = fuel[0] * mpg;
            int nextStop = 1;
            while (nextStop != startCity)
            {
                if (milesLeft < distances[nextStop])
                {
                    startCity = nextStop;
                    milesLeft = fuel[startCity] * mpg;
                    if (nextStop == distances.Length - 1)
                    {
                        nextStop = 0;
                    }
                    else
                    {
                        nextStop++;
                    }
                }
                else
                {
                    milesLeft -= distances[nextStop];
                    milesLeft += (fuel[nextStop] * mpg);
                    if (nextStop == distances.Length - 1)
                        nextStop = 0;
                    else
                    {
                        nextStop++;
                    }
                }
            }
            return startCity;
        }

        public static bool HasSingleCycle()
        {
            // Write your code here.
            int[] array = new int[] { 10, 11, -6, -23, -2, 3, 88, 908, -26 };
            bool[] visited = new bool[array.Length];
            Array.Fill(visited, false);
            int idx = 0;
            while (!visited[idx])
            {
                visited[idx] = true;
                idx = (idx + array[idx]) % array.Length;
                if (idx < 0)
                {
                    idx = array.Length + idx;
                }
            }
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }
            if (idx != 0)
            {
                return false;
            }
            return true;
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

        public static int UniquePaths(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == 0)
                    {
                        matrix[row, col] = 1;
                    }
                    if (col == 0)
                    {
                        matrix[row, col] = 1;
                    }
                    if (row > 0 && col > 0)
                    {
                        matrix[row, col] = matrix[row - 1, col] + matrix[row, col - 1];
                    }
                }
            }

            return matrix[m - 1, n - 1];
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {

            //1, 2, 2, 3, 3, 4, 7, 8
            //[4,3,2,7,8,2,3,1]
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                int m = Math.Abs(nums[i]) - 1; // index start from 0
                nums[m] = nums[m] > 0 ? -nums[m] : nums[m];
            }
            List<int> res = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0) res.Add(i + 1);
            }
            return res;
        }

        public int FirstMissingPositive(int[] nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!pairs.ContainsKey(nums[i]))
                    pairs.Add(nums[i], i);
            }
            int minStartValue = 1;
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!pairs.ContainsKey(i))
                    break;
                minStartValue = i + 1;
            }
            return minStartValue;
        }

        public static int FindKthNumber(int m, int n, int k)
        {
            int[] allNumbers = new int[m * n];
            int index = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    allNumbers[index] = i * j;
                    index++;
                }
            }
            Array.Sort(allNumbers);
            return allNumbers[k - 1];
        }

        public static int FindKthLargestValueInBst(BinarySearchTree tree, int k)
        {
            // Write your code here.
            List<int> numbers = new List<int>();
            TraverseDescending(tree, k, numbers);
            return numbers[k - 1];
        }

        public static void TraverseDescending(BinarySearchTree tree, int k, List<int> numbers)
        {
            if (tree == null)
            {
                return;
            }
            TraverseDescending(tree.Right, k, numbers);
            if (numbers.Count == k)
            {
                return;
            }
            numbers.Add(tree.Value);
            TraverseDescending(tree.Left, k, numbers);
        }

        public static List<int> SpiralTraverse(int[,] array)
        {
            // Write your code here.
            List<int> response = new List<int>();
            int iteration = 0;
            int totalElemnts = array.GetLength(0) * array.GetLength(1);
            while (response.Count < totalElemnts)
            {
                //top
                int topRow = iteration;
                for (int col = iteration; col < array.GetLength(1) - iteration; col++)
                {
                    response.Add(array[topRow, col]);
                }
                //right
                int rightCol = array.GetLength(1) - iteration - 1;
                for (int row = iteration + 1; row < array.GetLength(0) - iteration; row++)
                {
                    response.Add(array[row, rightCol]);
                }
                //bottom
                int bottomRow = array.GetLength(0) - iteration - 1;
                for (int col = array.GetLength(1) - iteration - 2; col >= iteration; col--)
                {
                    response.Add(array[bottomRow, col]);
                }
                //left
                int leftCol = iteration;
                for (int row = array.GetLength(0) - iteration - 2; row > iteration; row--)
                {
                    response.Add(array[row, leftCol]);
                }
                iteration++;
            }

            return response;
        }

        public static List<int> SpiralTraverse(int[][] array)
        {
            // Write your code here.
            /*
             * {{1,2,3,4}
             * {5,6,7,8}
             * {9,10,11,12}
             * }
             * 
             */
            List<int> response = new List<int>();
            int iteration = 0;
            int totalElemnts = array.Length * array[0].Length;
            while (response.Count < totalElemnts)
            {
                //top
                //if (totalElemnts == response.Count) break;
                int topRow = iteration;
                for (int col = iteration; col < array[topRow].Length - iteration; col++)
                {
                    response.Add(array[topRow][col]);
                }
                //if (totalElemnts == response.Count) break;
                //right
                int rightCol = array[0].Length - iteration - 1;
                for (int row = iteration + 1; row < array.Length - iteration; row++)
                {
                    response.Add(array[row][rightCol]);
                }
                //if (totalElemnts == response.Count) break;
                //bottom
                int bottomRow = array.Length - iteration - 1;
                for (int col = array[0].Length - iteration - 2; col >= iteration; col--)
                {
                    response.Add(array[bottomRow][col]);
                }
                //if (totalElemnts == response.Count) break;
                //left
                int leftCol = iteration;
                for (int row = array.Length - iteration - 2; row > iteration; row--)
                {
                    response.Add(array[row][leftCol]);
                }
                iteration++;
            }

            return response;
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

        //temperatures = [73,74,75,71,69,72,76,73]
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] days = new int[temperatures.Length];
            Stack<int> hightTemp = new Stack<int>();
            for (int i = 0; i < temperatures.Length; i++)
            {

                while (hightTemp.Count > 0 && temperatures[i] > temperatures[hightTemp.Peek()])
                {
                    int idx = hightTemp.Pop();
                    days[idx] = i - idx;
                }

                if (i == temperatures.Length - 1)
                {
                    days[i] = 0;
                }
                else
                {
                    if (temperatures[i + 1] > temperatures[i])
                        days[i] = 1;
                    else
                    {
                        days[i] = 0;
                        hightTemp.Push(i);
                    }
                }
            }

            return days;
        }

        //public static IList<IList<string>> GroupAnagrams(string[] strs)
        //{

        //}

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

        public static bool Exist(char[][] board, string word)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == word[0])
                    {
                        Dictionary<string, int> visited = new Dictionary<string, int>();
                        visited.Add($"{row}{col}", 0);
                        if (Exist(board, word, row, col, 1, visited))
                            return true;
                    }
                }
            }

            return false;
        }



        public static bool Exist(char[][] board, string word, int row, int col, int index, Dictionary<string, int> visited)
        {
            //if (row >= board.Length || col >= board[row].Length || row < 0 || col < 0)
            //    return false;
            //right
            if (index >= word.Length)
            {
                return true;
            }
            if (col < board[0].Length - 1 && board[row][col + 1] == word[index] && !visited.ContainsKey($"{row}{col + 1}"))
            {
                visited.Add($"{row}{col + 1}", 0);
                if (Exist(board, word, row, col + 1, index + 1, visited))
                    return true;
                else
                    visited.Remove($"{row}{col + 1}");
            }

            //bottom
            if (row < board.Length - 1 && board[row + 1][col] == word[index] && !visited.ContainsKey($"{row + 1}{col}"))
            {
                visited.Add($"{row + 1}{col}", 0);
                if (Exist(board, word, row + 1, col, index + 1, visited))
                    return true;
                else
                    visited.Remove($"{row + 1}{col}");
            }

            //left
            if (col > 0 && board[row][col - 1] == word[index] && !visited.ContainsKey($"{row}{col - 1}"))
            {
                visited.Add($"{row}{col - 1}", 0);
                if (Exist(board, word, row, col - 1, index + 1, visited))
                    return true;
                else
                    visited.Remove($"{row}{col - 1}");
            }

            //top

            if (row > 0 && board[row - 1][col] == word[index] && !visited.ContainsKey($"{row - 1}{col}"))
            {
                visited.Add($"{row - 1}{col}", 0);
                if (Exist(board, word, row - 1, col, index + 1, visited))
                    return true;
                else
                    visited.Remove($"{row - 1}{col}");
            }

            return false;
        }

        //[1,1,2,3,3,4,4,8,8]
        //[3,3,10,7,7,11,11]
        //[1,1,2]
        public static int SingleNonDuplicate(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (mid % 2 == 1)
                    mid--;

                // We didn't find a pair. The single element must be on the left.
                // (pipes mean start & end)
                // Example: |0 1 1 3 3 6 6|
                //               ^ ^
                // Next:    |0 1 1|3 3 6 6
                if (nums[mid] != nums[mid + 1])
                    end = mid;

                // We found a pair. The single element must be on the right.
                // Example: |1 1 3 3 5 6 6|
                //               ^ ^
                // Next:     1 1 3 3|5 6 6|
                else
                    start = mid + 2;
            }
            return nums[start];
        }

        public static BinarySearchTree GetPredecessorInOrderTraversal(BinarySearchTree root, int value)
        {
            return new BinarySearchTree();
        }

        public BinarySearchTree FindNextHelper(BinarySearchTree root)
        {
            root = root.Right;
            while (root != null && root.Left != null)
                root = root.Left;
            return root;
        }
        public BinarySearchTree DeleteNode(BinarySearchTree root, int key)
        {
            if (root == null)
                return root;

            if (root.Value == key)
            {
                if (root.Left == null)
                    return root.Right;
                if (root.Right == null)
                    return root.Left;
                BinarySearchTree successor = FindNextHelper(root);
                root.Value = successor.Value;
                root.Right = DeleteNode(root.Right, successor.Value);
            }
            else if (root.Value < key)
                root.Right = DeleteNode(root.Right, key);
            else
                root.Left = DeleteNode(root.Left, key);
            return root;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int start = 0;
            int end = nums.Length - 1;
            int total = nums.Length;
            while (start < end)
            {
                if (nums[start] == val)
                {
                    while (nums[start] == val)
                    {
                        nums[start] = nums[end];
                        nums[end] = -1;
                        end--;
                        total--;
                    }
                }
                start++;
            }
            return total;
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

        public int MaxArea(int[] height)
        {
            int max = 0;
            int maxBar = 0;
            for (int i = 1; i < height.Length; i++)
            {
                int minBar = Math.Min(height[maxBar], height[i]);
                int distance = i - maxBar;
                max = Math.Max(max, distance * minBar);
                if (height[i] > height[maxBar])
                    maxBar = i;
            }

            return max;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            head = new ListNode(1);
            head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            Stack<ListNode> stack = new Stack<ListNode>();
            var current = head;
            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }
            int counter = 0;
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                counter++;
                if (counter == n)
                {
                    if (stack.Count > 0)
                    {
                        var prev = stack.Pop();
                        prev.next = node.next;
                    }
                    else
                    {
                        head = node.next;
                        break;
                    }
                }
            }
            return head;
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

        public static void Rotate(int[][] matrix)
        {
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i < matrix.Length / 2; i++)
            {
                for (int j = i; j < matrix[i].Length - 1; j++)
                {
                    //top
                    temp1 = matrix[i][j];
                    matrix[i][j] = matrix[matrix.Length - j - 1][i];

                    //right
                    temp2 = matrix[j][matrix[i].Length - i - 1];
                    matrix[j][matrix[i].Length - i - 1] = temp1;

                    //bottom
                    temp1 = matrix[matrix.Length - i - 1][matrix[i].Length - 1 - j];
                    matrix[matrix.Length - i - 1][matrix[i].Length - 1 - j] = temp2;

                    //left
                    matrix[matrix.Length - j - 1][i] = temp1;
                }
            }
        }

        //[2,3,1,1,4]
        //[3,2,1,0,4]
        public static bool CanJump(int[] nums)
        {
            int goal = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= goal)
                    goal = i;
            }
            return goal == 0;
        }

        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> intervalList = new List<int[]>();
            intervalList.Add(new int[] { intervals[0][0], intervals[0][1] });
            for (int i = 1; i < intervals.Length; i++)
            {
                var current = intervals[i];
                var prevInterval = intervalList[intervalList.Count - 1];

                if (current[0] <= prevInterval[1] && current[1] >= prevInterval[1])
                {
                    intervalList[intervalList.Count - 1][1] = current[1];

                }
                if (current[0] <= prevInterval[0])
                {
                    intervalList[intervalList.Count - 1][0] = current[0];

                }
                if (current[0] > prevInterval[1] && current[1] > prevInterval[1])
                {
                    intervalList.Add(new int[] { current[0], current[1] });
                }
            }
            int[][] merged = new int[intervalList.Count][];
            for (int i = 0; i < merged.Length; i++)
            {
                merged[i] = intervalList[i];
            }
            return merged;
        }

        public static void SetZeroes(int[][] matrix)
        {
            List<int[]> zeros = GetAllZeroz(matrix);
            Dictionary<int, int> completedRows = new Dictionary<int, int>();
            Dictionary<int, int> completedCols = new Dictionary<int, int>();
            foreach (var item in zeros)
            {
                if (!completedRows.ContainsKey(item[0]))
                {
                    completedRows.Add(item[0], 0);

                    for (int i = 0; i < matrix[item[0]].Length; i++)
                    {
                        matrix[item[0]][i] = 0;
                    }
                }
                if (!completedCols.ContainsKey(item[1]))
                {
                    completedCols.Add(item[1], 0);
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        matrix[row][item[1]] = 0;
                    }
                }
            }
        }

        public static List<int[]> GetAllZeroz(int[][] matrix)
        {
            List<int[]> zeros = new List<int[]>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeros.Add(new int[] { i, j });
                    }
                }
            }
            return zeros;
        }

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

        public bool IsValidBST(BinarySearchTree root)
        {
            return IsValid(root, Int32.MinValue, Int32.MaxValue);
        }

        public bool IsValid(BinarySearchTree node, int leftBound, int rightBound)
        {
            if (node == null)
            {
                return true;
            }
            if (!(node.Value < rightBound && node.Value > leftBound))
                return false;
            return (IsValid(node.Left, leftBound, node.Value) && IsValid(node.Right, node.Value, rightBound));
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

        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] res = new int[n + 1];
            res[0] = 1;
            return res;
        }

        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            IList<IList<int>> response = new List<IList<int>>();
            int target = graph.Length - 1;
            for (int i = 0; i < graph[0].Length; i++)
            {
                IList<int> path = new List<int>() { 0 };
                AllPathsDFS(graph, response, path, target, graph[0][i]);
            }
            return response;
        }

        public static void AllPathsDFS(int[][] graph, IList<IList<int>> response, IList<int> currentPath, int target, int currentNode)
        {
            if (currentNode == target)
            {
                currentPath.Add(currentNode);
                response.Add(currentPath);
            }
            else
            {
                currentPath.Add(currentNode);
                for (int i = 0; i < graph[currentNode].Length; i++)
                {
                    List<int> _current = currentPath.Select(x => x).ToList();

                    AllPathsDFS(graph, response, _current, target, graph[currentNode][i]);
                }

            }
        }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode current = head;
            head = head.next;
            head.next = current;

            current = current.next.next;

            while (current != null)
            {

            }

            return head;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;

            ListNode temp;

            while (current != null)
            {
                temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }
            return previous;
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            ListNode prev = head;
            ListNode current = head.next;
            while (current != null)
            {
                if (prev.val == current.val)
                {
                    prev.next = current.next;
                    current = prev.next;
                }
                else {
                    prev = prev.next;
                    if (prev.next == null)
                        break;
                    current = prev.next;
                }
            }
            return head;
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
        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            Stack<Histogram> stack = new Stack<Histogram>();
            for (int i = 0; i < heights.Length; i++)
            {
                int start = i;
                while(stack.Count > 0 && stack.Peek().Height > heights[i])
                {
                    var histo = stack.Pop();
                    int index = histo.Index;
                    int height = histo.Height;
                    maxArea = Math.Max(maxArea, height * (i - index));
                    start = index;
                }
                stack.Push(new Histogram() { Height = heights[i], Index = start });
            }
            while(stack.Count > 0)
            {
                var st = stack.Pop();
                maxArea = Math.Max(maxArea, st.Height * (heights.Length - st.Index));
            }
            return maxArea;
        }

        public static int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return 0;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[] histogram = new int[cols];
            int maxArea = 0;
            Stack<Histogram> stack = new Stack<Histogram>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    histogram[j] = matrix[i][j] == '0' ? 0 : histogram[j] + 1;
                }


                for (int j = 0; j < histogram.Length; j++)
                {
                    int start = j;
                    while (stack.Count > 0 && stack.Peek().Height > histogram[j])
                    {
                        var histo = stack.Pop();
                        int index = histo.Index;
                        int height = histo.Height;
                        maxArea = Math.Max(maxArea, height * (j - index));
                        start = index;
                    }
                    stack.Push(new Histogram() { Height = histogram[j], Index = start });
                }
                while (stack.Count > 0)
                {
                    var st = stack.Pop();
                    maxArea = Math.Max(maxArea, st.Height * (histogram.Length - st.Index));
                }
            }
            return maxArea;
        }

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
    }

    public class Histogram
    {
        public int Index { get; set; }
        public int Height { get; set; }
    }
    public class Level
    {
        public BinarySearchTree root;
        public int depth;
        public Level(BinarySearchTree root, int depth)
        {
            this.root = root;
            this.depth = depth;
        }
    }


    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AncestralTree
    {
        public char name;
        public AncestralTree ancestor;

        public AncestralTree(char name)
        {
            this.name = name;
            this.ancestor = null;
        }

        // This method is for testing only.
        public void AddAsAncestor(AncestralTree[] descendants)
        {
            foreach (AncestralTree descendant in descendants)
            {
                descendant.ancestor = this;
            }
        }
    }
}
