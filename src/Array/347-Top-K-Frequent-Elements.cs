public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var freqMap = new Dictionary<int, int>();
        var bucket = new List<int>[nums.Length+1];
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(freqMap.ContainsKey(nums[i])) freqMap[nums[i]] ++;
            else freqMap[nums[i]] = 1;
        }
        
        foreach(var pair in freqMap)
        {
            var num = pair.Key;
            var freq = pair.Value;
            
            if(bucket[freq] == null) bucket[freq] = new List<int>();
            bucket[freq].Add(num);            
        }
        
        var rst = new List<int>();
        for(int i = nums.Length, j = 0; i >= 0 && j < k; i--)
        {
            if(bucket[i] != null)
            {
                rst.AddRange(bucket[i]);
                j += bucket[i].Count();                
            }
        }
        
        return rst.ToArray();
    }
}
