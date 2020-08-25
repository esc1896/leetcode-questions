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
    
    public int SumOfLeftLeaves(TreeNode root) {                
        
        return SumInternal(root, false);
    }
    
    private int SumInternal(TreeNode node, bool IsLeft)
    {
        if(node == null) return 0;        
        
        if(node.left == null && node.right == null)
        {
            return IsLeft ? node.val : 0;
        }                    
        
        return SumInternal(node.left, true) + SumInternal(node.right, false);
    }
}
