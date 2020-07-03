// 100 ms - 80.85%
// 26.4 MB - 74.65%
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
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        
        if(root == null) return null;
        
        if(root.left == null && root.right == null)
        {
            if(root.val == target) 
                return null;
            return root;
        }
    
        // Post Order Traverse
        if(root.left != null) 
            root.left = RemoveLeafNodes(root.left, target);
        if(root.right != null) 
            root.right = RemoveLeafNodes(root.right, target);
        if(root.left == null && root.right == null && root.val == target)
        {
            return null;
        }     
        
        return root;
    }
}
