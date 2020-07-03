// 252 ms 40.38%
// 31.1 MB 25.91%
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        
        var up2BottomList = new List<IList<int>>();
        
        LevelOrderRecursive(root, 0, up2BottomList);                                
        
        up2BottomList.Reverse();
        
        return up2BottomList;
    }
    
    private void LevelOrderRecursive(TreeNode node, int level, IList<IList<int>> list)
    {
        if(node == null) return;
        
        if(list.Count < level + 1) list.Add(new List<int>());        
        list[level].Add(node.val);
        
        if(node.left != null) LevelOrderRecursive(node.left, level+1, list);
        if(node.right != null) LevelOrderRecursive(node.right, level+1, list);                
    }
}
