// Runtime: 372 ms
// Memory usage: 33.2 MB

public class Solution {
    public void ReverseString(char[] s) {
        
        int len = s.Length;
        if(len < 2) return; 
        
        char tmp;
        
        for(int i = 0; i < len / 2; i++)
        {
            tmp = s[len - 1 -i];
            s[len - 1 - i] = s[i];
            s[i] = tmp;
        }
        
        return;        
    }
}