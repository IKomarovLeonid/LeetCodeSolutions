using System;
namespace Easy.Solutions.Src.Solutions
{
    public class SearchBST_700
    {
        /*
         * You are given the root of a binary search tree (BST) and an integer val.

           Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.
         * 
         * 
         */



        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;
            if (root.val < val)
            {
                if (root.right == null) return null;
                return SearchBST(root.right, val);
            }
            if (root.val > val)
            {
                if (root.left == null) return null;
                return SearchBST(root.left, val);
            }
            return null;
        }


    }

    public class TreeNode
    {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;

        }
  }
}
