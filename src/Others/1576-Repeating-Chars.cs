public class Solution {
    public string ModifyString(string s) {
                        
        var rst = new List<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] != '?')
            {
                rst.Add(s[i]);
            }
            else
            {
                var pre = i == 0 ? '?' : rst[i-1];
                var after = i == s.Length - 1 ? '?':s[i+1];                               
                rst.Add(FindGoodChar(pre,after));
            }            
        }
        
        return new string(rst.ToArray());
    }
    
    private char FindGoodChar(char pre, char after)
    {        
        var tmp = 'a';
        
        if(pre == '?' && after == '?')
        {
            return tmp;
        }                        
        
        if(pre == '?')
        {
            while(tmp == after) tmp++;
            return tmp;            
        }
        
        if(after == '?')
        {
            while(tmp == pre) tmp++;
            return tmp;            
        }
                
        while(tmp == pre || tmp == after) tmp++;
        return tmp;                
    }            
}
