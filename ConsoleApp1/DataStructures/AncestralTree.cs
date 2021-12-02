﻿namespace ConsoleApp1
{
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
