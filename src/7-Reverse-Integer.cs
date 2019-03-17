// Rumtime: 40 ms
// Memory Usage: 13.2 MB

public class Solution {
    public int Reverse(int x) {
        
        int rst = 0;
        
        while(x != 0)
        {
            int tail = x % 10;
            
            // Decide if overflow
            if(((rst > 0) && (rst > (Int32.MaxValue - tail) / 10))
                ||((rst < 0) && (rst < (Int32.MinValue - tail) / 10)))
            {
                return 0;
            }
                                    
            rst = rst * 10 + tail;
            x = x / 10;
        }
        
        return rst;        
    }
}
