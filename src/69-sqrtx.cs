// Runtime: 40ms
// Memory Usage: 13.1 MB

public class Solution {
    public int MySqrt(int x) {
        if ((x == 0) || (x == 1)) return x;

        int high = x, low = 1, rst = x / 2;

        while (true)
        {
            if (rst > x / rst)
            {
                high = rst - 1;                    
            }
            else
            {
                if ((rst + 1) > x / (rst + 1))
                {
                    return rst;
                }
                low = rst + 1;
            }

            rst = low + (high - low) / 2;
        }
    }
}