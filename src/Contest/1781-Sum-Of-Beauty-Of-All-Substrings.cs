public class Solution {
    public int BeautySum(string s) {
        
        var freq = new int[26];                
        var sum = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            for(int a = 0; a < 26; a++) freq[a]=0;
                    
            for(int j = i; j < s.Length; j++)
            {
                freq[s[j]-'a']++;
                
                var max = Int32.MinValue;
                var min = Int32.MaxValue;
                
                for(int a = 0; a < 26; a++)
                {
                    if(freq[a] > 0)
                    {
                        max = Math.Max(max, freq[a]);
                        min = Math.Min(min, freq[a]);
                    }
                }
                //Console.WriteLine($"{i} {j} {max} {min} {sum}");
                sum += max - min;
            }            
        }                
        
        return sum;
    }        
}
