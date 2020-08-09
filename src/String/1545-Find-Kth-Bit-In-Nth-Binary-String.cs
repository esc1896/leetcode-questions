public class Solution {
    public char FindKthBit(int n, int k) {
                
        var inverted = false;
        while(n > 1)
        {
            var halfLen = (1 << (n-1)) - 1;
            
            if(k == halfLen + 1) 
                return inverted ? '0' : '1';
            
            if(k > halfLen + 1)
            {
                k = 2 * halfLen + 2 - k;
                inverted = !inverted;
            }   
            
            n = n - 1;            
        }
        
        return inverted ? '1' : '0';
    }
}
