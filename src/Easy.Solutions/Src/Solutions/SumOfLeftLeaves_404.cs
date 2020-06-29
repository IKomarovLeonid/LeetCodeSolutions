using Easy.Solutions.Src.Objects;

namespace Easy.Solutions.Src.Solutions
{
    public class SumOfLeftLeaves_404
    {
        // Find the sum of all left leaves in a given binary tree. 

        /*
            3
           / \
          9  20
            /  \
           15   7
        There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.
        */

        /*
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */


        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            else if (root.left == null && root.right == null) return 0;
            else return HelpMethod(root, false);  // not secured from StackOverflow 

        }

        public int HelpMethod(TreeNode node, bool flag)   // i using bool flag argument, which show, are incoming node was left child of parent
        {
            if (node.left == null && node.right == null && !flag) return 0;
            else
            {
                if (node.left == null && node.right == null && flag) return node.val;
                else
                {
                    if (node.left == null && node.right != null) return HelpMethod(node.right, false);
                    else
                    {
                        if (node.left != null && node.right == null) return HelpMethod(node.left, true);
                        else return HelpMethod(node.left, true) + HelpMethod(node.right, false);
                    }
                }
            }

        }
    }
}
