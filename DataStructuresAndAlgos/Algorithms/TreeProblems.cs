using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TreeProblems
    {
        /// <summary>
        /// Get's the successor of the node
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
        {
            // Write your code here.
            if (node.Right != null)
                return GetLeftMost(node.Right);
            return GetRightmostParent(node);
        }

        public BinaryTree GetLeftMost(BinaryTree tree)
        {
            var current = tree;
            while (current.Left != null)
                current = current.Left;
            return current;
        }
        public BinaryTree GetRightmostParent(BinaryTree tree)
        {
            var current = tree;
            while (current.Parent != null && current.Parent.Right == current)
                current = current.Parent;
            return current.Parent;
        }

        public List<int> InOrderTraverse(BinarySearchTree tree, List<int> array)
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

        public List<int> PreOrderTraverse(BinarySearchTree tree, List<int> array)
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

        public List<int> PostOrderTraverse(BinarySearchTree tree, List<int> array)
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

        public List<int> InsertTreeIntoDictionary(BinarySearchTree tree, List<int> dictionary)
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

        public bool SearchInBST(BinarySearchTree tree, int Value)
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

        public int ClosestValueInBST(BinarySearchTree tree, int closest, int target)
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

        public int NodeDepthBinaryTree(BinarySearchTree tree)
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

        public void BranchSum(BinarySearchTree tree, List<int> branchSum, int sum)
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


        public void LevelOrderTraversal(BinarySearchTree tree)
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

        public int TreeHeight(BinarySearchTree tree)
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

        public int NodeDepths(BinarySearchTree tree)
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

        public int FindKthLargestValueInBst(BinarySearchTree tree, int k)
        {
            // Write your code here.
            List<int> numbers = new List<int>();
            TraverseDescending(tree, k, numbers);
            return numbers[k - 1];
        }

        public void TraverseDescending(BinarySearchTree tree, int k, List<int> numbers)
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

        //[0,1,2,3,4,5]
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            int mid = nums.Length / 2;
            TreeNode root = new TreeNode(nums[0]);
            var current = root;
            int i = mid - 1;
            while (i >= 0)
            {
                current.left = new TreeNode(nums[i]);
                current = current.left;
                i--; ;
            }
            int j = mid + 1;
            current = root;
            while (j < nums.Length)
            {
                current.right = new TreeNode(nums[j]);
                current = current.right;
                j++;
            }
            return root;
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            var tr = IsBalancedDFS(root); //0
            if (tr.IsBalanced)
                return true;
            return false;
        }
        //20 => 0
        public BalancedTree IsBalancedDFS(TreeNode node)
        {
            if (node == null)
                return new BalancedTree { Height = 0, IsBalanced = true };
            if (node.left == null && node.right == null)
                return new BalancedTree { Height = 0, IsBalanced = true };
            var left = IsBalancedDFS(node.left);
            var right = IsBalancedDFS(node.right);
            if (left.IsBalanced && right.IsBalanced && Math.Abs(left.Height - right.Height) <= 1)
                return new BalancedTree { Height = Math.Max(left.Height, right.Height) + 1, IsBalanced = true };
            else
                return new BalancedTree { Height = Math.Max(left.Height, right.Height) + 1, IsBalanced = false };

        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            int leftDepth = root.left != null ? MinDepth(root.left) : int.MaxValue;
            int rightDepth = root.right != null ? MinDepth(root.right) : int.MaxValue;
            return Math.Min(leftDepth, rightDepth) + 1;
        }

        //level order traversal is tough man
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            int sizeInLevel = 0;
            IList<IList<int>> results = new List<IList<int>>();
            IList<int> resultInLevel = null;
            Queue<TreeNode> level = new Queue<TreeNode>();
            TreeNode currentNode = null;

            level.Enqueue(root);

            while (level.Count != 0)
            {
                sizeInLevel = level.Count;
                resultInLevel = new List<int>();

                while (sizeInLevel != 0)
                {
                    currentNode = level.Dequeue();

                    if (currentNode.left != null)
                        level.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        level.Enqueue(currentNode.right);

                    resultInLevel.Add(currentNode.val);
                    sizeInLevel--;
                }

                results.Add(resultInLevel);
            }

            return results;

        }

        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            return HasPathSum(root, targetSum, 0);
        }

        public static bool HasPathSum(TreeNode root, int targetSum, int sum)
        {
            if (root == null)
                return false;
            sum = sum + root.val;
            if (sum == targetSum)
            {
                if (root.left == null && root.right == null)
                    return true;
            }

            return (HasPathSum(root.left, targetSum, sum)
                    || HasPathSum(root.right, targetSum, sum)) ? true : false;
        }

        public int FindTilt(TreeNode root)
        {
            dfs(root);
            return sum;
        }

        int sum = 0;

        public int dfs(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = dfs(root.left);
            int right = dfs(root.right);

            sum += Math.Abs(left - right);

            return (left + right + root.val);
        }

        public static BST ReconstructBst(List<int> preOrderTraversalValues)
        {
            // Write your code here.
            if(preOrderTraversalValues.Count == 1)
                return new BST(preOrderTraversalValues[0]);
            if (preOrderTraversalValues.Count == 0)
                return null;
            int rightPointer = preOrderTraversalValues.Count;
            BST rightBst = null;
            BST leftBst = null;
            for(int i = 1; i < preOrderTraversalValues.Count; i++)
            {
                if (preOrderTraversalValues[i] > preOrderTraversalValues[0])
                {
                    rightPointer = i;
                    break;
                }
            }
            if (rightPointer < preOrderTraversalValues.Count)
            {
                rightBst = ReconstructBst(preOrderTraversalValues.Skip(rightPointer).ToList());
                leftBst = ReconstructBst(preOrderTraversalValues.Skip(1).Take(rightPointer-1).ToList());
            }
            else
                leftBst = ReconstructBst(preOrderTraversalValues.Skip(1).ToList());
            
            return new BST(preOrderTraversalValues[0], leftBst, rightBst);
        }

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            return RangeSumBST(root, low, high, 0);
        }
        public int RangeSumBST(TreeNode root, int low, int high, int sum)
        {
            if (root.val <= high && root.val >= low)
                sum += root.val;
            if (root.val <= high)
                sum = RangeSumBST(root.right, low, high, sum);
            if (root.val >= low)
                sum = RangeSumBST(root.left, low, high, sum);
            return sum;
        }

        public int MaxAncestorDiff(TreeNode root)
        {
            return Math.Max(MaxAncestorDiff(root.left, root.val, root.val, 0),
                           MaxAncestorDiff(root.right, root.val, root.val, 0));
        }

        public int MaxAncestorDiff(TreeNode root, int max, int min, int maxDifference)
        {
            if (root == null)
                return maxDifference;
            if (root.val > max)
                max = root.val;
            else if (root.val < min)
                min = root.val;
            maxDifference = max - min;
            return Math.Max(maxDifference, Math.Max(MaxAncestorDiff(root.left, max, min, maxDifference),
                MaxAncestorDiff(root.right, max, min, maxDifference)));
        }
    }

}
