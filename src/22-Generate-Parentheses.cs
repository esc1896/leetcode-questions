// Runtime: 244 ms
// Memory Usage: 31.2 MB

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        List<string> rst = new List<string>();
        if(n == 0) return rst;
        
        recursiveAdd(rst,"",0,0,n);

        return rst;        
    }
    
    private void recursiveAdd(IList<string> list, string str,
                             int open, int close, int max)
    {
        if(str.Length == max * 2)
        {
            list.Add(str);
            return;
        }
        
        if(close > open) return;
        
        if(open < max)
            recursiveAdd(list, str+"(",open+1,close,max);
        if(close < max)
            recursiveAdd(list, str+")",open,close+1,max);        
    }
}