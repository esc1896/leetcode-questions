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

// Second edition
// Runtime: 96 ms
// Memory Usage: 24.8 MB
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
        
        if(inorder.Length == 0 
          || postorder.Length == 0
          || inorder.Length != postorder.Length) return null;
        
        int len = inorder.Length;
        Dictionary<int,int> inList = new Dictionary<int,int>();
        for(int i = 0; i<len; i++)
        {
            inList.Add(inorder[i],i);            
        }
        
        TreeNode root = RecursiveBuildTree(inorder,0,len-1,postorder,0,len-1,inList);
        return root;        
    }
    
    private TreeNode RecursiveBuildTree(int[] inorder, int iStart, int iEnd,
                                       int[] postorder, int pStart, int pEnd,
                                       Dictionary<int,int> inList)
    {
        if(iStart>iEnd || pStart>pEnd) return null;
        
        TreeNode root = new TreeNode(postorder[pEnd]);
        int rootIndex = inList[root.val];
        
        root.left = RecursiveBuildTree(inorder, iStart, rootIndex - 1,
                                    postorder, pStart, pStart + (rootIndex - 1 - iStart),
                                    inList);

        root.right = RecursiveBuildTree(inorder, rootIndex + 1, iEnd,
                                    postorder, pStart + rootIndex - iStart, pEnd - 1,
                                    inList);
        
        return root;
    }
}