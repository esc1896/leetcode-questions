// First version
// Time complexity: n ^ 2, not passed

public class Solution {
    public int SubarrayBitwiseORs(int[] A) {
        
        int len = A.Length;
        if(len < 2) return 1;
        
        HashSet<int> rst = new HashSet<int>();
        int[] OrRst = new int[len];
        for(int i = 0; i<len; i++)
        {
            rst.Add(A[i]);
            OrRst[i] = A[i];
        }            
        
        for(int step = 2; step <= len; step++)
        {
            for(int i = 0; i < len + 1 - step; i++)
            {
                OrRst[i] = OrRst[i]|A[i+step-1];
                rst.Add(OrRst[i]);                
            }
        }
        
        return rst.Count;
    }    
}

// Second edition
// Time Complexity: O(30N)
// Runtime: 432 ms
// Memory Usage: 44.9 MB

public class Solution {
    public int SubarrayBitwiseORs(int[] A) {
        
        int len = A.Length;
        if(len < 2) return 1;
        
        HashSet<int> rst = new HashSet<int>();
        HashSet<int> cur = new HashSet<int>();
        for(int i = 0; i < len; i++)
        {
            HashSet<int> cur2 = new HashSet<int>();
            // calc b[0][i], b[1][i], b[2][i]..., b[i][i]
            foreach(var ele in cur)
                cur2.Add(ele|A[i]);                
            
            cur2.Add(A[i]);
            cur = cur2;
            rst.UnionWith(cur);            
        }
        
        return rst.Count;
    }    
}