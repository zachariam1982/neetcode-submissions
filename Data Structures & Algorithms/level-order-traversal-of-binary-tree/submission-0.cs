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
    private void LevelOrder(TreeNode root, int level, List<List<int>> lsts){
        if(root == null) return;

        if(lsts.Count() == level){ lsts.Add(new List<int>());}

        lsts[level].Add(root.val);
        LevelOrder(root.left, level + 1, lsts);
        LevelOrder(root.right, level + 1, lsts);
    }

    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> lsts = new List<List<int>>();

        LevelOrder(root, 0, lsts);

        return lsts;
    }
}
