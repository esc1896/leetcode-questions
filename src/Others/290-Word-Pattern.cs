public class Solution {
    public bool WordPattern(string pattern, string str) {
        
        var list = str.Split(' ');
        if(pattern.Length != list.Count()) return false;
        
        var tmp = new Dictionary<char,string>();        
        for(int i = 0; i < pattern.Length; i++)
        {
            if(tmp.ContainsKey(pattern[i]))
            {
                if(string.Compare(tmp[pattern[i]], list[i]) != 0) return false;
            }
            else
            {
                if(tmp.ContainsValue(list[i])) return false;
                tmp.Add(pattern[i], list[i]);                            
            }
                
        }
        
        return true;        
    }
}
