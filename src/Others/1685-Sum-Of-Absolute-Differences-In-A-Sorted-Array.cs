public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        
        var rst = new int[nums.Length];
        for(var i = 1; i < nums.Length; i++)
        {
            rst[0] += (nums[i] - nums[0]);
        }
        
        for(var i = 1; i < nums.Length; i++)
        {
            rst[i] = rst[i-1] + (2 * i - nums.Length) * (nums[i] - nums[i-1]);
        }
        
        return rst;
    }
}
