// Runtime: 312 ms
// Memory Usage: 42.3 MB

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        int len = nums.Length;
        IList<int> rst = new List<int>();
        if(len < 2) return rst;
        
        for(int i = 0; i < len; i++)
        {
            if(nums[i] < 1)
                continue;
            else if(nums[nums[i] - 1] > 0)
            {
                int tmp = nums[i];
                nums[i] = nums[tmp - 1];                
                nums[tmp - 1] = -1; // -1 stands for first time                             
                i--;
            }
            else
            {
                nums[nums[i] - 1]++; // 0 stands for twice
                nums[i] = -2; // -2 stands for i+1 didn't show
            }
        }
        
        for(int i = 0; i < len; i++)
        {
            if(nums[i] == 0)
                rst.Add(i+1);
        }
        
        return rst;
    }
}