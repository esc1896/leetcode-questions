// 40 ms 74.95%
// 14.6 MB 43.1%
public class Solution {
    public int HammingDistance(int x, int y) {
        
        var xor = x ^ y;
        var rst = 0;
        
        for(int i = 0; i < 32 && xor != 0; i++)
        {
            rst += xor % 2;
            xor = xor / 2;
        }
        
        return rst;
    }
}
