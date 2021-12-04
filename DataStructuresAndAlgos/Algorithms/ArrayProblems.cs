using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class ArrayProblems
    {
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
                        array[left - 1] < array[left] && array[right + 1] < array[right])
                    {
                        left--;
                        right++;
                    }
                    while (left > 0 &&
                        array[left - 1] < array[left])
                    {
                        left--;
                    }
                    while (right < array.Length - 1 &&
                         array[right + 1] < array[right])
                    {
                        right++;
                    }
                    longestPeak = Math.Max(longestPeak, right - left);
                }
            }
            return longestPeak;
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

        public static int MaxSubArray(int[] nums)
        {
            int maxSub = nums[0];
            int currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (currentSum < 0)
                    currentSum = 0;
                currentSum += nums[i];
                maxSub = Math.Max(currentSum, maxSub);
            }
            return maxSub;
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

        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            Stack<Histogram> stack = new Stack<Histogram>();
            for (int i = 0; i < heights.Length; i++)
            {
                int start = i;
                while (stack.Count > 0 && stack.Peek().Height > heights[i])
                {
                    var histo = stack.Pop();
                    int index = histo.Index;
                    int height = histo.Height;
                    maxArea = Math.Max(maxArea, height * (i - index));
                    start = index;
                }
                stack.Push(new Histogram() { Height = heights[i], Index = start });
            }
            while (stack.Count > 0)
            {
                var st = stack.Pop();
                maxArea = Math.Max(maxArea, st.Height * (heights.Length - st.Index));
            }
            return maxArea;
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

        public static int MinCostClimbingStairs(int[] cost)
        {
            for (int i = 2; i < cost.Length; i++)
            {
                cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
            }
            return Math.Min(cost[cost.Length - 1], cost[cost.Length - 2]);
        }

        /// <summary>
        /// 
        /// [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]
        /// 
        /// Input: paths = [["B","C"],["D","B"],["C","A"]]
        /// Output: "A"
        /// Explanation: All possible trips are: 
        /// "D" -> "B" -> "C" -> "A". 
        /// "B" -> "C" -> "A". 
        /// "C" -> "A". 
        /// "A". 
        /// Clearly the destination city is "A".
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, string> maps = new Dictionary<string, string>();
            foreach (IList<string> path in paths)
            {
                maps.Add(path[0], path[1]);
            }
            string destination = "";
            foreach (var map in maps)
            {
                if (!maps.ContainsKey(map.Value))
                {
                    destination = map.Value;
                    break;
                }
            }
            return destination;
        }

        //[[1,3],[2,6],[8,10],[15,18]]
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> intervalList = new List<int[]>();
            intervalList.Add(new int[] { intervals[0][0], intervals[0][1] });
            for (int i = 1; i < intervals.Length; i++)
            {
                if (Overlap(intervals[i - 1], intervals[i]))
                {
                    intervalList[i - 1][0] = Math.Min(intervals[i - 1][0], intervals[i][0]);
                    intervalList[i - 1][1] = Math.Max(intervals[i - 1][1], intervals[i][1]);
                }
                else
                    intervalList.Add(new int[] { intervals[i][0], intervals[i][1] });
            }

            int[][] merged = new int[intervalList.Count][];
            for (int i = 0; i < merged.Length; i++)
            {
                merged[i] = intervalList[i];
            }
            return merged;
        }

        public static bool Overlap(int[] interval1, int[] interval2)
        {
            if (interval1[1] > interval2[0] && interval2[1] > interval1[1])
                return true;
            else if (interval2[0] < interval1[0] && interval2[1] > interval1[1])
                return true;
            else if (interval1[1] == interval2[0])
                return true;
            else if (interval1[0] == interval2[0] && interval1[1] == interval2[1])
                return true;
            return false;
        }

        //[2,2,3,3,3,4]
        public static int DeleteAndEarn(int[] nums)
        {
            int maxDeleteEarn = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> deleted = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                    dict[item] += 1;
                else
                    dict.Add(item, 1);
            }
            foreach (var item in dict)
            {
                deleted.Clear();
                int maxEarn = (item.Key * item.Value);
                deleted.Add(item.Key, 0);
                deleted.Add(item.Key - 1, 0);
                deleted.Add(item.Key + 1, 0);
                foreach(var it in dict)
                {
                    if (!deleted.ContainsKey(it.Key))
                    {
                        maxEarn = maxEarn + (it.Key * it.Value);
                        deleted.Add(it.Key, 0);
                        if (dict.ContainsKey(it.Key - 1) && !deleted.ContainsKey(it.Key - 1))
                        {
                            deleted.Add(it.Key - 1, 0);
                        }
                        if (dict.ContainsKey(it.Key + 1) && !deleted.ContainsKey(it.Key + 1))
                        {
                            deleted.Add(it.Key + 1, 0);
                        }
                    }
                }
                maxDeleteEarn = Math.Max(maxDeleteEarn, maxEarn);

            }
            return maxDeleteEarn;
        }
    }
}
