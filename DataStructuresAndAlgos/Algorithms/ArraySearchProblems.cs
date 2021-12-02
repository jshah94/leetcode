using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ArraySearchProblems
    {
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

            return mid;
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
    }
}
