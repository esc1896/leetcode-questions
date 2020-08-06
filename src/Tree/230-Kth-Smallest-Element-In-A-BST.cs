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
    int rst = 0;
    int index = 0;
    public int KthSmallest(TreeNode root, int k) {
        
        inOrder(root,k);
        return rst;
    }
    
    private void inOrder(TreeNode node, int k)
    {
        if(node == null || index >= k) return;
        
        inOrder(node.left, k);
        index++;
        if(k == index)
        {
            rst = node.val;
            return;
        }
        inOrder(node.right, k);
        return;
    }
}
