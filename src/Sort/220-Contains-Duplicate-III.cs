public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        
        if(t < 0) return false;
        
        var kList = new SortedList<long,int>();
        var firstBatch = nums.Length < k + 1 ? nums.Length : k + 1;
        for(int i = 0; i < firstBatch; i++)
        {
            if(kList.ContainsKey(nums[i])) 
                return true;
            else 
                kList.Add(nums[i],1);
        }    
        
        if(FindDuplicateInBatch(kList,t)) return true;
        
        for(int i = 1; i < nums.Length - k; i++)
        {            
            if(nums[i-1] == nums[i+k]) continue;
                                
            kList.Add(nums[i+k],1);            
            kList.Remove(nums[i-1]);
            
            var index = kList.IndexOfKey(nums[i+k]);
            if((index > 0 && Math.Abs(kList.Keys[index]-kList.Keys[index-1]) <= t)
               ||(index < kList.Count() -1 && Math.Abs(kList.Keys[index]-kList.Keys[index+1]) <= t))
                return true;                    
        }
        
        return false;
    }
    
    private bool FindDuplicateInBatch(SortedList<long,int> list, long t)
    {
        for(int i = 0; i < list.Count(); i++)
        {         
            if(i < list.Count()-1 && Math.Abs(list.Keys[i] - list.Keys[i+1]) <= t) 
                return true;            
        }
        
        return false;
    }
}
