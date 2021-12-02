using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class GraphsProblems
    {
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
    }
}
