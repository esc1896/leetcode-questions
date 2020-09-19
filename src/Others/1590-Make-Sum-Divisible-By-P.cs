public class Solution {
    public int MinSubarray(int[] nums, int p) {
        
        long sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {            
            nums[i] = nums[i] % p;
            sum += nums[i];
        }                
        int k = (int)(sum % p);
        if(k == 0) return 0;
        
        // <mod, lastIndex>
        var dict = new Dictionary<int, int>();
        dict[0] = -1;
        sum = 0;
        int min = Int32.MaxValue;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            int res = (int)(sum % p);
            dict[res] = i;            
            
            if(res < k) res += p;
            
            if(!dict.ContainsKey(res - k)) continue;
            
            min = min > i-dict[res-k]? i-dict[res-k] : min;
        }                        
        
        return min == Int32.MaxValue || min == nums.Length ? -1:min;        
    }
}
