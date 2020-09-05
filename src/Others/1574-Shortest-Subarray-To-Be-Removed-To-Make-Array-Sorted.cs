public class Solution {
    public int FindLengthOfShortestSubarray(int[] arr) {        
        
        var first = -1;
        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i-1] > arr[i])
            {
                first = i-1;
                break;
            }
        }        
        if(first == -1) return 0;    
        
        var last = arr.Length;
        for(int i = arr.Length-1; i >= first; i--)
        {
            if(arr[i-1] > arr[i])
            {
                last = i;
                break;
            }
        }          
        
        var rst = last;
        for(int i = first; i >= 0; i--)
        {
            int j = last;
            while(j < arr.Length && arr[j] < arr[i]) j++;
            rst = rst > (j-i-1) ? (j-i-1) : rst;        
        }
        
        return rst;                
    }
}
