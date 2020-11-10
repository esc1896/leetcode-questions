public class Solution {
    public string StrWithout3a3b(int A, int B) {
        
        string rst = string.Empty;
        
        var first = A > B ? 'a' : 'b';
        var firstLen = A > B ? A : B;
        
        var sec = A > B ? 'b' : 'a';
        var secLen = A > B ? B : A;
        
        while(firstLen > secLen)
        {
            var len1 = firstLen > 2 ? 2 : firstLen;
            var len2 = secLen > 1 ? 1 : secLen;
            
            rst += new string(first, len1);            
            rst += new string(sec, len2);
            
            firstLen -= len1;
            secLen -= len2;
        }
        
        while(firstLen > 0 || secLen > 0)
        {
            var len1 = firstLen > 2 ? 2 : firstLen;
            var len2 = secLen > 2 ? 2 : secLen;
            
            rst += new string(first, len1);            
            rst += new string(sec, len2);
            
            firstLen -= len1;
            secLen -= len2;
        }
        
        return rst;        
    }
}

