[200~public class Solution {
    public int HIndex(int[] citations) {
                
        var len = citations.Length;
        var c = new int[len+1];
        for(int i = 0; i<len; i++)
        {
            if(citations[i] >= len)
                c[len]++;
            else
                c[citations[i]]++;            
        }
        
        var count = 0;
        for(int i = len; i>=0; i--)
        {
            count += c[i];
            if(count >= i)
                return i;
        }
        
        return 0;
    }
}
