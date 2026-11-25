/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private bool IsSame(TreeNode arg1, TreeNode arg2) {
        if( arg1 == null && arg2 == null) return true;
        if( arg1 == null || arg2 == null) return false;

        return arg1.val == arg2.val && IsSame(arg1.left, arg2.left) && IsSame(arg1.right, arg2.right);
    }    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot == null) return true;
        if(root == null || subRoot == null) return false;

        if(root.val == subRoot.val) 
            return (IsSame(root.left, subRoot.left) && IsSame(root.right, subRoot.right)) ||
                   IsSubtree(root.left, subRoot) ||
                   IsSubtree(root.right, subRoot);
        else
            return IsSubtree(root.left, subRoot) ||
                   IsSubtree(root.right, subRoot);
    }
}
