// First version
// Runtime: 96 ms
// Memory Usage: 22.5 MB

public class Solution {
    public string ReverseWords(string s) {
        string[] strList = s.Split(" ");
        int len = strList.Length;
        if(len < 2) return s;
        
        // Clean up empty string after splitting
        string[] rstList = new string[len];
        int count = 0;
        for(int i = 0; i < len; i++)
        {
            if(!String.IsNullOrEmpty(strList[i]))
            {
                rstList[count++] = strList[i];
            }            
        }
        
        string tmp = String.Empty;
        for(int i = 0; i < count / 2; i++)
        {
            tmp = rstList[count - 1 - i];
            rstList[count - 1 - i] = rstList[i];
            rstList[i] = tmp;            
        }
        
        return String.Join(" ", rstList).Trim();        
    }
}