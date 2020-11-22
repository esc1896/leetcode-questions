public class Solution {
    public string GetSmallestString(int n, int k) {
        
        var rst = new string[n];    
        var sum = n;
        
        for(var i = 0; i < n; i++)
        {
            rst[i] = "a";
        }
        
        var index = n - 1;
        while(sum < k && index >= 0)
        {
            if(sum + 25 <= k)
            {
                rst[index] = "z";
                sum += 25;
                index--;
            }
            else
            {
                rst[index] = ((char)('a' + k - sum)).ToString();
                break;
            }
        }
        
        return string.Join(string.Empty,rst);                                
    }
}
