// Runtime: 124 ms
// Memory Usage: 64.8 MB

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        
        int len = inorder.Length;
        if(len == 0) return null;
        if(len == 1) return new TreeNode(inorder[0]);
        
        TreeNode root = new TreeNode(postorder[len-1]);
        
        // find root in inorder sequence
        int i = 0;
        for(; i < len; i++)
        {
            if(inorder[i] == root.val)
                break;                
        }
        
        // Has left tree
        if(i > 0)
        {
            int[] inorder_left = new int[i];
            Array.Copy(inorder,0,inorder_left,0,i);
            
            int[] postorder_left = new int[i];
            Array.Copy(postorder,0,postorder_left,0,i);
            
            TreeNode leftTree = BuildTree(inorder_left, postorder_left);
            root.left = leftTree;            
        }
        
        // Has right tree
        if(i < len - 1)
        {
            int[] inorder_right = new int[len-1-i];
            Array.Copy(inorder, i+1, inorder_right, 0, len-1-i);
            
            int[] postorder_right = new int[len-1-i];
            Array.Copy(postorder, i, postorder_right, 0 , len-1-i);

            TreeNode rightTree = BuildTree(inorder_right, postorder_right);
            root.right = rightTree;
        }
        
        return root;        
    }
}