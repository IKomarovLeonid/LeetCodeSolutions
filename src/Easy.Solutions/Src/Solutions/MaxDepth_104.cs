using Shared.Common;
using System;

namespace Easy.Solutions.Src.Solutions
{
    internal class MaxDepth_104
    {
        /*
         * Given the root of a binary tree, return its maximum depth.
         * A binary tree's maximum depth is the number of nodes along the longest path from 
         * the root node down to the farthest leaf node.
         * 
         */


        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MaxDepth(root.right) + 1;
            if (root.right == null) return MaxDepth(root.left) + 1;
            var l = MaxDepth(root.left);
            var r = MaxDepth(root.right);
            return Math.Max(l, r) + 1;
        }
    }
}
