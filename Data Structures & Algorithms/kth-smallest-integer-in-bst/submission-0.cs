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
    private void InOrder(TreeNode root, List<int> lst) {
        if(root == null) return;

        InOrder(root.left, lst);
        lst.Add(root.val);
        InOrder(root.right, lst);
    }

    public int KthSmallest(TreeNode root, int k) {
        var lst = new List<int>();

        InOrder(root, lst);

        return lst[k-1];    
    }
}
