// Runtime: 188 ms
// Memory Usage: 27.5 MB

    public int MajorityElement(int[] nums) {        
        Array.Sort(nums);
        return nums[nums.Length/2];                        
    }


// Runtime: 124 ms
// Memory Usage: 27.5 MB

    public int MajorityElement(int[] nums) {        
        int len = nums.Length;
        int virtualStack = 0;
        int virtualStackCount = 0;
        
        for(int i = 0; i < len; i++)
        {
            if(virtualStackCount == 0)
            {
                virtualStack = nums[i];
                virtualStackCount = 1;                
            }
            else if(nums[i] == virtualStack)
            {
                virtualStackCount++;
            }
            else
            {
                virtualStackCount--;
            }
        }
        
        return virtualStack;
    }
