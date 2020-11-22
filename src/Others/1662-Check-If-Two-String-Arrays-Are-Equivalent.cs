public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        
        var str1 = string.Join(string.Empty,word1);
        var str2 = string.Join(string.Empty,word2);
        
        return str1.Equals(str2,StringComparison.OrdinalIgnoreCase);                        
    }
}
