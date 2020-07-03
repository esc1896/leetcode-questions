// 340 ms 27.14%
// 32.7 MB 50.59%
public class Solution {
    public IList<string> CommonChars(string[] A) {
                    
        var freqMin = new int[26];
        
        var arr1 = A[0].ToCharArray();
        for(int i = 0; i < arr1.Length; i++)
        {            
            freqMin[arr1[i]-'a']++;
        }
        
        for(int i = 1; i < A.Length; i++)
        {
            var arr2 = A[i].ToCharArray();
            var freq2 = new int[26];
            for(int j = 0; j < arr2.Length; j++)
            {
                freq2[arr2[j]-'a']++;                
            }
            
            for(int j = 0; j < 26; j++)
            {
                freqMin[j] = freqMin[j] > freq2[j] ? freq2[j] : freqMin[j];
            }
        }
        
        var ret = new List<string>();
        for(int j = 0; j < 26; j++)
        {
            while(freqMin[j]>0)
            {
                ret.Add(Char.ToString((char)('a'+j)));
                freqMin[j]--;
            }                
        }
        
        return ret;                
    }    
}
