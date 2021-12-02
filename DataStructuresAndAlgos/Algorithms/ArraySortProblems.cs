using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ArraySortProblems
    {
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

        public static int[] SwapNumbers(int[] array, int Left, int Right)
        {
            array[Left] = array[Left] + array[Right];
            array[Right] = array[Left] - array[Right];
            array[Left] = array[Left] - array[Right];
            return array;
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
    }
}
