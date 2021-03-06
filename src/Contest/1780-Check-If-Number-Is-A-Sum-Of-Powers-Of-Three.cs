public class Solution {
    public bool CheckPowersOfThree(int n) {
        
        var rst = true;
        
        while(n > 0)
        {
            var mod = n % 3;
            if(mod > 1) 
            {
                rst = false;
                break;
            }                
            n = n / 3;            
        }                
        
        return rst;        
    }
}
