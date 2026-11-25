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
    private bool InOrder(TreeNode root, List<int> lst) {
        if(root == null) return true;
        bool result = false;

        result = InOrder(root.left, lst);

        if(result == false) return result;

        int mid = lst.Count;
        for(int i = 0; i < lst.Count; i++){
            if(lst[i] >= root.val) return false;
        }
        lst.Add(root.val);
        
        result = InOrder(root.right, lst);

        if(result == false) return result;

        for(int i = mid + 1; i < lst.Count; i++){
            if(lst[i] <= root.val) return false;
        }

        return true;        
    }
    public bool IsValidBST(TreeNode root) {
        var lst = new List<int>();

        return InOrder(root, lst);
    }
}
