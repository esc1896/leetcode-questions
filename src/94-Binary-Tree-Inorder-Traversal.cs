// 236 ms 85.18%
// 29.9 MB 37.05%
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
    public IList<int> InorderTraversal(TreeNode root) {
        
        var rst = new List<int>();                
        var st = new Stack<TreeNode>();        
        var cur = root;
        while(cur != null || st.Count > 0)
        {
            while(cur != null)
            {
                st.Push(cur);
                cur = cur.left;                
            }
            
            cur = st.Pop();
            rst.Add(cur.val);
            cur = cur.right;
        }
        
        return rst;        
    }
    
    private void InorderRecur(TreeNode node, IList<int> rst)
    {
        if(node == null) return;
        
        if(node.left != null) InorderRecur(node.left, rst);
        rst.Add(node.val);        
        if(node.right != null) InorderRecur(node.right, rst);                
    }
}
