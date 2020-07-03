// Runtime: 84 ms
// Memory Usage: 16.6 MB

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        
        bool rst = true;
        int index = 0;
        int[] arr = new int[10 + 1]; // to hold each dec bit, Int32.MaxValue < 10 pow 10
        
        while(x != 0)
        {
            arr[index++] = x % 10;
            x = x/10;
        }
        
        for(int i = index - 1; i > index/2 - 1 ; i--)
        {
            if(arr[i] != arr[index - 1 - i])
            {
                rst = false;
                break;
            }            
        }
        
        return rst;        
    }
}