public class Solution {
    public int WaysToMakeFair(int[] nums) {
                        
        if(nums.Length == 1) return 1;
        
        var half = nums.Length/2;
        
        var even = new long[half + 1]; 
        var odd = new long[half + 1];
        
        even[0] = nums[0];
        odd[0] = nums[1];      
        for(int i = 1; i < half; i++)
        {
            even[i] += even[i-1] + nums[i*2];
            odd[i] += odd[i-1] + nums[i*2 + 1];
        }
        
        var evenLast = half - 1;
        var oddLast = half - 1;
        if(nums.Length % 2 == 1)
        {
            even[half] = even[half-1] + nums[nums.Length-1];
            evenLast = half;
        }
        
        var rst = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            long evenBefore = 0, oddBefore = 0, evenAfter = 0, oddAfter = 0;
        
            if(i % 2 == 1)
            {
                if(i == 1)
                {
                    evenBefore = even[0];
                    oddBefore = 0;
                }
                else
                {
                    evenBefore = even[i/2];
                    oddBefore = odd[i/2-1];                                                            
                }   
                
                oddAfter = even[evenLast] - evenBefore;                        
                evenAfter = odd[oddLast] - (oddBefore + nums[i]);                                                
            }
            else
            {
                if(i == 0)
                {
                    evenBefore = 0;
                    oddBefore = 0;                    
                }
                else
                {
                    evenBefore = even[i/2-1];
                    oddBefore = odd[i/2-1];                    
                }
                    
                evenAfter = odd[oddLast] - oddBefore;
                oddAfter = even[evenLast] - (evenBefore + nums[i]);                
            }                     
            
            if(evenBefore + evenAfter == oddBefore + oddAfter) rst++;                                                
        }
                
        return rst;
    }
}
