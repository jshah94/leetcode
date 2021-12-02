using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BinarySearchTree
    {
        public int Value { get; set; }
        public BinarySearchTree Left { get; set; }
        public BinarySearchTree Right { get; set; }
        public BinarySearchTree()
        {
            
        }
        public BinarySearchTree(int value)
        {
            Value = value;
        }

        public BinarySearchTree Insert(int value)
        {
            if (value < Value)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTree(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else if (value > Value)
            {
                if (Right == null)
                {
                    Right = new BinarySearchTree(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
            return this;
        }

        public BinarySearchTree Delete(int value)
        {
            Delete(value, null);
            return this;
        }

        public void Delete(int value, BinarySearchTree parentNode)
        {
            if (value < Value && Left != null)
            {
                Delete(value, Left);
            }
            else if(value > Value && Right != null)
            {
                Delete(value, Right);
            }
            else
            {
                if (Left != null && Right != null)
                {
                    Value = Right.GetMinValue();
                    Right.Delete(Value, this);
                }
                else if (parentNode == null)
                {
                    if (Left != null)
                    {
                        Value = Left.Value;
                        Right = Left.Right;
                        Left = Left.Left;
                    }
                    else if (Right != null)
                    {
                        value = Right.Value;
                        Left = Right.Left;
                        Right = Right.Right;
                    }
                    else
                    {
                        //do nothing.
                    }
                }
                else if (parentNode.Left == this)
                {
                    parentNode.Left = Left != null ? Left : Right;
                }
                else if (parentNode.Right == this)
                {
                    parentNode.Right = Left != null ? Left : Right;
                }
            }
        }

        public bool Search(int value)
        {
            if (value == Value)
            {
                return true;
            }
            if (value < Value && Left != null)
            {
                return Left.Search(value);
            }
            else if (value > Value && Right != null)
            {
                return Right.Search(value);
            }
            return false;
        }

        public int GetMinValue()
        {
            if (Left != null)
            {
                return Left.GetMinValue();
            }
            return Value;
        }
    }
}
