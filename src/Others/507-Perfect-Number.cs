// Runtime: 36 ms
// Memory Usage: 12.9 MB

public class Solution {
    public bool CheckPerfectNumber(int num) {
        
        if(num <= 1) return false;
        
        bool rst = false;
        int sum = 0;
        for(int i = (int)Math.Sqrt(num); i > 1; i--)
        {
            if (num % i == 0) sum += (i + num/i);
            //if (sum > num) break;
        }
        
        sum++; // Add 1        
        if(sum == num) rst = true;
        
        return rst;
    }
}