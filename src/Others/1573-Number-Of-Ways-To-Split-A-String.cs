public class Solution {
    public int NumWays(string s) {
        
        long count = 0;
        var list = new List<long>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '1')
            {
                count++;            
                list.Add((long)i);
            }
        }
        
        if(count%3 != 0 || (count == 0 && s.Length < 3 )) return 0;
        
        long mod = (long)(Math.Pow(10,9)+7);
        if(count == 0)
        {
            count = ((long)(s.Length - 1) * (long)(s.Length - 2) / 2) % mod;            
            return (int)count;            
        }
                
        long interval = count/3;
        long index1_1 = list[interval-1];
        long index1_2 = list[interval];
        long index2_1 = list[2*interval - 1];
        long index2_2 = list[2*interval];        
        
        count = (index1_2 - index1_1) * (index2_2 - index2_1) % mod;                
        return (int)count;                                
    }
}
