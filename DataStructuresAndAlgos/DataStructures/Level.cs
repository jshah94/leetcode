using Algorithms;

namespace ConsoleApp1
{
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
}
