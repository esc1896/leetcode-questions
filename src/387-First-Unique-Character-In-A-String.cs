// 33.3 MB
// 84 ms
public class Solution {
    public int FirstUniqChar(string s) {
        var charArray = s.ToCharArray();
        
        var alphaArray = new int[26];
        for(int i = 0; i < 26; i++)
            alphaArray[i] = -1;
                
        for(int i = 0; i < charArray.Length; i++)
        {
            if(alphaArray[charArray[i]-'a'] == -2) continue;
            
            if(alphaArray[charArray[i]-'a'] >= 0) 
                alphaArray[charArray[i]-'a'] = -2; // duplicated
            else
                alphaArray[charArray[i]-'a'] = i;                            
        }
        
        var minIndex = Int32.MaxValue;
        for(int i = 0; i < 26; i++)
        {
            if(alphaArray[i] >=0 && alphaArray[i] < minIndex)
            {
                minIndex = alphaArray[i];
            }
        }
        
        return minIndex == Int32.MaxValue ? -1 : minIndex;
    }
}
