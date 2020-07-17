public class Solution {
    public double MyPow(double x, int n) {
        
        if(n == 0) return 1;
        if(n == 1) return x;
        if(n == -1) return 1/x;
        
        var rst = MyPow(x,n/2);
        rst = rst * rst * (n%2 == 0 ? 1 : MyPow(x,n >=0 ? 1 : -1));        
        return rst;
    }
}
