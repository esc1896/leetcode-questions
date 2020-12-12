public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        
        var allowDict = new Dictionary<char,bool>();
        for(var i = 0; i < allowed.Length; i++)
        {
            allowDict.Add(allowed[i],true);
        }
        
        var rst = 0;
        for(var i = 0; i < words.Length; i++)
        {
            var index = 0;
            while(index < words[i].Length && allowDict.ContainsKey(words[i][index])){index++;}
            rst += (index == words[i].Length) ? 1 : 0;                    
        }
        
        return rst;        
    }
}
