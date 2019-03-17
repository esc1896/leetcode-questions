// Runtime: 136 ms
// Memory Usage: 32.9 MB

public class Solution {
    public int MaxWidthRamp(int[] A) {
        int maxWid = 0;
        int len = A.Length;
        
        if(len < 2) return 0;
        
        // Read instructions from top 1 in discussion section
        Stack<int> index = new Stack<int>();
        for(int i = 0; i < len; i++)
        {
            if((index.Count == 0)||(A[index.Peek()] > A[i]))
                index.Push(i);
        }
        
        for(int i = len - 1; i > 0; i--)
        {
            while((index.Count != 0)&&(A[index.Peek()] <= A[i]))
            {
                maxWid = Math.Max(maxWid, i - index.Pop());
            }
        }                
        
        return maxWid;
    }
}