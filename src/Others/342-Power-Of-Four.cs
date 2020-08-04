public class Solution {
    // 1   4   16    64      256 1024 4096 16384 65536 262144 1048576 4194304
    // 2-0 2-2 2-4   2-6     2-8 2-10 2-12 2-14  2-16  2-18   2-20    2-22    
    // 16777216  67108864    268435456  1073741824
    // 2-24      2-26        2-28       2-30 
    // 1   100 10000 1000000
    
    HashSet<int> powOfFour = new HashSet<int>{1,4,16,64,256,1024,4096,16384,65536,262144,1048576,4194304,16777216,67108864,268435456,1073741824};

    public bool IsPowerOfFour(int num) {
        
        /*
        if(num < 1) return false;        
        string bin = Convert.ToString(num,2);        
        if(bin.Length%2==0 || (num - (1 << (bin.Length - 1))) > 0) return false;        
        return true;
        */
        
        if(powOfFour.Contains(num)) return true;        
        return false;      
    }
}
