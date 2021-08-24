using System;

namespace Diameter_of_Binary_Tree_or_Longest_Route
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            
            Console.WriteLine(root.DiameterOfBinaryTree(root));
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left, right;
        int max = 0;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxHeight(root);
            return max;
        }

        // https://leetcode.com/problems/diameter-of-binary-tree/discuss/101132/Java-Solution-MaxDepth

        // The time complexity will be O(n)O(n) because each of the tree’s nodes gets visited once.
        int MaxHeight(TreeNode root)
        {
            if (root == null) return 0;
            int leftMax = MaxHeight(root.left);
            int rightMax = MaxHeight(root.right);
            max = Math.Max(max, leftMax + rightMax); // entire path bw two nodes, max of left subtree +  max of right sub tree;

            return Math.Max(leftMax, rightMax) + 1; // for each root node , get the max of (left, right) + root it self , i.e = Max(left, right) +1;
        }
    }
}
