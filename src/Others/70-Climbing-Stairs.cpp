// Runtime: 4 ms
// Memory Usage: 9.3 MB

class Solution {    
public:
    
    int* cal;
    
    int climbStairs(int n) {
        
        cal = new int[n]{0};    
        int rst = internalClimb(n);
        delete[] cal;
        return rst;
    }
    
    int internalClimb(int n) {
        
        if(n == 1)
        {
            cal[0] = 1;
            return cal[0];   
        }
        
        if(n == 2)
        {
            cal[1] = 2;
            return cal[1];   
        }
        
        if(cal[n-1] != 0) return cal[n-1];
        
        int rst = internalClimb(n-1) + internalClimb(n-2);
        cal[n-1] = rst;
        
        return rst;        
    }
};