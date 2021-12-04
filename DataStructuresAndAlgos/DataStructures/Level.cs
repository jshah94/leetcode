using Algorithms;

namespace ConsoleApp1
{
    public class Level
    {
        public BinarySearchTree root;
        public int depth;
        public TreeNode binaryRoot;
        public Level(BinarySearchTree root, int depth)
        {
            this.root = root;
            this.depth = depth;
        }

        public Level(TreeNode root, int depth)
        {
            this.binaryRoot = root;
            this.depth = depth;
        }
    }
}
