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
            ListNode listNode1 = new ListNode(1);
            listNode1.next = new ListNode(2);
            listNode1.next.next = new ListNode(3);
            listNode1.next.next.next = new ListNode(4);
            LinkedListProblems.ReverseList(listNode1);

            //GeneralProblems.GuessNumber(10);
            //ArrayProblems.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });

            //ArrayProblems.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);

            //ArrayProblems.LongestOnes(new int[] { 0,0,0,1},3);

            //Console.WriteLine(GeneralProblems.NthMagicalNumber(1,2,3));
            //Console.WriteLine(StringProblems.CaesarCypherEncryptor("xyz", 2));

            //BST bst = TreeProblems.ReconstructBst((new int[] {10, 4, 2, 1, 5, 17, 19, 18}).ToList());
            //Console.WriteLine(bst.value);
            //ArrayProblems.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            //ArrayProblems.Permute(new int[] { 1, 2, 3 });

            //ArrayProblems.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2});

            //Console.WriteLine(StringProblems.ConvertToTitle(27));
            //GeneralProblems.Generate(5);
            //GeneralProblems.singleNumber(new int[] { 1, 2, 1, 2, 3, 5, 3 });

            //ListNode listNode1 = new ListNode(1);
            //listNode1.next = new ListNode(0);
            //listNode1.next.next = new ListNode(1);
            //Console.WriteLine(GeneralProblems.GetDecimalValue(listNode1));

            //-2147483648
            //Console.WriteLine(GeneralProblems.Reverse(-1147483648));

            //Console.WriteLine(GeneralProblems.FibonacciBottomUp(8));

            //ArrayProblems.MinCostToMoveChips(new int[] { 1, 2, 3 });

            //TreeNode rootlot = new TreeNode(1);
            //rootlot.left = new TreeNode(-2);
            //rootlot.right = new TreeNode(3);
            //rootlot.left.left = new TreeNode(1);
            //rootlot.left.left.left = new TreeNode(-1);
            //rootlot.right.right = new TreeNode(5);
            //TreeProblems.HasPathSum(rootlot, -1);

            //ArrayProblems.DeleteAndEarn(new int[] { 3, 7, 10, 5, 2, 4, 8, 9, 9, 4, 9, 2, 6, 4, 6, 5, 4, 7, 6, 10 });

            //int[][] arr = new int[2][];
            //arr[0] = new int[] { 1, 4 };
            //arr[1] = new int[] { 1, 4 };
            //ArrayProblems.Merge(arr);

            //TreeProblems.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9});

            //string[][] str = new string[3][];
            //str[0] = new string[] { "London", "New York" };
            //str[1] = new string[] { "New York", "Lima" };
            //str[2] = new string[] { "Lima", "Sao Paulo" };
            //ArrayProblems.DestCity(str);


            //ArrayProblems.MinCostClimbingStairs(new int[] { 0, 0, 1, 1 });
            //GeneralProblems.Divide(-2147483648, -1);
            //Rob(new int[] { 1, 2, 3, 1 });
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
            GraphsProblems.MaximalRectangle(null);
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

            Console.WriteLine(GraphsProblems.RiverSizes(graph));
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
            ArrayProblems.FindThreeLargestNumbers(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 });
            GraphsProblems.GraphConstructionAndTraversal(3, 2);
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
            
        }
    }
}
