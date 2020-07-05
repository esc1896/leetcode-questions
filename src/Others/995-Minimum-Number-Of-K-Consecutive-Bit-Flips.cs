// 288 ms 33.33%
// 42.3 MB 100%
public class Solution {
    public int MinKBitFlips(int[] A, int K) {
        
        int rst = 0;
        int len = A.Length;
        int flip = 0;
        
        for(int i = 0; i < len; i++ )
        {                                    
            if(A[i] == flip % 2)
            {
                if(i+K > len) return -1;
                
                rst++;
                flip++;
                A[i] -= 2;                
            }
            
            if(i >= K - 1 && A[i-K+1] < 0)
            {
                flip--;
                A[i-K+1] += 2;
            }                                    
        }
        
        return rst;        
    }
}
