public class Solution {
    public int TitleToNumber(string s) {
        
        var sum = s[0]-'A'+1;
        for(int i = 1; i < s.Length; i++)
        {
            sum = sum * 26 + (s[i]-'A'+1);
        }
        return sum;
    }
}
