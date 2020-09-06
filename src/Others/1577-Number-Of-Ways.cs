public class Solution {
    public int NumTriplets(int[] nums1, int[] nums2) {
        
        var rst = 0;
                
        var l2 = new Dictionary<int,int>();        
        for(int i = 0; i < nums2.Length; i++)
        {
            if(l2.ContainsKey(nums2[i]))
                l2[nums2[i]]++;
            else
                l2.Add(nums2[i],1);            
        }        
        rst += CountOneType(nums1, l2);
        
        var l1 = new Dictionary<int,int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            if(l1.ContainsKey(nums1[i]))
                l1[nums1[i]]++;
            else
                l1.Add(nums1[i],1);            
        }
        rst += CountOneType(nums2, l1);
                    
        return rst;
    }
    
    private int CountOneType(int[] nums, Dictionary<int,int> l)
    {
        var rst = 0;
        
        var done = new HashSet<int>();    
                
        for(int i = 0; i < nums.Length; i++)
        {
            long square = (long)nums[i] * nums[i];
            done = new HashSet<int>();
            foreach(var item in l)
            {                
                if(done.Contains(item.Key)) continue;
                done.Add(item.Key);
                
                var anotherKey = (int)(square/item.Key);
                if(square % item.Key == 0 && l.ContainsKey(anotherKey))
                {                                        
                    if(item.Key == square/item.Key)
                    {                        
                        if(item.Value > 1)
                        {
                            rst += item.Value * (item.Value-1) / 2;                                                  
                        }                        
                    }
                    else
                    {
                        rst += item.Value * l[anotherKey];
                        done.Add(anotherKey);
                    }                                        
                }
            }
        }
        
        return rst;
    }
    
}
