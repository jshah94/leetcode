using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Algorithms
    {
        public void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = start;
            int left = start + 1;
            int right = end;
            while (right >= left)
            {
                if (array[left] > array[pivot] && array[right] < array[pivot])
                {
                    SwapNumbers(array, left, right);
                }
                if (array[left] <= array[pivot])
                {
                    left++;
                }
                if (array[right] >= array[pivot])
                {
                    right--;
                }
            }

            SwapNumbers(array, pivot, right);
            bool leftIsSmall = (right - 1 - start) < (end - (right + 1));
            if (leftIsSmall)
            {
                QuickSort(array, start, right - 1);
                QuickSort(array, right + 1, end);
            }
            else
            {
                QuickSort(array, start, right - 1);
                QuickSort(array, right + 1, end);
            }
        }

        public int[] TwoNumberSum(int[] array, int targetSum)
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

        public int BinarySearch(int[] array, int target)
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

        public int[] BubbleSort(int[] array)
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

        public int[] SwapNumbers(int[] array, int left, int right)
        {
            array[left] = array[left] + array[right];
            array[right] = array[left] - array[right];
            array[left] = array[left] - array[right];
            return array;
        }

        public int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int[] auxilaryArray = (int[])array.Clone();
            MergeSort(array, 0, array.Length - 1, auxilaryArray);
            return array;
        }

        public void MergeSort(int[] mainArray, int start, int end, int[] auxilaryArray)
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

        public void DoMerge(int[] mainArray, int start, int mid, int end, int[] auxilaryArray)
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

        public int ShiftedBinarySearch(int[] array, int target)
        {
            if (array.Length == 0)
            {
                return -1;
            }
            int left = 0;
            int right = array.Length - 1;
            int mid = (left + right) / 2;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (target == array[mid])
                {
                    return mid;
                }
                else if (array[left] <= array[mid])
                {
                    if (target < array[mid] && target > array[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (target > array[mid] && target < array[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }

        public void SortedSquares(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int[] sortedSquares = new int[array.Length];
            for (int i = sortedSquares.Length - 1; i > 0; i--)
            {
                if (Math.Abs(array[left]) > Math.Abs(array[right]))
                {
                    sortedSquares[i] = array[left] * array[left];
                    left++;
                }
                else
                {
                    sortedSquares[i] = array[right] * array[right];
                    right--;

                }
            }

            for (int i = 0; i < sortedSquares.Length; i++)
            {
                Console.WriteLine(sortedSquares[i]);
            }
        }
    }
}
