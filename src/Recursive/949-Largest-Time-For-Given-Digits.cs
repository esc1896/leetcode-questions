public class Solution {
    public string LargestTimeFromDigits(int[] A) {
        
        var rst = string.Empty;
        
        for(int a = 0; a < A.Length; a++)
        {
            for(int b = 0; b < A.Length; b++)
            {
                for(int c = 0; c < A.Length; c++)
                {
                    if(a == b || b == c || c == a) continue;
                    var tmpH = $"{A[a]}{A[b]}";
                    var tmpM = $"{A[c]}{A[6-a-b-c]}";
                    if(string.Compare(tmpH,"23") <= 0 && string.Compare(tmpM,"59") <= 0)
                    {
                        var tmp = $"{tmpH}:{tmpM}";
                        if(string.IsNullOrEmpty(rst))
                        {
                            rst = tmp;                            
                        }
                        else if(string.Compare(rst,tmp) < 0)
                        {
                            rst = tmp;
                        }
                    }                    
                }                
            }            
        }        
        
        return rst;                
    }
}
