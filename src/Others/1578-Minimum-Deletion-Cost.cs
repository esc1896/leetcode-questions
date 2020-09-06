public class Solution {
    public int MinCost(string s, int[] cost) {
        
        var rst = 0;
        var start = 0;
        var end = s.Length-1;
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] == s[start]) continue;
            
            end = i-1;
            if(end - start > 0)
            {
                rst += SubCost(start,end, cost);
            }
            start = i;
            end = s.Length-1;
        }
        
        if(end - start > 0)
        {
            rst += SubCost(start,end, cost);
        }
        
        return rst;
    }
    
    private int SubCost(int start, int end, int[] cost)
    { 
        int rst = 0;
        int left = start;
        for(int i = start+1; i <= end; i++)
        {
            if(cost[i] > cost[left])
            {
                rst += cost[left];
                left = i;
            }
            else
            {
                rst += cost[i];
            }
        }
        return rst;
    }
}
